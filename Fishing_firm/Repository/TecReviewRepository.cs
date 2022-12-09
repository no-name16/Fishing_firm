using Fishing_firm.Entities;
using Fishing_firm.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_firm.Repository
{
    public class TecReviewRepository : RepositoryBase<TecReview>
    {
        private readonly FishingFirmContext _context;

        public TecReviewRepository(FishingFirmContext repositoryContext) : base(repositoryContext)
        {
            _context = repositoryContext;
        }

        public void CreateTecReview(TecReview tecReview) => Create(tecReview);

        public void UpdateTecReview(TecReview tecReview) => Update(tecReview);
        public void DeleteTecReview(TecReview tecReview) => Delete(tecReview);

        public IEnumerable<TecReview> GetAllTecReview(bool trackChanges) =>
            FindAll(trackChanges)
            .OrderBy(x => x.Id)
            .ToList();

        public TecReview GetTecReview(int id, bool trackChanges) =>
            FindByCondition(c => c.Id.Equals(id), trackChanges)
            .FirstOrDefault();

    }
}
