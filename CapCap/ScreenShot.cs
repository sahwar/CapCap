﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;

namespace CapCap
{
    internal class ScreenShot
    {
        public bool CaptureCursor { get; set; } = false;
        public string SaveFolder { get; set; } = string.Empty;
        public string NamePattern { get; set; } = string.Empty;
        public string Number { get; set; } = string.Empty;
        public ImageFormat Format { get; set; } = ImageFormat.Jpeg;

        #region WinAPI
        [DllImport("user32.dll")]
        private static extern bool GetCursorInfo(out CursorInfo pci);
        private struct CursorInfo
        {
            public Int32 cbSize;
            public Int32 flags;
            public IntPtr hCursor;
            public Point ptScreenPos;
        }
        #endregion

        public ScreenShot(bool cursor, string folder, string pattern, string number, ImageFormat format)
        {
            CaptureCursor = cursor;
            SaveFolder = folder;
            NamePattern = pattern;
            Number = number;
            Format = format;
        }

        public ScreenShotInfo CaptureAndSave()
        {
            Image img = captureScreen(CaptureCursor);
            var fullname = saveImage(img);
            bool success = fullname[0] == '[' ? false : true;
            return new ScreenShotInfo(success, fullname, Auxiliary.GetFileName(fullname), success ? fullname : "");
        }

        private Image captureScreen(bool capture_cursor)
        {
            // Capture screen.
            Image img = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics graphic = Graphics.FromImage(img);
            graphic.CopyFromScreen(new Point(0, 0), new Point(0, 0), Screen.AllScreens[0].Bounds.Size);

            if (capture_cursor)
            {
                CursorInfo ci;
                ci.cbSize = Marshal.SizeOf(typeof(CursorInfo));
                GetCursorInfo(out ci);
                Cursor cursor = new Cursor(ci.hCursor);
                cursor.Draw(graphic, new Rectangle(ci.ptScreenPos.X, ci.ptScreenPos.Y, cursor.Size.Width, cursor.Size.Height));
                cursor.Dispose();
            }
            graphic.Dispose();
            return img;
        }

        private string saveImage(Image img)
        {
            try
            {
                string filename = getFullname();
                img.Save(filename, Format);
                img.Dispose();
                return filename;
            }
            catch (Exception exp)
            {
                return $"[Exception:{exp.Message}]";
            }
        }

        private string getFullname()
        {
            var nPattern = new NamePattern(NamePattern, int.Parse(Number));
            return string.Format(@"{0}\{1}.{2}", SaveFolder, nPattern.Convert(), Format.ToString().ToUpper());
        }
    }

    internal class ScreenShotInfo
    {
        public bool Success { get; }
        public string FullName { get; }
        public string FileName { get; }
        public string Message { get; }

        public ScreenShotInfo(bool success, string fullname, string filename, string message)
        {
            Success = success;
            FullName = fullname;
            FileName = filename;
            Message = message;
        }
    }
}