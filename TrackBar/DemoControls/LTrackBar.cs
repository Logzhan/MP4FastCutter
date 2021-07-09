using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DemoControls
{
    [DefaultEvent("LValueChanged")]
    public class LTrackBar:Control
    {
        float barStart;           // 截取部分颜色开始
        float barEnd;             // 截取部分颜色结束
        public LTrackBar()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            barStart = 0;
            barEnd = 0;
            CreateControl();
        }

        #region 属性

        private Color _BarColor = Color.FromArgb(128, 255, 128);//浅绿
        /// <summary>
        /// 背景条颜色
        /// </summary>
        [Category("DemoUI"),Description("背景条颜色")]
        public Color L_BarColor
        {
            get { return _BarColor; }
            set
            {
                _BarColor = value;
                Invalidate();
            }
        }

        private Color _SubColor = Color.FromArgb(255, 128, 0);   // 橙色
        private Color _SliderColor = Color.FromArgb(0, 192, 0);  // 绿
        /// <summary>
        /// 滑块颜色
        /// </summary>
        [Category("DemoUI"), Description("滑块颜色")]
        public Color L_SliderColor
        {
            get { return _SliderColor; }
            set
            {
                _SliderColor = value;
                Invalidate();
            }
        }

        private bool _IsRound = true;
        /// <summary>
        /// 是否是圆角<para>默认：是</para>
        /// </summary>
        [Category("DemoUI"), Description("是否是圆角\r\n默认：是")]
        public bool L_IsRound
        {
            get { return _IsRound; }
            set
            {
                _IsRound = value;
                Invalidate();
            }
        }

        private int _Minimum = 0;
        /// <summary>
        /// 最小值<para>范围：大于等于0</para>
        /// </summary>
        [Category("DemoUI"), Description("最小值<para>范围：大于等于0</para>")]
        public int L_Minimum
        {
            get { return _Minimum; }
            set
            {
                _Minimum = value;
                if (_Minimum >= _Maximum) _Minimum = _Maximum - 1;
                if (_Minimum < 0) _Minimum = 0;
                Invalidate();
            }
        }

        private int _Maximum = 100;
        /// <summary>
        /// 最大值
        /// </summary>
        [Category("DemoUI"), Description("最大值")]
        public int L_Maximum
        {
            get { return _Maximum; }
            set
            {
                _Maximum = value;
                if (_Maximum <= _Minimum) _Maximum = _Minimum + 1;
                Invalidate();
            }
        }
        
        private int _Value = 0;
        /// <summary>
        /// 当前值
        /// </summary>
        [Category("DemoUI"), Description("当前值")]
        public int L_Value
        {
            get { return _Value; }
            set
            {
                _Value = value;
                if (_Value < _Minimum) _Value = _Minimum;
                if (_Value > _Maximum) _Value = _Maximum;
                Invalidate();

                if(LValueChanged != null){
                    LValueChanged(this, new LEventArgs(_Value));
                }              
            }
        }


        private int _barSubStart = 0;
        /// <summary>
        /// 当前值
        /// </summary>
        [Category("DemoUI"), Description("截取开始位置")]
        public int L_barSubStart
        {
            get { return _barSubStart; }
            set
            {
                _barSubStart = value;
                if (_barSubStart < _Minimum) _barSubStart = _Minimum;
                if (_barSubStart > _Maximum) _barSubStart = _Maximum;
                Invalidate();
            }
        }

        private int _barSubEnd = 0;
        /// <summary>
        /// 当前值
        /// </summary>
        [Category("DemoUI"), Description("截取开始位置")]
        public int L_barSubEnd
        {
            get { return _barSubEnd; }
            set
            {
                _barSubEnd = value;
                if (_barSubEnd < _Minimum) _barSubEnd = _Minimum;
                if (_barSubEnd > _Maximum) _barSubEnd = _Maximum;
                if (_barSubEnd < _barSubStart)_barSubEnd = _barSubStart;

                Invalidate();
            }
        }

        private Orientation _Orientation = Orientation.Horizontal_LR;
        /// <summary>
        /// 方向<para>默认：水平，从左到右</para>
        /// </summary>
        [Category("DemoUI"), Description("方向\r\n默认：水平，从左到右")]
        public Orientation L_Orientation
        {
            get { return _Orientation; }
            set
            {
                Orientation old = _Orientation;
                _Orientation = value;
                if ((old == Orientation.Horizontal_LR || old == Orientation.Horizontal_RL) && (_Orientation == Orientation.Vertical_BT || _Orientation == Orientation.Vertical_TB))
                {
                    Size = new Size(Size.Height, Size.Width);
                }

                if ((_Orientation == Orientation.Horizontal_LR || _Orientation == Orientation.Horizontal_RL) && (old == Orientation.Vertical_BT || old == Orientation.Vertical_TB))
                {
                    Size = new Size(Size.Height, Size.Width);
                }
                Invalidate();
            }
        }

        private int _BarSize = 10;
        /// <summary>
        /// 滑条高度（水平）/宽度（垂直）
        /// </summary>
        [Category("DemoUI"), Description(" 滑条高度（水平）/宽度（垂直）")]
        public int L_BarSize
        {
            get { return _BarSize; }
            set
            {
                _BarSize = value;
                if (_BarSize < 1) _BarSize = 1;
                if (_Orientation == Orientation.Horizontal_LR || _Orientation == Orientation.Horizontal_RL)
                {
                    Size = new Size(Width, _BarSize);
                }
                else
                {
                    Size = new Size(_BarSize, Height);
                }
            }
        }

        #endregion

        #region 
        /// <summary>
        /// 委托
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public delegate void LValueChangedEventHandler(object sender, LEventArgs e);
        /// <summary>
        /// 值发生改变时引发的事件
        /// </summary>
        public event LValueChangedEventHandler LValueChanged;
        #endregion

        #region 
        private MouseStatus mouseStatus=MouseStatus.Leave;
        private PointF mousePoint=Point.Empty;
        #endregion

        #region
        private void pValueToPoint()
        {
            float fCapHalfWidth = 0;
            float fCapWidth = 0;
            if (_IsRound)
            {
                fCapWidth = _BarSize;
                fCapHalfWidth = _BarSize / 2.0f;
            }

            float fRatio = Convert.ToSingle(_Value-_Minimum) / (_Maximum - _Minimum);
            if (_Orientation == Orientation.Horizontal_LR)
            {
                float fPointValue = fRatio * (Width - fCapWidth) + fCapHalfWidth;
                mousePoint = new PointF(fPointValue, fCapHalfWidth);
            }
            else if (_Orientation == Orientation.Horizontal_RL)
            {
                float fPointValue = Width - fCapHalfWidth - fRatio * (Width - fCapWidth);
                mousePoint = new PointF(fPointValue, fCapHalfWidth);
            }
            else if (_Orientation == Orientation.Vertical_TB)
            {
                float fPointValue = fRatio * (Height - fCapWidth) + fCapHalfWidth;
                mousePoint = new PointF(fCapHalfWidth, fPointValue);
            }
            else
            {
                float fPointValue = Height - fCapHalfWidth - fRatio * (Height - fCapWidth);
                mousePoint = new PointF(fCapHalfWidth, fPointValue);
            }

        }

        private void pPointToValue()
        {
            float fCapHalfWidth = 0;
            float fCapWidth = 0;
            if (_IsRound)
            {
                fCapWidth = _BarSize;
                fCapHalfWidth = _BarSize / 2.0f;
            }

            if (_Orientation == Orientation.Horizontal_LR)
            {
                float fRatio = Convert.ToSingle(mousePoint.X - fCapHalfWidth) / (Width - fCapWidth);
                _Value = Convert.ToInt32(fRatio * (_Maximum - _Minimum)+_Minimum);
            }
            else if (_Orientation == Orientation.Horizontal_RL)
            {
                float fRatio = Convert.ToSingle(Width - mousePoint.X - fCapHalfWidth) / (Width - fCapWidth);
                _Value = Convert.ToInt32(fRatio * (_Maximum - _Minimum) + _Minimum);
            }
            else if (_Orientation == Orientation.Vertical_TB)
            {
                float fRatio = Convert.ToSingle(mousePoint.Y - fCapHalfWidth) / (Height - fCapWidth);
                _Value = Convert.ToInt32(fRatio * (_Maximum - _Minimum) + _Minimum);
            }
            else
            {
                float fRatio = Convert.ToSingle(Height - mousePoint.Y - fCapHalfWidth) / (Height - fCapWidth);
                _Value = Convert.ToInt32(fRatio * (_Maximum - _Minimum) + _Minimum);
            }
            if (_Value < _Minimum) _Value = _Minimum;
            if (_Value > _Maximum ) _Value = _Maximum;

            if (LValueChanged != null)
            {
                LValueChanged(this, new LEventArgs(_Value));
            }   

        }

        #endregion

        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
        {
            int iHeight = _BarSize;
            if (_Orientation == Orientation.Horizontal_LR || _Orientation == Orientation.Horizontal_RL)
            {
                base.SetBoundsCore(x, y, width, iHeight, specified);
            }
            else
            {
                base.SetBoundsCore(x, y, iHeight, height, specified);
            }
        }

        /*--
         * 
         * 
         * 
         * -*/
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            pValueToPoint();
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;

            Pen penBarBack = new Pen(_BarColor, _BarSize);
            Pen penBarFore = new Pen(_SliderColor, _BarSize);
            Pen penBarSub = new Pen(_SubColor, _BarSize);

            float fCapHalfWidth = 0;
            float fCapWidth =  0;
            if (_IsRound)
            {
                fCapWidth = _BarSize;
                fCapHalfWidth = _BarSize / 2.0f;
                penBarBack.StartCap = LineCap.Round;
                penBarBack.EndCap = LineCap.Round;

                penBarFore.StartCap = LineCap.Round;
                penBarFore.EndCap = LineCap.Round;

                penBarSub.StartCap = LineCap.Round;
                penBarSub.EndCap = LineCap.Round;
            }

            float fPointValue = 0;
            if (_Orientation == Orientation.Horizontal_LR || _Orientation == Orientation.Horizontal_RL)
            {
                e.Graphics.DrawLine(penBarBack, fCapHalfWidth, Height / 2f, Width - fCapHalfWidth, Height / 2f);

                fPointValue = mousePoint.X;
                
                if (fPointValue < fCapHalfWidth) fPointValue = fCapHalfWidth;
                if (fPointValue > Width - fCapHalfWidth) fPointValue = Width - fCapHalfWidth;
                
            }
            else
            {
                e.Graphics.DrawLine(penBarBack, Width / 2f, fCapHalfWidth, Width / 2f, Height - fCapHalfWidth);

                fPointValue = mousePoint.Y;
                if (fPointValue < fCapHalfWidth) fPointValue = fCapHalfWidth;
                if (fPointValue > Height - fCapHalfWidth) fPointValue = Height - fCapHalfWidth;
            }

            // 这里绘制水平进度条
            if (_Orientation == Orientation.Horizontal_LR)
            {
                float st = (_barSubStart / (float)L_Maximum) * this.Size.Width;
                float ed = (_barSubEnd / (float)L_Maximum) * this.Size.Width;

                if (ed > Width - fCapHalfWidth) ed = ed - fCapHalfWidth;

                e.Graphics.DrawLine(penBarFore, fCapHalfWidth, Height / 2f, fPointValue, Height / 2f);

                if (_barSubStart > 0 && _barSubEnd > 0 && _barSubEnd >= _barSubStart)
                {
                    e.Graphics.DrawLine(penBarSub, st, Height / 2f, ed, Height / 2f);
                }
            }
            else if (_Orientation == Orientation.Horizontal_RL)
            {
                e.Graphics.DrawLine(penBarFore,  fPointValue, Height / 2f, Width - fCapHalfWidth, Height / 2f);
            }
            else if (_Orientation == Orientation.Vertical_TB)
            {
                e.Graphics.DrawLine(penBarFore, Width / 2f, fCapHalfWidth, Width / 2f, fPointValue);
            }
            else
            {
                e.Graphics.DrawLine(penBarFore, Width / 2f,  fPointValue, Width / 2f, Height - fCapHalfWidth);
            }
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e); 
            mouseStatus = MouseStatus.Down;
            mousePoint = e.Location;
            pPointToValue();
            Invalidate();
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e); 
            if (mouseStatus == MouseStatus.Down)
            {
                mousePoint = e.Location;
                pPointToValue();
                Invalidate();
            }
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            mouseStatus = MouseStatus.Up;
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            mouseStatus = MouseStatus.Enter;
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            mouseStatus = MouseStatus.Leave;
        }
    }
}
