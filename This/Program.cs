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
            Screen.MaxWidth = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Max Height");
            Screen.MaxHeight = Convert.ToDouble(Console.ReadLine());

            Page page = new Page();
            Console.WriteLine($"{page.Width} + {page.Height}");
            Page pageWidth = new Page(4);
            Console.WriteLine($"{pageWidth.Width} + {pageWidth.Height}");
            Page pageWidthHeight = new Page(6,4);
            Console.WriteLine($"{pageWidthHeight.Width} + {pageWidthHeight.Height}");
            Console.ReadKey();
        }
    }
}
