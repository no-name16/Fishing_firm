using Fishing_firm.Entities.Models;
using Fishing_firm.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_firm.Repository
{
    public class FishRepository : RepositoryBase<Fish>
    {
        private readonly FishingFirmContext _context;

        public FishRepository(FishingFirmContext repositoryContext) : base(repositoryContext)
        {
            _context = repositoryContext;
        }
        public void CreateFish(Fish fish) => Create(fish);

        public void UpdateFish(Fish fish) => Update(fish);
        public void DeleteFish(Fish fish) => Delete(fish);

        public IEnumerable<Fish> GetAllFish(bool trackChanges) =>
            FindAll(trackChanges)
            .OrderBy(x => x.Id)
            .ToList();

        public Fish GetFish(int id, bool trackChanges) =>
            FindByCondition(c => c.Id.Equals(id), trackChanges)
            .FirstOrDefault();

        public IEnumerable<Fish> GetFishByFishing(int fishingId, bool TrackChanges) =>
            FindByCondition(c => c.FishingId.Equals(fishingId), TrackChanges)
            .ToList();
    }
}