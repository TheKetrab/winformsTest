using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class IconBtn : Button
    {

        public IconBtn()
        {
            //this.Paint += IconBtn_Paint;
        }


        private string _x;



        public IconFont.IconFontE KeyCode { get; set; }
        public int KeyCodeCustom { get; set; }

        protected int KeyVal
        {
            get
            {
                if (KeyCode == IconFont.IconFontE.Custom)
                {
                    return (int)KeyCodeCustom;
                }

                    return (int) KeyCode;
            }
        }



        private string _t;
        public override string Text { get => "";
            set { _t = value; }
        }

        private void IconBtn_Paint(object sender, PaintEventArgs e)
        {

            string iconChar = char.ConvertFromUtf32((int)KeyCode);
            Font iconFont = new Font(IconFont.FF, 18.5f, FontStyle.Bold);
            e.Graphics.DrawString(iconChar, iconFont, new SolidBrush(Color.Orange), new PointF(10, 10));

        }

        public void AlignToParent()
        {
            if (Parent is FlowLayoutPanel flp)
            {
                if (flp.FlowDirection == FlowDirection.LeftToRight
                    || flp.FlowDirection == FlowDirection.RightToLeft)
                {
                    this.Height = Parent.Height - this.Margin.Bottom - this.Margin.Top;
                    this.Width = this.Height;
                }
                else
                {
                    this.Width = Parent.Width - this.Margin.Left - this.Margin.Right;
                    this.Height = this.Width;

                }
            }
        }

        public void DrawIcon(PaintEventArgs e)
        {
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            string iconChar = char.ConvertFromUtf32(KeyVal);
            Font iconFont = new Font(IconFont.FF, 18.5f, FontStyle.Bold);
            
            e.Graphics.DrawString(iconChar, iconFont,
                new SolidBrush(this.ForeColor),
                new Rectangle(0, 0, this.Width, this.Height),
                stringFormat);
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            AlignToParent();
            DrawIcon(pevent);
        }
    }
}
