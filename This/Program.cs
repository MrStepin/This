using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Max Width");
            Screen.MaxWidht = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Max Height");
            Screen.MaxHeight = Convert.ToDouble(Console.ReadLine());

            Page page = new Page();
            Console.WriteLine($"{page.Width} + {page.Height}");
            Page pageWidth = new Page(5);
            Console.WriteLine($"{pageWidth.Width} + {pageWidth.Height}");
            Page pageWidthHeight = new Page(6,4, Screen.MaxWidht, Screen.MaxHeight);
            Console.WriteLine($"{pageWidthHeight.Width} + {pageWidthHeight.Height}");
            Console.ReadKey();
        }
    }
}
