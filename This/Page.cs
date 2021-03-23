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
        public Page()
        {
            Initialize();
        }

        public Page(double width) : this (){ }

        public Page(double width, double height) : this()
        {
            Width = width > Screen.MaxWidth ? 0 : width;
            Height = height > Screen.MaxHeight ? 0 : height;
        }
    }
}
