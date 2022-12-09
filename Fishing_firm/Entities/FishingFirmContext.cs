using Fishing_firm.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_firm.Entities
{
    public class FishingFirmContext : DbContext
    {
            public FishingFirmContext() : base("DefaultConnection")
            { }
        public DbSet<Human> Humans { get; set; }
        public DbSet<Cater> Caters { get; set; }
        public DbSet<CaterType> CaterTypes { get; set; }
        public DbSet<Fish> Fish { get; set; }
        public DbSet<Fishing> Fishing { get; set; }
        public DbSet<FishSpecies> FishSpecies { get; set; }
        public DbSet<Place> Places { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TecReview> TecReviews { get; set; }

    }
}
