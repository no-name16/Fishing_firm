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
    public class TeamRepository : RepositoryBase<Team>
    {
        private readonly FishingFirmContext _context;

        public TeamRepository(FishingFirmContext repositoryContext) : base(repositoryContext)
        {
            _context = repositoryContext;
        }

        public void CreateTeam(Team team) => Create(team);

        public void UpdateTeam(Team team) => Update(team);
        public void DeleteTeam(Team team) => Delete(team);

        public IEnumerable<Team> GetAllTeams(bool trackChanges) =>
            FindAll(trackChanges)
            .OrderBy(x => x.Id)
            .ToList();

        public Team GetTeams(int id, bool trackChanges) =>
            FindByCondition(c => c.Id.Equals(id), trackChanges)
            .FirstOrDefault();

        public Team GetTeamByName(string name, bool trackChanges) =>
            FindByCondition(c => c.Name.Equals(name), trackChanges)
            .FirstOrDefault();
    }
}
