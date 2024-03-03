using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyCar
{
    public class Transaction
    {
        public int ID { get; set; }
        public CustomerCar CustomerCar { get; set; }
        public Vechile Vechile { get; set; }
        public DateTime DateTime { get; set; }
    }
}
