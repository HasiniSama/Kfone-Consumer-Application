﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Kfone_Consumer_Application.Component
{
    class CardPanel: Panel
    {
        //Fields
        private int borderRadius = 30;
        private float gradientAngle = 90F;
        private Color gradientTopColor = Color.DodgerBlue;
        private Color gradientBottomColor = Color.CadetBlue;

        //Constructor
        public CardPanel()
        {
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
            this.Size = new Size(350, 200);
        }

        //Properties
        public int BorderRadius 
        { 
            get => borderRadius;
            set {borderRadius = value; this.Invalidate();}
        }
        public float GradientAngle 
        { 
            get => gradientAngle;
            set { gradientAngle = value; this.Invalidate(); }
        }
        public Color GradientTopColor 
        { 
            get => gradientTopColor; 
            set {gradientTopColor = value; this.Invalidate(); }
        }
        public Color GradientBottomColor 
        { 
            get => gradientBottomColor; 
            set {gradientBottomColor = value; this.Invalidate(); }
        }

        //Methods
        private GraphicsPath GetPath(RectangleF rectangle, float radius)
        {
            GraphicsPath graphicPath = new GraphicsPath();
            graphicPath.StartFigure();
            graphicPath.AddArc(rectangle.Width - radius, rectangle.Height - radius, radius, radius, 0, 90);
            graphicPath.AddArc(rectangle.X, rectangle.Height - radius, radius,radius, 90,90);
            graphicPath.AddArc(rectangle.X, rectangle.Y, radius, radius, 180, 90);
            graphicPath.AddArc(rectangle.Width - radius, rectangle.Y, radius, radius, 270, 90);
            graphicPath.CloseFigure();
            return graphicPath;
        }

        //Overridden Methods
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            //Gradient
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, this.GradientTopColor, this.gradientBottomColor, this.gradientAngle);
            Graphics graphics = e.Graphics;
            graphics.FillRectangle(brush, ClientRectangle);

            //Border Radius
            RectangleF rectangleF = new RectangleF(0, 0, this.Width, this.Height);
            if (borderRadius > 2)
            {
                using (GraphicsPath graphicsPath = GetPath(rectangleF, borderRadius))
                using (Pen pen = new Pen(this.Parent.BackColor, 2))
                {
                    this.Region = new Region(graphicsPath);
                    e.Graphics.DrawPath(pen, graphicsPath);
                }

            }
            else this.Region = new Region(rectangleF);

        }
    }
}