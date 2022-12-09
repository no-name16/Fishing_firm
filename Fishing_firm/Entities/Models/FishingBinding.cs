using Fishing_firm.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_firm.Entities.Models
{
    public class FishingBinding : Fishing
    {
        public float Weight { get; set; } 
        public FishingFirmContext db;
        public RepositoryManager repo;
        public FishingBinding()
        {
            db = new FishingFirmContext();
            repo = new RepositoryManager(db);
        }
        public IEnumerable<FishingBinding> GetAllFishingBindings(bool trackChanges)
        {

            List<Fishing> fishingList = new List<Fishing>();
            fishingList = repo.Fishing.GetAllFishings(trackChanges).ToList();

            List<FishingBinding> fishingBindingList = new List<FishingBinding>();
            foreach (Fishing element in fishingList)
            {
                FishingBinding fishingBinding = new FishingBinding();
                fishingBinding.Id = element.Id;
                fishingBinding.StartTime = element.StartTime;
                fishingBinding.EndTime = element.EndTime;
                fishingBinding.TeamId = element.TeamId;
                fishingBinding.Team = element.Team;
                fishingBinding.CaterId = element.CaterId;
                fishingBinding.Cater = element.Cater;
                fishingBinding.Fish = element.Fish;
                    var fish = repo.Fish.GetFishByFishing(fishingBinding.Id, true);
                    float sum = 0;
                    foreach (var f in fish)
                    {
                        sum += f.Weight;
                    }
                    fishingBinding.Weight = sum;

                fishingBindingList.Add(fishingBinding);
            }
            return fishingBindingList.ToList();
        }
    }
}
