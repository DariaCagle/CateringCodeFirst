using AutoMapper;
using Catering.Domain.Models;
using Catering.Domain.Services;
using Catering.Models.PostModels;
using Catering.Models.ViewModels;
using System.Collections.Generic;

namespace Catering.Controllers
{
    public class ChefTypesController
    {
        private readonly ChefTypeService _chefTypeService;
        private readonly IMapper _mapper;

        public ChefTypesController()
        {
            _chefTypeService = new ChefTypeService();

            var mapperConfig = new MapperConfiguration(cfg =>
            {
                var map = cfg.CreateMap<UserPostModel, UserModel>();
                cfg.CreateMap<ChefTypePostModel, ChefTypeModel>();
                cfg.CreateMap<CateringOrderPostModel, CateringOrderModel>();
                cfg.CreateMap<UserModel, UserViewModel>();
                cfg.CreateMap<ChefTypeModel, ChefTypeViewModel>();
                cfg.CreateMap<CateringOrderModel, CateringOrderViewModel>();
            });
            _mapper = new Mapper(mapperConfig);

        }

        public ChefTypeViewModel CreateChef(ChefTypePostModel model)
        {

            var chef = _mapper.Map<ChefTypeModel>(model);

            var addedChef = _chefTypeService.CreateChef(chef);

            return _mapper.Map<ChefTypeViewModel>(addedChef);

        }

        public IEnumerable<ChefTypeViewModel> GetAll()
        {
            var models = _chefTypeService.GetAll();
            return _mapper.Map<IEnumerable<ChefTypeViewModel>>(models);
        }

        public bool DeleteChef(int id)
        {
            return _chefTypeService.DeleteChef(id);
        }

        public ChefTypeViewModel UpdateChef(ChefTypePostModel model)
        {
            var chef = _mapper.Map<ChefTypeModel>(model);

            var updatedChef = _chefTypeService.UpdateChef(chef);

            return _mapper.Map<ChefTypeViewModel>(updatedChef);
        }

        public ChefTypeViewModel GetById(int id)
        {
            var model = _chefTypeService.GetById(id);

            return _mapper.Map<ChefTypeViewModel>(model);
        }
    }
}
