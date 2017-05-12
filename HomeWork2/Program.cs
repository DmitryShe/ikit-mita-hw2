using HW.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {           
            var Lada = new Car("Лада", "D");
            Lada.Color = Color.Violet;
            Console.WriteLine("Покупаем машину: {0}", Lada.Model);

            try
            {
                Console.WriteLine("Владелец Машины: {0}", Lada.CarPassport.Owner.Name);               
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Владелец Машины: отсутствует");
            }


            
            var driver = new Driver("Вольдемар", new DateTime(1996, 6, 6), new List<string> { "B", "C" } );
            Console.WriteLine("\nПринимаем на работу инструктора Вольдемара");

            try
            {
                Lada.ChangeOwner("o777oo", driver);
            }
            catch (Exception e)
            {
                Console.WriteLine("\nНе удалось назначить инструктора на машину: " + e.Message);
            }

            
            driver.Category.Add("D");
            Console.WriteLine("\nИнструктор Вольдемар приобретает категорию D");

            try
            {
                Lada.ChangeOwner("o777oo", driver);              
            }
            catch (Exception e)
            {
                Console.WriteLine("\nНе удалось назначить инструктора на машину: " + e.Message);
            }

            Console.WriteLine("\nНомер Лады Вольдемара: " + driver.Car.CarNumber);
            Console.WriteLine("Владелец Лады: " + Lada.CarPassport.Owner.Name);
           
        }
    }
}
