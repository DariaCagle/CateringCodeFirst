using AutoMapper;
using Catering.Domain.Models;
using Catering.Domain.Services;
using Catering.Models.PostModels;
using Catering.Models.ViewModels;
using System.Collections.Generic;

namespace Catering.Controllers
{
    public class UsersController
    {
        private readonly UserService _userService;
        private readonly IMapper _mapper;

        public UsersController()
        {
            _userService = new UserService();

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

        public UserViewModel CreateUser(UserPostModel model)
        {

            var user = _mapper.Map<UserModel>(model);

            var addedUser = _userService.CreateUser(user);

            return _mapper.Map<UserViewModel>(addedUser);

        }

        public IEnumerable<UserViewModel> GetAll()
        {
            var models = _userService.GetAll();
            return _mapper.Map<IEnumerable<UserViewModel>>(models);
        }

        public bool DeleteUser(int id)
        {
            return _userService.DeleteUser(id);
        }

        public UserViewModel UpdateUser(UserPostModel model)
        {
            var user = _mapper.Map<UserModel>(model);

            var updatedUser = _userService.UpdateUser(user);

            return _mapper.Map<UserViewModel>(updatedUser);
        }

        public UserViewModel GetById(int id)
        {
            var model = _userService.GetById(id);

            return _mapper.Map<UserViewModel>(model);
        }
    }
}
