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
        public FontCollection.SegMDL2 FontChar { get; set; }
        public int FontCharCustom { get; set; }
        public float FontSize { get; set; } = 18.5f;
        public FontStyle FontStyle { get; set; } = FontStyle.Bold;


        protected int KeyVal => (FontChar == FontCollection.SegMDL2.Custom) 
            ? FontCharCustom : (int)FontChar;


        private string _text;
        public override string Text 
        {
            get => ""; 
            set => _text = value;
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
            Font iconFont = new Font(FontCollection.FFSegMDL2, FontSize, FontStyle);
            
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
