using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW.Models
{   
    public class Driver
    {        
        readonly DateTime LicenceDate;
        public string Name { get; }

        public List<Categories> Category { get; set; }
        public Car Car { get; private set; }

        public Driver(string name, DateTime licenceDate, List<Categories> category)
        {
            Name = name;
            LicenceDate = licenceDate;
            Category = category;
        }

        public int Experience
        {
            get
            {               
                int exp = DateTime.Today.Year - LicenceDate.Year;
                if (LicenceDate > DateTime.Today.AddYears(-exp))
                    exp--;
                return exp;
            }
        }

        public void OwnCar(Car car)
        {
            Car = car;
            if (!Category.Contains(car.Category))
                throw new Exception ("Для управления данным транспортным средством водителю требуется соответствующая квалификация");
        }
    }
}
