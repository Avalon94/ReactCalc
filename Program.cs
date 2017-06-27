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
            int select;
            double x = 0;
            double y = 0;
            Calc decision = new Calc();
            Console.WriteLine("\t\tКалькулятор");
            
            Console.WriteLine("1.Сложение");
            Console.WriteLine("2.Вычитание");
            Console.WriteLine("3.Умножение");
            Console.WriteLine("4.Деление");
            Console.WriteLine("5.Возведение в квадрат");
            Console.WriteLine("6.Квадратный корень");

            Console.WriteLine("Выберите операцию: ");
            select = Convert.ToInt32(Console.ReadLine());
            
            switch (select)
            {
                case 1:
                    
                        Console.WriteLine("Введите x: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        
                        Console.WriteLine("Введите y: ");
                        y = Convert.ToInt32(Console.ReadLine());
                        

                        decision.Sum(x, y);
                        break;

                case 2:
                    
                        Console.WriteLine("Введите x: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        
                        Console.WriteLine("Введите y: ");
                        y = Convert.ToInt32(Console.ReadLine());
                        

                        decision.Sub(x, y);
                        break;
                case 3:
                    
                        Console.WriteLine("Введите x: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        
                        Console.WriteLine("Введите y: ");
                        y = Convert.ToInt32(Console.ReadLine());
                        

                        decision.Mul(x, y);
                        break;
                case 4:
                    
                        Console.WriteLine("Введите x: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        
                        Console.WriteLine("Введите y: ");
                        y = Convert.ToInt32(Console.ReadLine());
                        

                        decision.Div(x, y);
                        break;
                case 5:
                    
                        Console.WriteLine("Введите x: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        

                        decision.Pow(x);
                        break;

                case 6:
                    
                        Console.WriteLine("Введите x: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        

                        decision.Kor(x);
                        break;


                default:
                    
                        Console.WriteLine("Ошибка!");
                        Console.ReadKey();
                        break;
            }
            Console.ReadKey();
        }
    }
}
