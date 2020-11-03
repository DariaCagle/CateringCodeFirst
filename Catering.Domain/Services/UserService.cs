using AutoMapper;
using Catering.Data.Models;
using Catering.Data.Repositories;
using Catering.Domain.Models;
using System.Collections.Generic;

namespace Catering.Domain.Services
{
    public class UserService
    {
        private readonly UserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService()
        {
            _userRepository = new UserRepository();

            var mapperConfig = new MapperConfiguration(cfg =>
            {
                var map = cfg.CreateMap<UserModel, User>().ReverseMap();
                cfg.CreateMap<ChefTypeModel, ChefType>().ReverseMap();
                cfg.CreateMap<CateringOrderModel, CateringOrder>().ReverseMap();
                cfg.CreateMap<WaiterModel, Waiter>().ReverseMap();
            });
            _mapper = new Mapper(mapperConfig);

        }

        public UserModel CreateUser(UserModel model)
        {

            var user = _mapper.Map<User>(model);

            var addedUser = _userRepository.Create(user);

            return _mapper.Map<UserModel>(addedUser);

        }

        public IEnumerable<UserModel> GetAll()
        {
            var models = _userRepository.GetAll();
            return _mapper.Map<IEnumerable<UserModel>>(models);
        }

        public bool DeleteUser(int id)
        {
            return _userRepository.Delete(id);
        }

        public UserModel UpdateUser(UserModel model)
        {
            var user = _mapper.Map<User>(model);

            var updatedUser = _userRepository.Update(user);

            return _mapper.Map<UserModel>(updatedUser);
        }

        public UserModel GetById(int id)
        {
            var model = _userRepository.GetById(id);

            return _mapper.Map<UserModel>(model);
        }
    }
}
