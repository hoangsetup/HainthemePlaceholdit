using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace HainthemePlaceholdit
{
    class MyImageFile
    {
        public string Path { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public int TextSize { get; set; }
        public string BgColor { get; set; }
        public string TxtColor { get; set; }
        public string Text { get; set; }
        public string Format { get; set; }

        public MyImageFile(string path)
        {
            Image image = Image.FromFile(path);
            this.Path = path;
            this.Name = path.Split('\\')[path.Split('\\').Length - 1];
            //this.Text = image.Size.Width + "x" + image.Size.Height;
            this.Format = System.IO.Path.GetExtension(path);
            this.Size = image.Width + "x" + image.Height;
        }
    }
}
