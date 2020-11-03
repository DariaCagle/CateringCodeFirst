using AutoMapper;
using Catering.Data.Models;
using Catering.Data.Repositories;
using Catering.Domain.Models;
using System.Collections.Generic;

namespace Catering.Domain.Services
{
    public class ChefTypeService
    {
        private readonly ChefTypeRepository _chefTypeRepository;
        private readonly IMapper _mapper;

        public ChefTypeService()
        {
            _chefTypeRepository = new ChefTypeRepository();

            var mapperConfig = new MapperConfiguration(cfg =>
            {
                var map = cfg.CreateMap<UserModel, User>().ReverseMap();
                cfg.CreateMap<ChefTypeModel, ChefType>().ReverseMap();
                cfg.CreateMap<CateringOrderModel, CateringOrder>().ReverseMap();
                cfg.CreateMap<WaiterModel, Waiter>().ReverseMap();
            });
            _mapper = new Mapper(mapperConfig);

        }

        public ChefTypeModel CreateChef(ChefTypeModel model)
        {

            var chef = _mapper.Map<ChefType>(model);

            var addedChef = _chefTypeRepository.Create(chef);

            return _mapper.Map<ChefTypeModel>(addedChef);

        }

        public IEnumerable<ChefTypeModel> GetAll()
        {
            var models = _chefTypeRepository.GetAll();
            return _mapper.Map<IEnumerable<ChefTypeModel>>(models);
        }

        public bool DeleteChef(int id)
        {
            return _chefTypeRepository.Delete(id);
        }

        public ChefTypeModel UpdateChef(ChefTypeModel model)
        {
            var chef = _mapper.Map<ChefType>(model);

            var updatedChef = _chefTypeRepository.Update(chef);

            return _mapper.Map<ChefTypeModel>(updatedChef);
        }

        public ChefTypeModel GetById(int id)
        {
            var model = _chefTypeRepository.GetById(id);

            return _mapper.Map<ChefTypeModel>(model);
        }
    }
}
