using System;
using System.Drawing;
using System.Windows.Forms;

// License: http://creativecommons.org/licenses/by-sa/2.0/uk/

namespace CDBurnerXP.Controls
{
    public class Separator : System.Windows.Forms.Label
    {
        private int m_Offset = 4;

        [System.ComponentModel.Browsable(false)]
        public override bool AutoSize
        {
            get { return false; }
            set { }
        }

        public Separator()
        {
            this.ForeColor = SystemColors.ActiveCaption;
            base.AutoSize = false;
            base.TextAlign = ContentAlignment.MiddleLeft;
        }

        private static int MeasureDisplayStringWidth(Graphics graphics, string text, Font font)
        {
            if (text == string.Empty)
                return 0;

            StringFormat format = new StringFormat();
            RectangleF rect = new RectangleF(0, 0, 1000, 1000);
            CharacterRange[] ranges = { new CharacterRange(0, text.Length) };
            Region[] regions = { new Region() };

            format.SetMeasurableCharacterRanges(ranges);
            regions = graphics.MeasureCharacterRanges(text, font, rect, format);
            rect = regions[0].GetBounds(graphics);

            return (int)rect.Right + 1;
        }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            base.OnPaint(e);

            int stringWidth;

            if (Text.Length == 0)
            {
                m_Offset = 0;
                stringWidth = 0;
            }
            else
            {
                stringWidth = MeasureDisplayStringWidth(e.Graphics, Text, Font);
            }

            // First, draw the grey line
            Point startPoint = new Point(stringWidth + m_Offset, Height / 2);
            if (RightToLeft == RightToLeft.Yes)
            {
                startPoint.X = Width - startPoint.X;
            }

            Point endPoint = new Point(Width - 2, Height / 2);
            if (RightToLeft == RightToLeft.Yes)
            {
                endPoint.X = 2;
            }

            using (Pen p = new Pen(SystemColors.ButtonShadow, 1))
            {
                e.Graphics.DrawLine(p, startPoint, endPoint);
            }

            // Now the white line below
            startPoint.Y += 1;
            endPoint.Y += 1;
            using (Pen p = new Pen(SystemColors.ButtonHighlight, 1))
            {
                e.Graphics.DrawLine(p, startPoint, endPoint);
            }

            // Now the last piece, so that it looks like that
            // GGGGGGGGGGGGGGGGGGGGGGGGGGGW
            // WWWWWWWWWWWWWWWWWWWWWWWWWWWW
            if (RightToLeft == RightToLeft.Yes)
            {
                endPoint.X -= 1;
            }
            else
            {
                endPoint.X += 1;
            }

            startPoint = endPoint;
            endPoint.Y -= 1;
            using (Pen p = new Pen(SystemColors.ButtonHighlight, 1))
            {
                e.Graphics.DrawLine(p, startPoint, endPoint);
            }

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }
    }
}