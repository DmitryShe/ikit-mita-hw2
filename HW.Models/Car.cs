using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW.Models
{
    public enum Categories { A, B, C, D, E, F };

    public class Car
    {
        public Car(string model, Categories category)
        {
            if (category == Categories.A)
                throw new Exception("Машина - это не мотоцикл, категория А - невозможна");

            Model = model;
            Category = category;
            CarPassport = new CarPassport(this);
        }

        public Categories Category { get; }
        public CarPassport CarPassport { get; }
        public string Model { get; }

        public Color Color { get; set; } = Color.Blue;
        public string CarNumber { get; private set; }
        


        public void ChangeOwner(string carNumber, Driver driver)
        {
            driver.OwnCar(this);

            CarNumber = carNumber;
            
            CarPassport.Owner = driver;
        }
    }
}
