using System.Drawing.Drawing2D;

namespace CustomPictureBox
{
    public partial class MyPictureBox : PictureBox
    {
        public MyPictureBox()
        {
            InitializeComponent();
        }
        private int borderSize = 2;
        private Color borderColor = Color.PaleVioletRed;
        private Color borderColor2 = Color.RoyalBlue;
        private DashStyle borderLineStyle = DashStyle.Solid;
        private DashCap borderCapStyle = DashCap.Flat;
        private float gradientAngle = 45F;

        public int BorderSize
        {
            get { return borderSize; }
            set { borderSize = value; Invalidate(); }
        }
        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; Invalidate(); }
        }
        public Color BorderColor2
        {
            get { return borderColor2; }
            set { borderColor2 = value; Invalidate(); }
        }
        public DashStyle BorderLineStyle
        {
            get { return borderLineStyle; }
            set { borderLineStyle = value; Invalidate(); }
        }
        public DashCap BorderCapStyle
        {
            get { return borderCapStyle; }
            set { borderCapStyle = value; Invalidate(); }
        }
        public float GradientAngle
        {
            get { return gradientAngle; }
            set { gradientAngle = value; Invalidate(); }
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Size = new Size(this.Width, this.Height);
            Invalidate();
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            var graphics = pe.Graphics;
            var rectContourSmooth = Rectangle.Inflate(this.ClientRectangle, -borderSize, -borderSize);
            var rectBorder = Rectangle.Inflate(this.ClientRectangle, -borderSize - 1, -borderSize - 1);
            var smoothSize = BorderSize > 0 ? 3 : 1;
            using (var borderGColor = new LinearGradientBrush(rectBorder, borderColor, borderColor2, gradientAngle))
            using (var pathRegion = new GraphicsPath())
            using (var penSmooth = new Pen(this.Parent.BackColor, smoothSize))
            using (var penBorder = new Pen(borderGColor, borderSize))
            {
                penBorder.DashStyle = borderLineStyle;
                penBorder.DashCap = borderCapStyle;
                pathRegion.AddEllipse(rectContourSmooth);
                this.Region = new Region(pathRegion);
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                graphics.DrawEllipse(penSmooth, rectContourSmooth);
                if (borderSize > 0)
                {
                    graphics.DrawEllipse(penBorder, rectBorder);
                }
            }
        }
    }
}
