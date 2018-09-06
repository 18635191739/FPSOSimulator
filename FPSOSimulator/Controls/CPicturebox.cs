using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace FPSOSimulator.Controls
{
    /// <summary>
    /// saperate line
    /// </summary>
    public partial class CPicturebox : UserControl
    {
        /// <summary>
        /// constructure
        /// </summary>
        public CPicturebox()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ShowFlag
        /// </summary>
        public enum ShowFlag
        {
            /// <summary>
            /// herizontal
            /// </summary>
            Horizontal,
            /// <summary>
            /// vertical
            /// </summary>
            Vertical
        }

        private ShowFlag mshowflag = ShowFlag.Horizontal;
        /// <summary>
        /// showflag
        /// </summary>
        public ShowFlag showflag
        {
            get
            {
                return mshowflag;
            }
            set
            {
                mshowflag = value;
            }
        }

        /// <summary>
        /// repaint
        /// </summary>
        /// <param name="pe"></param>
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            Graphics g = pe.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            
            RectangleF[] rect = new RectangleF[2];
            switch (mshowflag)
            {
                case ShowFlag.Horizontal:
                    
                    rect[0].X = 0.0f;
                    rect[0].Y = 0.0f;
                    rect[0].Width = this.Size.Width / 2.0f;
                    rect[0].Height = this.Size.Height;
                    rect[1].X = (float)(rect[0].X + rect[0].Width);
                    rect[1].Y = rect[0].Y;
                    rect[1].Width = this.Size.Width / 2.0f;
                    rect[1].Height = this.Size.Height;
                    PointF[] pt = new PointF[6];
                    pt[0] = new PointF(rect[0].X, rect[0].Y);
                    pt[1] = new PointF(rect[0].X + rect[0].Width, rect[0].Y);
                    pt[2] = new PointF(rect[1].X + rect[1].Width, rect[1].Y);
                    pt[5] = new PointF(rect[0].X, rect[0].Y + rect[0].Height);
                    pt[4] = new PointF(rect[0].X + rect[0].Width, rect[0].Y + rect[0].Height);
                    pt[3] = new PointF(rect[1].X + rect[1].Width, rect[1].Y + rect[1].Height);

                    PathGradientBrush pathbr = new PathGradientBrush(pt);
                    Color outcolor = this.BackColor;
                    Color incolor = Color.FromArgb(255, 255, 255, 255);
                    pathbr.SurroundColors = new Color[] { outcolor, incolor, outcolor, outcolor, incolor, outcolor };
                    pathbr.CenterColor = incolor;
                    pathbr.CenterPoint = new PointF(rect[0].X + rect[0].Width, rect[0].Y + rect[0].Height / 2.0f);
                    g.FillPolygon(pathbr, pt);
                    pathbr.Dispose();
                    
                    break;
                case ShowFlag.Vertical:
                    LinearGradientBrush[] saperatelinebrush = new LinearGradientBrush[2];
                    rect[0].X = 0.0f;
                    rect[0].Y = 0.0f;
                    rect[0].Width = this.Size.Width;
                    rect[0].Height = this.Size.Height / 2.0f;
                    rect[1].X = rect[0].X;
                    rect[1].Y = (float)(rect[0].Y + this.Size.Height / 2.0f);
                    rect[1].Width = this.Size.Width;
                    rect[1].Height = this.Size.Height / 2.0f + 1.0f;
                    saperatelinebrush[0] = new LinearGradientBrush(rect[0], this.BackColor, Color.FromArgb(255, 255, 255, 255), LinearGradientMode.Vertical);
                    saperatelinebrush[1] = new LinearGradientBrush(rect[0], Color.FromArgb(255, 255, 255, 255), this.BackColor, LinearGradientMode.Vertical);
                    
                    g.FillRectangle(saperatelinebrush[0], rect[0]);
                    g.FillRectangle(saperatelinebrush[1], rect[1]);

                    saperatelinebrush[0].Dispose();
                    saperatelinebrush[1].Dispose();
                    break;
            }

            g.Dispose();
        }
    }
}
