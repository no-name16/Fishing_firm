using Fishing_firm.Entities;
using Fishing_firm.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_firm.Repository
{
    public class FishingRepository : RepositoryBase<Fishing>
    {
        private readonly FishingFirmContext _context;

        public FishingRepository(FishingFirmContext repositoryContext) : base(repositoryContext)
        {
            _context = repositoryContext;
        }
        public void CreateFishing(Fishing Fishing) => Create(Fishing);

        public void UpdateFishing(Fishing Fishing) => Update(Fishing);
        public void DeleteFishing(Fishing Fishing) => Delete(Fishing);

        public IEnumerable<Fishing> GetAllFishings(bool trackChanges)=>
           FindAll(trackChanges)
            .OrderBy(x => x.Id)
            .ToList();
        

        public Fishing GetFishing(int id, bool trackChanges) =>
            FindByCondition(c => c.Id.Equals(id), trackChanges)
            .FirstOrDefault();

    }
}
