using AutoMapper;
using Catering.Domain.Models;
using Catering.Domain.Services;
using Catering.Models.PostModels;
using Catering.Models.ViewModels;
using System.Collections.Generic;

namespace Catering.Controllers
{
    public class WaitersController
    {
        private readonly WaiterService _waiterService;
        private readonly IMapper _mapper;

        public WaitersController()
        {
            _waiterService = new WaiterService();

            var mapperConfig = new MapperConfiguration(cfg =>
            {
                var map = cfg.CreateMap<UserPostModel, UserModel>();
                cfg.CreateMap<ChefTypePostModel, ChefTypeModel>();
                cfg.CreateMap<CateringOrderPostModel, CateringOrderModel>();
                cfg.CreateMap<UserModel, UserViewModel>();
                cfg.CreateMap<ChefTypeModel, ChefTypeViewModel>();
                cfg.CreateMap<CateringOrderModel, CateringOrderViewModel>();
                cfg.CreateMap<WaiterModel, WaiterViewModel>();
                cfg.CreateMap<WaiterPostModel, WaiterModel>();
            });
            _mapper = new Mapper(mapperConfig);

        }

        public WaiterViewModel CreateWaiter(WaiterPostModel model)
        {

            var waiter = _mapper.Map<WaiterModel>(model);

            var addedWaiter = _waiterService.CreateWaiter(waiter);

            return _mapper.Map<WaiterViewModel>(addedWaiter);

        }

        public IEnumerable<WaiterViewModel> GetAll()
        {
            var models = _waiterService.GetAll();
            return _mapper.Map<IEnumerable<WaiterViewModel>>(models);
        }

        public bool DeleteWaiter(int id)
        {
            return _waiterService.DeleteWaiter(id);
        }

        public WaiterViewModel UpdateWaiter(WaiterPostModel model)
        {
            var waiter = _mapper.Map<WaiterModel>(model);

            var updatedWaiter = _waiterService.UpdateWaiter(waiter);

            return _mapper.Map<WaiterViewModel>(updatedWaiter);
        }

        public WaiterViewModel GetById(int id)
        {
            var model = _waiterService.GetById(id);

            return _mapper.Map<WaiterViewModel>(model);
        }
    }
}
