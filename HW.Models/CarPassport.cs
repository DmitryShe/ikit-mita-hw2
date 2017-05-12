using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW.Models
{
    public class CarPassport
    {
        public CarPassport(Car car)
        {
            Car = car;
        }

        public readonly Car Car;
        public Driver Owner { get; set; }

    }
}
