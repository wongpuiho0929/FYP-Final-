using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Login
{
    class CheckBoxEx : CheckBox
    {
        public CheckBoxEx()
        {
        }

        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                base.Text = value;
                Size size = TextRenderer.MeasureText(value, Font);
                if (Width < size.Width + ClientSize.Height)
                    Width = size.Width + ClientSize.Height;
            }
        }

        public override Font Font
        {
            get
            {
                return base.Font;
            }
            set
            {
                base.Font = value;
                Size size = TextRenderer.MeasureText(Text, value);
                if (Width < size.Width + ClientSize.Height)
                    Width = size.Width + ClientSize.Height;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            int h = ClientSize.Height;
            Rectangle rc = new Rectangle(new Point(0, 0), new Size(h, h));
            e.Graphics.Clear(Parent.BackColor);
            ControlPaint.DrawCheckBox(e.Graphics, rc,
                this.Checked ? ButtonState.Checked : ButtonState.Normal);
            SizeF size = e.Graphics.MeasureString(Text, Font);
            e.Graphics.DrawString(Text, this.Font,
                new SolidBrush(Color.Blue), new PointF(h, size.Height < h ? (h - size.Height) / 2 : 0));
        }
    }
    
}
