using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactorialLibrary;
using ReactCalc.Models;
using System.Reflection;
using System.IO;


namespace ReactCalc
{
    public class Calc
    {
        public Calc()
        {
            Operations = new List<IOperation>();
            Operations.Add(new SumOperation());

            var dllName = Directory.GetCurrentDirectory() + "/" + "FactorialLibrary.dll";

            if (!File.Exists(dllName))
            {
                return;
            }

            //загружаем сборку
            var assembly = Assembly.LoadFrom("FactorialLibrary.dll");
            //получаем все типы/классы из неё
            var types = assembly.GetTypes();
            //перебираем типы
            foreach(var t in types)
            {
                //находим тех кто реализует интерфейс IOperation
                var interfs = t.GetInterfaces();
                if(interfs.Contains(typeof(IOperation)))
                {
                    
                    //создаем экземпляр найденного класса и добавляем его в наш список операций
                    var instance = Activator.CreateInstance(t) as IOperation;
                    if(instance != null)
                    {
                        Operations.Add(instance);
                    }
                    

                }
            }
            
            

            

            Operations.Add(new FactorialOperation());


            


        }

        public IList<IOperation> Operations { get; private set; }

        public bool selector (IOperation oper, string name)
        {
            return oper.Name == "";
        }

        private double Execute(Func<IOperation, bool> selector, double[] args)
        {

        }

        private double Execute(string name, double[] args)
        {
            return Execute(i => i.Name == name, args);
        }

        public double Execute(long code, double[] args)
        {
           return Execute(i => i.Name == name, args)
        }

        private double Execute(Func<double[], double> fun, double[] args)
        {
            //находим операцию по имени
            IOperation oper = Operations.FirstOrDefault(i => i.Name == name);
           
            if (oper != null)
            {
                //вычисляем результат
                var result = oper.Execute(args);
                //отдаем пользователю
                return result;
            }

            throw new Exception("Не найдена запрашиваемая операция");

            return 0;
        }

        [Obsolete("Используйте Execute('sum' new[] {x, y}). Данная функция будет удалена в версии 4.0")]
        double res = 0;
        public double Sum(double a, double b)//Сумма
        {
            return Execute("sum", new[] { a, b });
            
        }

        public double Sub(double a, double b)//Разность
        {
            return a-b;
        }

        public double Mul(double a, double b)//Умножение
        {
            return a*b;
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
                return a / b;
            }
            
        }

        public double Pow(double a)//Возведение в квадрат
        {
            return a * a;
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
                return Math.Sqrt(a);
            }

            return 0;
        }

    }
}
