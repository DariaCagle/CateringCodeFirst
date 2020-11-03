using Catering.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace Catering.Data.Repositories
{
    public class WaiterRepository
    {
        private readonly CateringContext _ctx;

        public WaiterRepository()
        {
            _ctx = new CateringContext();
        }
        public Waiter Create(Waiter model)
        {

            _ctx.Waiters.Add(model);

            _ctx.SaveChanges();

            return model;
        }

        public Waiter GetById(int id)
        {
            return _ctx.Waiters.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Waiter> GetAll()
        {
            return _ctx.Waiters.ToList();
        }

        public Waiter Update(Waiter model)
        {
            var entity = _ctx.Waiters.FirstOrDefault(x => x.Id == model.Id);

            entity.FullName = model.FullName;
            entity.Address = model.Address;

            _ctx.SaveChanges();

            return model;
        }

        public bool Delete(int id)
        {
            try
            {
                var entity = _ctx.Waiters.FirstOrDefault(x => x.Id == id);

                _ctx.Waiters.Remove(entity);

                _ctx.SaveChanges();

                return true;
            }
            catch { return false; }
        }
    }
}
