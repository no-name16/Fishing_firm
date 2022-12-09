using Fishing_firm.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_firm.Repository
{
    public class RepositoryManager
    {
        private readonly FishingFirmContext _repositoryContext;
        private HumanRepository _humanRepository;
        private TeamRepository _teamRepository;
        private CaterTypeRepository _caterTypeRepository;
        private CaterRepository _caterRepository;
        private PlaceRepository _placeRepository;
        private FishTypesRepository _fishTypesRepository;
        private FishRepository _fishRepository;
        private FishingRepository _fishingRepository;
        private TecReviewRepository _tecReviewRepository;
        public RepositoryManager(FishingFirmContext repository)
        {
            _repositoryContext = repository;
        }

        public HumanRepository Humans
        {
            get
            {
                if (_humanRepository == null)
                    _humanRepository = new HumanRepository(_repositoryContext);

                return _humanRepository;
            }
        }

        public CaterTypeRepository CaterTypes
        {
            get
            {
                if (_caterTypeRepository == null)
                    _caterTypeRepository = new CaterTypeRepository(_repositoryContext);

                return _caterTypeRepository;
            }
        } 

        public TeamRepository Teams
        {
            get
            {
                if (_teamRepository == null)
                    _teamRepository = new TeamRepository(_repositoryContext);

                return _teamRepository;
            }
        }

        public CaterRepository Caters
        {
            get
            {
                if (_caterRepository == null)
                    _caterRepository = new CaterRepository(_repositoryContext);

                return _caterRepository;
            }
        }

        public PlaceRepository Places
        {
            get
            {
                if (_placeRepository == null)
                    _placeRepository = new PlaceRepository(_repositoryContext);

                return _placeRepository;
            }
        }

        public FishTypesRepository FishTypes
        {
            get
            {
                if (_fishTypesRepository == null)
                    _fishTypesRepository = new FishTypesRepository(_repositoryContext);

                return _fishTypesRepository;
            }
        }

        public FishRepository Fish
        {
            get
            {
                if (_fishRepository == null)
                    _fishRepository = new FishRepository(_repositoryContext);

                return _fishRepository;
            }
        }

        public FishingRepository Fishing
        {
            get
            {
                if (_fishingRepository == null)
                    _fishingRepository = new FishingRepository(_repositoryContext);

                return _fishingRepository;
            }

        }

        public TecReviewRepository TecReview
        {
            get
            {
                if (_tecReviewRepository == null)
                    _tecReviewRepository = new TecReviewRepository(_repositoryContext);

                return _tecReviewRepository;
            }

        }
        public void Save() => _repositoryContext.SaveChanges();
    }
}

