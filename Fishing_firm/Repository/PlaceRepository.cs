using Fishing_firm.Entities;
using Fishing_firm.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_firm.Repository
{
    public class PlaceRepository : RepositoryBase<Place>
    {
        private readonly FishingFirmContext _context;

        public PlaceRepository(FishingFirmContext repositoryContext) : base(repositoryContext)
        {
            _context = repositoryContext;
        }
        public void CreatePlace(Place place) => Create(place);

        public void UpdatePlace(Place place) => Update(place);
        public void DeletePlace(Place place) => Delete(place);

        public IEnumerable<Place> GetAllPlaces(bool trackChanges) =>
            FindAll(trackChanges)
            .OrderBy(x => x.Id)
            .ToList();

        public Place GetPlace(int id, bool trackChanges) =>
            FindByCondition(c => c.Id.Equals(id), trackChanges)
            .FirstOrDefault();
    }
}
