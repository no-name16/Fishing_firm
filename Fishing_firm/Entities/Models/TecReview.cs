using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_firm.Entities.Models
{
    public class TecReview
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime ReviewDate { get; set; }
        public string Results { get; set;}
        public int CaterId { set; get; }
        public Cater Cater { set; get; }
    }
}
