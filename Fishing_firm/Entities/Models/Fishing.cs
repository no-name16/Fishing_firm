using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_firm.Entities.Models
{
    
    public class Fishing
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int TeamId { get; set; }
        public  Team Team { get; set; }
        public int CaterId { get; set; }
        public Cater Cater { get; set; }
        public  ICollection<Fish> Fish { get; set; }
    }
}
