using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
<<<<<<< HEAD

            int x = 0;
            int y = 0;
            var calc = new Calc();

            if(args.Length == 2)
            {
                if(!int.TryParse(args[0], out x))
                {
                    x = 70;
                }
                if (!int.TryParse(args[0], out y))
                {
                    y = 90;
                }
            }
            else
            {
                #region Ввод данных
                Console.WriteLine("Введите X: ");
                var strx = Console.ReadLine();
                if (!int.TryParse(strx, out x))
                {
                    x = 70;
                }

                Console.WriteLine("Введите Y: ");
                var stry = Console.ReadLine();
                if (!int.TryParse(stry, out y))
                {
                    y = 40;
                }

                #endregion

            }
            var result = calc.Sum(x,y);
            
            Console.WriteLine("Сумма: " + result.ToString());

            Console.ReadKey();
        }
    }
}
=======
            Console.ReadKey();
        }
    }
}
>>>>>>> b0a356bdc3bb2d626f632510f5d73d79ad7337f8
