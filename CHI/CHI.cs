using System;
using System.Drawing;

namespace CHI {
    public class CHI {
        static string Data;

        public CHI (string data) {
            Data = data;
        }

        public static Bitmap ToBitmap() {
            Bitmap ReturnValue = new Bitmap(1,1);
            return ReturnValue;
		}
    }
}