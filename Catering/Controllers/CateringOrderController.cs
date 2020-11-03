using AutoMapper;
using Catering.Domain.Models;
using Catering.Domain.Services;
using Catering.Models.PostModels;
using Catering.Models.ViewModels;
using System.Collections.Generic;

namespace Catering.Controllers
{
    public class CateringOrderController
    {
        private readonly CateringOrderService _cateringOrderService;
        private readonly IMapper _mapper;

        public CateringOrderController()
        {
            _cateringOrderService = new CateringOrderService();

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

        public CateringOrderViewModel CreateCateringOrder(CateringOrderPostModel model)
        {

            var order = _mapper.Map<CateringOrderModel>(model);

            var reservedOrder = _cateringOrderService.CreateCateringOrder(order);

            return _mapper.Map<CateringOrderViewModel>(reservedOrder);

        }

        public IEnumerable<CateringOrderViewModel> GetAll()
        {
            var models = _cateringOrderService.GetAll();
            return _mapper.Map<IEnumerable<CateringOrderViewModel>>(models);
        }

        public bool DeleteCateringOrder(int id)
        {
            return _cateringOrderService.DeleteCateringOrder(id);
        }

        public CateringOrderViewModel UpdateCateringOrder(CateringOrderPostModel model)
        {
            var order = _mapper.Map<CateringOrderModel>(model);

            var updatedOrder = _cateringOrderService.UpdateCateringOrder(order);

            return _mapper.Map<CateringOrderViewModel>(updatedOrder);
        }

        public CateringOrderViewModel GetById(int id)
        {
            var model = _cateringOrderService.GetById(id);

            return _mapper.Map<CateringOrderViewModel>(model);
        }
    }
}
