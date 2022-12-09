using Fishing_firm.Entities;
using Fishing_firm.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_firm.Repository
{
    public class HumanRepository : RepositoryBase<Human>
    {
        private readonly FishingFirmContext _context;

        public HumanRepository(FishingFirmContext repositoryContext) : base(repositoryContext)
        {
            _context = repositoryContext;
        }
        public void CreateHuman(Human human) => Create(human);

        public void UpdateHuman(Human human) => Update(human);
        public void DeleteHuman(Human human) => Delete(human);

        public IEnumerable<Human> GetAllHumans(bool trackChanges) =>
            FindAll(trackChanges)
            .OrderBy(x => x.Id)
            .ToList();

        public Human GetHumans(int id, bool trackChanges) =>
            FindByCondition(c => c.Id.Equals(id), trackChanges)
            .FirstOrDefault();

        public string GetHumanTeam(int id, bool trackChanges) =>
            FindByCondition(c=> c.Id.Equals(id), trackChanges) 
            .FirstOrDefault()
            .Team.Name;
    }
}
