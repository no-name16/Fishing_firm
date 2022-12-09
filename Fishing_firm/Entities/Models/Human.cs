using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_firm.Entities.Models
{
    public class Human
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }
    }
}
