using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_firm.Entities.Models
{
    public class Fish
    {
        public int Id { get; set; }
        public float Weight { get; set; }
        public int FishSpeciesId { get; set; }
        public FishSpecies FishSpecies { get; set; }
        public int PlaceId { get; set; }
        public Place Place { get; set; }
        public int FishingId { get; set; }
        public Fishing Fishing { set; get; }
        
    }
}
