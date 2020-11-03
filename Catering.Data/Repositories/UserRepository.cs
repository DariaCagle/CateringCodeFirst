using Catering.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace Catering.Data.Repositories
{
    public class UserRepository
    {
        private readonly CateringContext _ctx;

        public UserRepository()
        {
            _ctx = new CateringContext();
        }
        public User Create(User model)
        {

            _ctx.Users.Add(model);

            _ctx.SaveChanges();

            return model;
        }

        public User GetById(int id)
        {
            return _ctx.Users.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<User> GetAll()
        {
            return _ctx.Users.ToList();
        }

        public User Update(User model)
        {
            var entity = _ctx.Users.FirstOrDefault(x => x.Id == model.Id);

            entity.FullName = model.FullName;
            entity.Phone = model.Phone;

            _ctx.SaveChanges();

            return model;
        }

        public bool Delete(int id)
        {
            try
            {
                var entity = _ctx.Users.FirstOrDefault(x => x.Id == id);

                _ctx.Users.Remove(entity);

                _ctx.SaveChanges();

                return true;
            }
            catch { return false; }
        }
    }
}
