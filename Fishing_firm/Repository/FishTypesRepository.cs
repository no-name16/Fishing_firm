using Fishing_firm.Entities;
using Fishing_firm.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_firm.Repository
{
    public class FishTypesRepository : RepositoryBase<FishSpecies>
    {
        private readonly FishingFirmContext _context;

        public FishTypesRepository(FishingFirmContext repositoryContext) : base(repositoryContext)
        {
            _context = repositoryContext;
        }
        public void CreateFishType(FishSpecies type) => Create(type);

        public void UpdateFishType(FishSpecies type) => Update(type);
        public void DeleteFishType(FishSpecies type) => Delete(type);

        public IEnumerable<FishSpecies> GetAllTypes(bool trackChanges) =>
            FindAll(trackChanges)
            .OrderBy(x => x.Id)
            .ToList();

        public FishSpecies GetType(int id, bool trackChanges) =>
            FindByCondition(c => c.Id.Equals(id), trackChanges)
            .FirstOrDefault();
    }
}