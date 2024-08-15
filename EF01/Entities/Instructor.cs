using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF01.Entities
{
    internal class Instructor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Address { get; set; }
        public double HourRate { get; set; }
        public Double Bonus { get; set; }
        public int Dep_Id { get; set; }
    }
}
