using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Консоль8
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Соображения высшего порядка, а также консультация с профессионалами из IT позволяет выполнить важнейшие задания по разработке всесторонне сбалансированных нововведений. Таким образом в " +
                         "32.02.2012, постоянное информационно-техническое обеспечение нашей деятельности позволяет выполнить важнейшие задания по разработке ключевых компонентов планируемого обновления. Таким образом, рамки и...";
            Regex pattern = new Regex("^(0?[1-9]|[12][0-9]|3[01])[.](0?[1-9]|1[0-2])[.]2020$");


            Console.ReadKey();
        }
    }
}
