using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public static class IconFont
    {
        private static PrivateFontCollection pfc;
        public static FontFamily FF => pfc.Families[0];

        static IconFont()
        {
            pfc = new PrivateFontCollection();
            //Extracting icon fonts from the WF Fabric.ttf file and adding into system memory.
            Stream fontAsStream = typeof(IconFont).Assembly.GetManifestResourceStream("WindowsFormsApp1.segmdl2.ttf");
            byte[] fontAsByte = new byte[fontAsStream.Length];
            fontAsStream.Read(fontAsByte, 0, (int)fontAsStream.Length);
            fontAsStream.Close();
            IntPtr memPointer = System.Runtime.InteropServices.Marshal.AllocHGlobal(System.Runtime.InteropServices.Marshal.SizeOf(typeof(byte)) * fontAsByte.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontAsByte, 0, memPointer, fontAsByte.Length);
            pfc.AddMemoryFont(memPointer, fontAsByte.Length);

        }

        public enum IconFontE
        {
            Custom = 0,
            LastArrow = 0xe700,
            Edit = 0xE70F,
            Save = 0xE74E,
            Setting = 0xE713
        }

    }
}
