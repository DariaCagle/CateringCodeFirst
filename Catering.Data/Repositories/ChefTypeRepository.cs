using Catering.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace Catering.Data.Repositories
{
    public class ChefTypeRepository
    {
        private readonly CateringContext _ctx;

        public ChefTypeRepository()
        {
            _ctx = new CateringContext();
        }
        public ChefType Create(ChefType model)
        {

            _ctx.ChefTypes.Add(model);

            _ctx.SaveChanges();

            return model;
        }

        public ChefType GetById(int id)
        {
            return _ctx.ChefTypes.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<ChefType> GetAll()
        {
            return _ctx.ChefTypes.ToList();
        }

        public ChefType Update(ChefType model)
        {
            var entity = _ctx.ChefTypes.FirstOrDefault(x => x.Id == model.Id);

            entity.Name = model.Name;

            _ctx.SaveChanges();

            return model;
        }

        public bool Delete(int id)
        {
            try
            {
                var entity = _ctx.ChefTypes.FirstOrDefault(x => x.Id == id);

                _ctx.ChefTypes.Remove(entity);

                _ctx.SaveChanges();

                return true;
            }
            catch { return false; }
        }
    }
}
