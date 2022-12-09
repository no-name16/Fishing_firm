using Fishing_firm.Entities;
using Fishing_firm.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_firm.Repository
{
    public class CaterTypeRepository : RepositoryBase<CaterType>
    {
        private readonly FishingFirmContext _context;

        public CaterTypeRepository(FishingFirmContext repositoryContext) : base(repositoryContext)
        {
            _context = repositoryContext;
        }
        public void CreateCaterType(CaterType type) => Create(type);

        public void UpdateCaterType(CaterType type) => Update(type);
        public void DeleteCaterType(CaterType type) => Delete(type);

        public IEnumerable<CaterType> GetAllTypes(bool trackChanges) =>
            FindAll(trackChanges)
            .OrderBy(x => x.Id)
            .ToList();

        public CaterType GetType(int id, bool trackChanges) =>
            FindByCondition(c => c.Id.Equals(id), trackChanges)
            .FirstOrDefault();
    }
}
