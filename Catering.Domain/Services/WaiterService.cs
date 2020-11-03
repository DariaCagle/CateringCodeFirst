using AutoMapper;
using Catering.Data.Models;
using Catering.Data.Repositories;
using Catering.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catering.Domain.Services
{
    public class WaiterService
    {
        private readonly WaiterRepository _waiterRepository;
        private readonly IMapper _mapper;

        public WaiterService()
        {
            _waiterRepository = new WaiterRepository();

            var mapperConfig = new MapperConfiguration(cfg =>
            {
                var map = cfg.CreateMap<UserModel, User>().ReverseMap();
                cfg.CreateMap<ChefTypeModel, ChefType>().ReverseMap();
                cfg.CreateMap<CateringOrderModel, CateringOrder>().ReverseMap();
                cfg.CreateMap<WaiterModel, Waiter>().ReverseMap();
            });
            _mapper = new Mapper(mapperConfig);

        }

        public WaiterModel CreateWaiter(WaiterModel model)
        {

            var waiter = _mapper.Map<Waiter>(model);

            var addedWaiter = _waiterRepository.Create(waiter);

            return _mapper.Map<WaiterModel>(addedWaiter);

        }

        public IEnumerable<WaiterModel> GetAll()
        {
            var models = _waiterRepository.GetAll();
            return _mapper.Map<IEnumerable<WaiterModel>>(models);
        }

        public bool DeleteWaiter(int id)
        {
            return _waiterRepository.Delete(id);
        }

        public WaiterModel UpdateWaiter(WaiterModel model)
        {
            var waiter = _mapper.Map<Waiter>(model);

            var updatedWaiter = _waiterRepository.Update(waiter);

            return _mapper.Map<WaiterModel>(updatedWaiter);
        }

        public WaiterModel GetById(int id)
        {
            var model = _waiterRepository.GetById(id);

            return _mapper.Map<WaiterModel>(model);
        }
    }
}
