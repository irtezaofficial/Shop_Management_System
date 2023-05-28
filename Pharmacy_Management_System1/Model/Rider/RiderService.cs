using ShopMigrations;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management_System1.Model.Rider
{
    public class RiderService : IRiderService
    {
        private ShopDbContext _context = new ShopDbContext();
        public RiderService(ShopDbContext dbcontext) { _context = dbcontext;  }

        public string AddRider(AddRiderRequest request)
        {
            var findRider = this._context.Rider.FirstOrDefault(r => r.Name.Contains(request.Name));
            if (findRider != null)
                return "Rider Already Exists";

            var newRider = new RiderEntity
            {
                Name = request.Name,
                PhoneNo = request.PhoneNo,
            };
            this._context.Rider.Add(newRider);
            this._context.SaveChanges();
            return "Rider Added";
        }


        public RiderEntity GetRiderById(int riderId)
        {
            var findRider = this._context.Rider.FirstOrDefault(r => r.Id == riderId);
            if (findRider == null)
                return new RiderEntity();
            return findRider;
        }

        public string UpdateRider(UpdateRiderRequest request)
        {
            var findRider = this._context.Rider.FirstOrDefault(r => r.Name.Contains(request.Name) && r.DeletedOn == null);
            if (findRider == null)
                return "Rider Not Found";
            findRider.Name = request.Name;
            findRider.PhoneNo = request.PhoneNo;
            this._context.Rider.AddOrUpdate(findRider);
            this._context.SaveChanges();
            return "Rider Updated.";
        }

        public string DeleteRider(int riderId)
        {
            var findRider = this._context.Rider.FirstOrDefault(r => r.Id == riderId);
            if (findRider == null)
                return "Rider Not Found";
            findRider.DeletedOn = DateTime.Now;
            this._context.Rider.AddOrUpdate(findRider);
            this._context.SaveChanges();
            return "Rider Deleted";
        }

        public List<RiderEntity> GetAllRiders()
        {
            var riders = this._context.Rider.Where(r => r.DeletedOn == null).ToList();
            return riders;
        }
    }
}
