using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW.Models
{   
    public class Driver
    {
        public Driver(string name, DateTime licenceDate, List<string> category)
        {
            Name = name;
            LicenceDate = licenceDate;
            Category = category;
        }

        public readonly DateTime LicenceDate;
        public readonly string Name;

        public List<string> Category { get; set; }
        public Car Car { get; private set; }



        public int Experience
        {
            get { return DateTime.Now.Year - LicenceDate.Year; }
        }

        public void OwnCar(Car car)
        {
            Car = car;
            if (!Category.Contains(car.Category))
                throw new Exception ("Для управления данным транспортным средством водителю требуется соответствующая квалификация");
        }
    }
}
