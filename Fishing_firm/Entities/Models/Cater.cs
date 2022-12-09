using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_firm.Entities.Models
{
    public class Cater
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public DateTime Manufacture { set; get; }
        public string Changes { set; get; }
        public int CaterTypeId { set; get; }
        public virtual CaterType CaterType { set; get; }
       public ICollection<TecReview> TecReviews { set; get; }
    }
}
