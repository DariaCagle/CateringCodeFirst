using Catering.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace Catering.Data.Repositories
{
    public class CateringOrderRepository
    {
        private readonly CateringContext _ctx;

        public CateringOrderRepository()
        {
            _ctx = new CateringContext();
        }
        public CateringOrder Create(CateringOrder model)
        {

            _ctx.CateringOrders.Add(model);

            _ctx.SaveChanges();

            return model;
        }

        public CateringOrder GetById(int id)
        {
            return _ctx.CateringOrders.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<CateringOrder> GetAll()
        {
            return _ctx.CateringOrders.ToList();
        }

        public CateringOrder Update(CateringOrder model)
        {
            var entity = _ctx.CateringOrders.FirstOrDefault(x => x.Id == model.Id);

            entity.NumberOfPeople = model.NumberOfPeople;
            entity.Outdoors = model.Outdoors;
            entity.ChefTypeId = model.ChefTypeId;
            entity.Address = model.Address;

            _ctx.SaveChanges();

            return model;
        }

        public bool Delete(int id)
        {
            try
            {
                var entity = _ctx.CateringOrders.FirstOrDefault(x => x.Id == id);

                _ctx.CateringOrders.Remove(entity);

                _ctx.SaveChanges();

                return true;
            }
            catch { return false; }
        }
    }
}
