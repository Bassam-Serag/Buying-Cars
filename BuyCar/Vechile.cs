using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyCar
{
    public class Vechile
    {
        public int ID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string Color { get; set; }
        public int Seats { get; set; }
        public bool IsAvaiable { get; set; }
        public double Price { get; set; }

        [ForeignKey("CustomerCar")]
        public int? CustomerCarID { get; set; }
        public virtual CustomerCar CustomerCar { get; set; }


    }
}
