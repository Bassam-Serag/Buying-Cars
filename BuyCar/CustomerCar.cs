using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyCar
{
    public class CustomerCar
    {
        public enum Gender
        {
            Male,
            Female
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string SSN { get; set; }
        public Gender _Gender { get; set; }
        public virtual ICollection<Vechile> Vechiles { get; set; }

    }
}
