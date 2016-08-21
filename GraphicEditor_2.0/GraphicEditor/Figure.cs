using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace GraphicEditor
{
    
    public abstract class Figure
    {
        protected List<Point> points;
        protected Pen fp;
        protected Brush fb; 
        
        protected GraphicsPath gp;

        public Figure(List<Point>lp, Pen pen, Brush brush)
        {
            this.points = new List<Point>(lp);
            this.fp = pen;
            this.fb = brush;         
            this.gp = new GraphicsPath();
        }
        public Figure(List<Point> lp, Brush brush)
        {
            this.points = new List<Point>(lp);         
            this.fb = brush; 
        }

        public GraphicsPath GP
        {
            set { gp = value; }
            get { return gp; }
        }
        public List<Point> Points
        {
            set { points = value; }
            get { return points; }
        }
        public Pen FP
        {
            set { fp = value; }
            get { return fp; }
        }
        public Brush FB
        {
            set { fb = value; }
            get { return fb; }
        }

        /// <summary>
        /// Extension point to use implementation inheritance
        /// no implemantation is provided.
        /// </summary>
        public abstract void Draw(Graphics g);

    }

    #region Create a class hierarchy in which each specific shape class derives from a common base class
    
    public class Line : Figure
    {
        public Line(List<Point> lp, Pen pen, Brush brush) : base(lp, pen, brush) { }
        
        /// <summary>
        /// Provide implemenatation for the abstract method.
        /// </summary>
        /// <param name="g"></param>
        public override void Draw(Graphics g)
        {
            ///<summary>
            ///Method draws a sequance of lines.
            ///</summary>
            
            g.DrawPath(fp, gp);
        }
    }

    public class RectangleGE : Figure
    {
        public RectangleGE(List<Point> lp, Pen pen, Brush brush) : base(lp, pen, brush) { }

        /// <summary>
        /// Provide implemenatation for the abstract method.
        /// </summary>
        /// <param name="g"></param>
        public override void Draw(Graphics g)
        {
            g.DrawRectangle(fp, new Rectangle(points[0].X,points[0].Y, Math.Abs(points[1].X - points[0].X),
                                Math.Abs(points[1].Y - points[0].Y)));
        }
    }

    public class EllipseGE : Figure
    {
        public EllipseGE(List<Point> lp, Pen pen, Brush brush) : base(lp, pen, brush) { }

        /// <summary>
        /// Provide implemenatation for the abstract method.
        /// </summary>
        /// <param name="g"></param>
        public override void Draw(Graphics g)
        {
            ///<summary>
            ///The method draws an elipse.
            /// </summary>
            g.DrawEllipse(fp, new Rectangle(points[0].X, points[0].Y, Math.Abs(points[1].X - points[0].X),
                Math.Abs(points[1].Y - points[0].Y)));
        }
    }

    public class BizieGE : Figure
    {
        public BizieGE(List<Point> lp, Pen pen, Brush brush) : base(lp, pen, brush) { }

        /// <summary>
        /// Provide implemenatation for the abstract method.
        /// </summary>
        /// <param name="g"></param>
        public override void Draw(Graphics g)
        {
            ///<summary>
            ///Method draws a sequance of bizie.
            ///</summary>
            g.DrawPath(fp, gp);
        }
    }

    public class CurveGE : Figure
    {
        public CurveGE(List<Point> lp, Pen pen, Brush brush) : base(lp, pen, brush) { }

        /// <summary>
        /// Provide implemenatation for the abstract method.
        /// </summary>
        /// <param name="g"></param>
        public override void Draw(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.HighQuality;

            ///<summary>
            ///Method draws a sequance of curves.
            ///</summary>
            g.DrawPath(fp, gp);
        }
    }

    public class FillRectGE : Figure
    {
        public FillRectGE(List<Point> lp, Pen pen, Brush brush) : base(lp, pen, brush) { }

        /// <summary>
        /// Provide implemenatation for the abstract method.
        /// </summary>
        /// <param name="g"></param>
        public override void Draw(Graphics g)
        {
            ///<summary>
            ///Fills the interior of a rectangle specified by a Rectangle structure.
            /// </summary>
            g.FillRectangle(fb, new Rectangle(points[0].X,
                    points[0].Y, Math.Abs(points[1].X - points[0].X),
                    Math.Abs(points[1].Y - points[0].Y)));
        }
    }

    public class FillEllipseGE : Figure
    {
        public FillEllipseGE(List<Point> lp, Pen pen, Brush brush) : base(lp, pen, brush) { }

        /// <summary>
        /// Provide implemenatation for the abstract method.
        /// </summary>
        /// <param name="g"></param>
        public override void Draw(Graphics g)
        {
            ///<summary>
            ///The method uses a brush to fill the interior of an ellipse that is specified by a rectangle.
            /// </summary>
            g.FillEllipse(fb, new Rectangle(points[0].X, points[0].Y, Math.Abs(points[1].X - points[0].X), 
                Math.Abs(points[1].Y - points[0].Y)));
        }
    }

    public class StringGE : Figure
    {
        protected string txt;
        protected Font font;

        public StringGE(List<Point> lp, Brush brush, string tx, Font _font): base(lp, brush)
        {
            this.txt = tx;
            this.font = _font;
        }

        /// <summary>
        /// Provide implemenatation for the abstract method.
        /// </summary>
        /// <param name="g"></param>
        public override void Draw(Graphics g)
        {
            ///<summary>
            ///Draws the specified text string at the specified location with the specified Brush and 
            ///Font objects
            /// </summary>
            g.DrawString(txt, font, fb, points[0].X, points[0].Y);
        }
    }
    #endregion
}
