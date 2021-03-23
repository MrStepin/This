using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This
{
    class Page
    {
        public double Width { get; set; }

        public double Height { get; set; }

        private void Initialize()
        {
            Console.WriteLine("Page was created");
        }

        public Page() : this(0, 0, 0, 0) { }

        public Page( double Width) : this (Width, 0, 5, 0){ }

        public Page(double Width, double Height, double maxWidth, double maxHeight)
        {
            Initialize();
            if (Width > maxWidth)
            {
                this.Width = 0;
            }
            else
            {
                this.Width = Width;
            }

            if (Height > maxHeight)
            {
                this.Height = 0;
            }
            else
            {
                this.Height = Height;
            }
        }
    }
}
