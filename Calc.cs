using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ReactCalc
{
    class Calc
    {
        double res = 0;
        public double Sum(double a, double b)//Сумма
        {
            res = a + b;
            Console.Write("Ответ: " + res);
            
            return 0;
        }

        public double Sub(double a, double b)//Разность
        {
            res = a - b;
            Console.Write("Ответ: " + res);
            
            return 0;
        }

        public double Mul(double a, double b)//Умножение
        {
            res = a * b;
            Console.Write("Ответ: " + res);
            
            return 0;
        }

        public double Div(double a, double b)//Деление
        {
            if (b == 0)
            {
                Console.Write("Ошибка: Деление на ноль!");
                return 0;
            }
            else
            {
                res = a / b;
                Console.Write("Ответ: " + res);
                
                return 0;
            }
            
        }

        public double Pow(double a)//Возведение в квадрат
        {
            Console.Write("Ответ: " + res);
            res = a * a;
            return res;
        }

        public double Kor(double a)//Корень
        {
            if (a <= 0)
            {
                Console.WriteLine("Ошибка!");
                return 0;
            }
            else
            {
                res = Math.Sqrt(a);
                Console.Write("Ответ: " + res);
            }

            return 0;
        }

    }
}
