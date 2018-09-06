using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace FPSOSimulator.Controls
{
    /// <summary>
    /// Cpanel
    /// </summary>
    public partial class CPanel : Panel
    {
        /// <summary>
        /// constructure
        /// </summary>
        public CPanel()
        {
            InitializeComponent();

            SetStyle(ControlStyles.DoubleBuffer, true);
        }

        /// <summary>
        /// another constructure
        /// </summary>
        /// <param name="container"></param>
        public CPanel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            SetStyle(ControlStyles.DoubleBuffer, true);
        }

        /// <summary>
        /// show style flag
        /// </summary>
        public enum ShowStyle
        {
            /// <summary>
            /// updown line
            /// </summary>
            UpDn,
            /// <summary>
            /// downup line
            /// </summary>
            DnUp,
            /// <summary>
            /// leftright line
            /// </summary>
            LfRt,
            /// <summary>
            /// to middle line
            /// </summary>
            ToMiddle,
            /// <summary>
            /// for main form
            /// </summary>
            MainFrmPanel,
            /// <summary>
            /// 右边选择框
            /// </summary>
            RtSelectPanel
        }
        
        private ShowStyle mshowstyle = ShowStyle.UpDn;
        /// <summary>
        /// show flag
        /// </summary>
        public ShowStyle showstyle
        {
            get
            {
                return mshowstyle;
            }
            set
            {
                mshowstyle = value;
                this.Invalidate();
            }
        }

        private byte mClrOffSet = 25;
        /// <summary>
        /// close color offset
        /// </summary>
        public byte ClrOffSet
        {
            get
            {
                return mClrOffSet;
            }
            set
            {
                mClrOffSet = value;
            }
        }

        private int mUphtPercent = 10;
        /// <summary>
        /// UphtPercent
        /// </summary>
        public int UphtPercent
        {
            get
            {
                return mUphtPercent;
            }
            set
            {
                mUphtPercent = value;
            }
        }

        private int mMiddleClrOffSetPercent = 2;
        /// <summary>
        /// middle color offset
        /// </summary>
        public int MiddleClrOffSetPercent
        {
            get
            {
                return mMiddleClrOffSetPercent;
            }
            set
            {
                mMiddleClrOffSetPercent = value;
            }
        }

        /// <summary>
        /// paint the panel
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            
            try
            {
                Graphics gr = e.Graphics;
                Image bmp = new Bitmap(this.ClientRectangle.Width, this.ClientRectangle.Height, 0, PixelFormat.Format32bppArgb, IntPtr.Zero);
                Graphics g = Graphics.FromImage(bmp);
                g.SmoothingMode = SmoothingMode.AntiAlias;
                gr.SmoothingMode = SmoothingMode.AntiAlias;

                byte myRed = (byte)(this.BackColor.R + mClrOffSet);
                byte myGreen = (byte)(this.BackColor.G + mClrOffSet);
                byte myBlue = (byte)(this.BackColor.B + mClrOffSet);
                if (myRed > 255)
                    myRed = 255;
                if (myGreen > 255)
                    myGreen = 255;
                if (myBlue > 255)
                    myBlue = 255;

                switch (mshowstyle)
                {
                    case ShowStyle.UpDn:

                        Color clrupdn = this.BackColor;
                        Color clrupdnMiddle = Color.FromArgb(this.BackColor.A, this.BackColor.R + mClrOffSet / mMiddleClrOffSetPercent, this.BackColor.G + mClrOffSet / mMiddleClrOffSetPercent, this.BackColor.B + mClrOffSet / mMiddleClrOffSetPercent);
                        Color clrupdntop = Color.FromArgb(this.BackColor.A, myRed, myGreen, myBlue);

                        PointF[] pts = new PointF[8];
                        pts[0] = new PointF(0.0f, 0.0f);
                        pts[1] = new PointF(this.Size.Width / 2.0f, 0.0f);
                        pts[2] = new PointF(this.Size.Width, 0.0f);
                        pts[3] = new PointF(this.Size.Width, (this.Height / (float)UphtPercent));
                        pts[4] = new PointF(this.Size.Width, this.Size.Height);
                        pts[5] = new PointF(this.Size.Width / 2.0f, this.Size.Height);
                        pts[6] = new PointF(0.0f, this.Size.Height);
                        pts[7] = new PointF(0.0f, (this.Height / (float)UphtPercent));
                        PathGradientBrush pathbr = new PathGradientBrush(pts);
                        pathbr.SurroundColors = new Color[8] { clrupdntop, clrupdntop, clrupdntop, clrupdnMiddle, clrupdn, clrupdn, clrupdn, clrupdnMiddle };
                        pathbr.CenterColor = clrupdnMiddle;
                        pathbr.CenterPoint = new PointF(this.Size.Width / 2.0f, (this.Height / (float)UphtPercent));

                        g.FillRectangle(pathbr, this.ClientRectangle);
                        ////draw top rectangle
                        //Rectangle rectup = new Rectangle(0, 0, this.Width, (int)(this.Height / UphtPercent));
                        //LinearGradientBrush brup = new LinearGradientBrush(rectup, clrupdntop, clrupdnMiddle, LinearGradientMode.Vertical);
                        //g.FillRectangle(brup, rectup);

                        ////draw down rectangle
                        //LinearGradientBrush brupdn = new LinearGradientBrush(this.ClientRectangle, clrupdnMiddle, clrupdn, LinearGradientMode.Vertical);
                        //Rectangle rectupdn = new Rectangle(0, rectup.Height, this.Width, this.Height);
                        //g.FillRectangle(brupdn, rectupdn);

                        //draw two circles
                        Rectangle rectrnd = new Rectangle(new Point(0, 0), new Size(10, 10));
                        LinearGradientBrush brrnd = new LinearGradientBrush(rectrnd, Color.FromArgb(155, 12, 235, 160), Color.FromArgb(155, 30, 253, 178), LinearGradientMode.ForwardDiagonal);
                        Rectangle rectrnd1 = new Rectangle(new Point(this.Width - 20, this.Height - 20), new Size(10, 10));
                        for (int i = 0; i < 3; ++i)
                        {
                            rectrnd1.X = rectrnd1.X - 20;
                            rectrnd1.Y = rectrnd1.Y - 8;
                            g.FillEllipse(brrnd, rectrnd1);
                        }

                        gr.DrawImage(bmp, new Point(0, 0));
                        pathbr.Dispose();
                        bmp.Dispose();
                        brrnd.Dispose();
                        //brup.Dispose();
                        //brupdn.Dispose();
                        g.Dispose();
                        gr.Dispose();
                        break;
                    case ShowStyle.MainFrmPanel:
                        
                        Color clrmainfrmup = Color.FromArgb(255, 18, 19, 107);
                        Color clrmainfrmdn = Color.FromArgb(255, 1, 3, 33);
                        LinearGradientBrush brmainfrm = new LinearGradientBrush(this.ClientRectangle, clrmainfrmup, clrmainfrmdn, LinearGradientMode.Vertical);
                        int roundr = 50;

                        //outline
                        int inneroffset = 1;                        
                        Rectangle innerrect = new Rectangle(this.ClientRectangle.X + inneroffset / 2, this.ClientRectangle.Y + inneroffset / 2, this.ClientRectangle.Width - inneroffset, this.ClientRectangle.Height - inneroffset);
                        GraphicsPath path = GetGraphicsPath(innerrect, roundr);
                        g.FillPath(brmainfrm, path);

                        Color clroutline = Color.FromArgb(255, 11, 47, 134);
                        Pen penoutline = new Pen(clroutline);
                        penoutline.Width = 1;
                        g.DrawPath(penoutline, path);

                        //outer round
                        //roundr = this.ClientRectangle.Size.Width / 7;
                        Rectangle rectmiddlernd = new Rectangle(this.ClientRectangle.Size.Width / 2 - roundr, this.ClientRectangle.Height / 2 - roundr, roundr * 2, roundr * 2);
                        Color clrroundup = Color.FromArgb(255, 5, 5, 65);
                        Color clrrounddn = Color.FromArgb(255, 3, 1, 25);
                        LinearGradientBrush brmiddlernd = new LinearGradientBrush(rectmiddlernd, clrroundup, clrrounddn, LinearGradientMode.Vertical);
                        //g.FillEllipse(brmiddlernd, rectmiddlernd);

                        //Pen outroundpen = new Pen(Color.FromArgb(100, 11, 4, 134));
                        //outroundpen.Width = 2;
                        //g.DrawEllipse(outroundpen, rectmiddlernd);

                        ////middle round 1
                        //roundr = this.ClientRectangle.Size.Width / 9;
                        //rectmiddlernd = new Rectangle(this.ClientRectangle.Size.Width / 2 - roundr, this.ClientRectangle.Height / 2 - roundr, roundr * 2, roundr * 2);
                        //clrroundup = Color.FromArgb(150, 123, 214, 236);
                        //clrrounddn = Color.FromArgb(255, 9, 39, 120);
                        //brmiddlernd = new LinearGradientBrush(rectmiddlernd, clrroundup, clrrounddn, LinearGradientMode.Vertical);
                        //g.FillEllipse(brmiddlernd, rectmiddlernd);

                        ////middle round 2                        
                        //roundr = this.ClientRectangle.Size.Width / 12;
                        //rectmiddlernd = new Rectangle(this.ClientRectangle.Size.Width / 2 - roundr, this.ClientRectangle.Height / 2 - roundr, roundr * 2, roundr * 2);
                        //g.FillEllipse(new SolidBrush(Color.FromArgb(255, 0, 0, 65)), rectmiddlernd);

                        ////middle round 3      
                        //roundr = this.ClientRectangle.Size.Width / 13;
                        //rectmiddlernd = new Rectangle(this.ClientRectangle.Size.Width / 2 - roundr, this.ClientRectangle.Height / 2 - roundr, roundr * 2, roundr * 2);
                        //g.FillEllipse(new SolidBrush(Color.FromArgb(255, 9, 9, 79)), rectmiddlernd);

                        ////inner round
                        //roundr = this.ClientRectangle.Size.Width / 15;
                        //rectmiddlernd = new Rectangle(this.ClientRectangle.Size.Width / 2 - roundr, this.ClientRectangle.Height / 2 - roundr, roundr * 2, roundr * 2);
                        ////g.FillEllipse(new SolidBrush(Color.FromArgb(255, 8, 45, 104)), rectmiddlernd);

                        // Create a path that consists of a single ellipse.
                        GraphicsPath innerroundpath = new GraphicsPath();
                        //innerroundpath.AddEllipse(rectmiddlernd.X, rectmiddlernd.Y, rectmiddlernd.Width, rectmiddlernd.Height);

                        // Use the path to construct a brush.
                        //PathGradientBrush pthGrBrush = new PathGradientBrush(innerroundpath);
                        //pthGrBrush.WrapMode = WrapMode.Tile;
                        //// Set the color at the center of the path to blue.
                        //pthGrBrush.CenterColor = Color.FromArgb(255, 8, 13, 70);

                        // Set the color along the entire boundary 
                        // of the path to aqua.
                        //Color[] colors = { Color.FromArgb(255, 10, 117, 168) };
                        //pthGrBrush.SurroundColors = colors;
                        //pthGrBrush.CenterPoint = new PointF((float)rectmiddlernd.X, (float)rectmiddlernd.Y);
                        //g.FillEllipse(pthGrBrush, rectmiddlernd);

                        gr.DrawImage(bmp, new Point(0, 0));

                        path.Dispose();
                        brmiddlernd.Dispose();
                        brmainfrm.Dispose();
                        penoutline.Dispose();                                                
                        bmp.Dispose();                        
                        g.Dispose();
                        gr.Dispose();
                        break;
                    case ShowStyle.ToMiddle:
                        Color clrtomiddlelf = this.BackColor;


                        Color clrtomiddleMiddle = Color.FromArgb(this.BackColor.A, myRed, myGreen, myBlue);

                        Rectangle rectlf = new Rectangle(0, 0, this.Width / 2, this.Height);
                        LinearGradientBrush brlf = new LinearGradientBrush(rectlf, clrtomiddlelf, clrtomiddleMiddle, LinearGradientMode.Horizontal);
                        g.FillRectangle(brlf, rectlf);

                        Rectangle rectrt = new Rectangle(this.Width / 2, 0, this.Width / 2, this.Height);
                        LinearGradientBrush brrt = new LinearGradientBrush(rectlf, clrtomiddleMiddle, clrtomiddlelf, LinearGradientMode.Horizontal);
                        g.FillRectangle(brrt, rectrt);

                        gr.DrawImage(bmp, new Point(0, 0));

                        bmp.Dispose();
                        brlf.Dispose();
                        brrt.Dispose();
                        g.Dispose();
                        gr.Dispose();
                        break;
                    case ShowStyle .RtSelectPanel :
                        Color clrrtselectpanelup = Color.FromArgb(255, 18, 19, 107);
                        Color clrrtselectpaneldn = Color.FromArgb(255, 1, 3, 33);
                        LinearGradientBrush brrtselectpanelfrm = new LinearGradientBrush(this.ClientRectangle, clrrtselectpanelup, clrrtselectpaneldn, LinearGradientMode.Vertical);
                        int roundselectr = 10;

                        //outline
                        inneroffset = 1;
                        innerrect = new Rectangle(this.ClientRectangle.X + inneroffset / 2, this.ClientRectangle.Y + inneroffset / 2, this.ClientRectangle.Width - inneroffset, this.ClientRectangle.Height - inneroffset);
                        path = GetGraphicsPath(innerrect, roundselectr);
                        g.FillPath(brrtselectpanelfrm, path);

                        clroutline = Color.FromArgb(255, 11, 47, 134);
                        penoutline = new Pen(clroutline);
                        penoutline.Width = 1;
                        g.DrawPath(penoutline, path);         
              
                        gr.DrawImage(bmp, new Point(0, 0));

                        path.Dispose();                       
                        brrtselectpanelfrm.Dispose();
                        penoutline.Dispose();
                        bmp.Dispose();
                        g.Dispose();
                        gr.Dispose();
                        break;

                    }
                
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        
        /// <summary>
        /// round rectangle path
        /// </summary>
        /// <param name="rc"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        private GraphicsPath GetGraphicsPath(Rectangle rc, int r)
        {
            int x = rc.X, y = rc.Y, w = rc.Width, h = rc.Height;
            GraphicsPath gpath = new GraphicsPath();
            gpath.AddArc(x, y, r, r, 180, 90);//左上角圆弧
            gpath.AddArc(x + w - r, y, r, r, 270, 90);//右上角圆弧
            gpath.AddArc(x + w - r, y + h - r, r, r, 0, 90);//右下角圆弧
            gpath.AddArc(x, y + h - r, r, r, 90, 90);//左下角圆弧
            gpath.CloseFigure();//闭合
            return gpath;
        }         
    }
}
