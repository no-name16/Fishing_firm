using Fishing_firm.Entities.Models;
using Fishing_firm.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_firm.Repository
{
    public class CaterRepository : RepositoryBase<Cater>
    {
        private readonly FishingFirmContext _context;

        public CaterRepository(FishingFirmContext repositoryContext) : base(repositoryContext)
        {
            _context = repositoryContext;
        }
        public void CreateCater(Cater cater) => Create(cater);

        public void UpdateCater(Cater cater) => Update(cater);
        public void DeleteCater(Cater cater) => Delete(cater);

        public IEnumerable<Cater> GetAllCaters(bool trackChanges) =>
            FindAll(trackChanges)
            .OrderBy(x => x.Id)
            .ToList();

        public Cater GetCater(int id, bool trackChanges) =>
            FindByCondition(c => c.Id.Equals(id), trackChanges)
            .FirstOrDefault();
    }
}