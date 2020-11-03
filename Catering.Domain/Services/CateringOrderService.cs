using AutoMapper;
using Catering.Data.Models;
using Catering.Data.Repositories;
using Catering.Domain.Models;
using System.Collections.Generic;

namespace Catering.Domain.Services
{
    public class CateringOrderService
    {
        private readonly CateringOrderRepository _cateringOrderRepository;
        private readonly IMapper _mapper;

        public CateringOrderService()
        {
            _cateringOrderRepository = new CateringOrderRepository();

            var mapperConfig = new MapperConfiguration(cfg =>
            {
                var map = cfg.CreateMap<UserModel, User>().ReverseMap();
                cfg.CreateMap<ChefTypeModel, ChefType>().ReverseMap();
                cfg.CreateMap<CateringOrderModel, CateringOrder>().ReverseMap();
                cfg.CreateMap<WaiterModel, Waiter>().ReverseMap();
            });
            _mapper = new Mapper(mapperConfig);

        }

        public CateringOrderModel CreateCateringOrder(CateringOrderModel model)
        {

            var order = _mapper.Map<CateringOrder>(model);

            var reservedOrder = _cateringOrderRepository.Create(order);

            return _mapper.Map<CateringOrderModel>(reservedOrder);

        }

        public IEnumerable<CateringOrderModel> GetAll()
        {
            var models = _cateringOrderRepository.GetAll();
            return _mapper.Map<IEnumerable<CateringOrderModel>>(models);
        }

        public bool DeleteCateringOrder(int id)
        {
            return _cateringOrderRepository.Delete(id);
        }

        public CateringOrderModel UpdateCateringOrder(CateringOrderModel model)
        {
            var order = _mapper.Map<CateringOrder>(model);

            var updatedOrder = _cateringOrderRepository.Update(order);

            return _mapper.Map<CateringOrderModel>(updatedOrder);
        }

        public CateringOrderModel GetById(int id)
        {
            var model = _cateringOrderRepository.GetById(id);

            return _mapper.Map<CateringOrderModel>(model);
        }
    }
}
