using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW.Models
{    
    public class Car
    {
        public Car(string model, string category)
        {
            Model = model;
            Category = category;
            CarPassport = new CarPassport(this);
        }

        public readonly string Category;
        public readonly CarPassport CarPassport;
        public readonly string Model;

        public Color Color { get; set; } = Color.Blue;
        public string CarNumber { get; private set; }
        


        public void ChangeOwner(string carNumber, Driver driver)
        {
            CarNumber = carNumber;
            driver.OwnCar(this);
            CarPassport.Owner = driver;
        }
    }
}
