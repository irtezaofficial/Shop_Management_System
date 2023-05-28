using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management_System1.Model.Rider
{
    public class RiderController
    {
        private readonly IRiderService _riderService;
        public RiderController(IRiderService riderService)
        {
            _riderService = riderService;
        }

        public string AddRider(AddRiderRequest request)
        {
            return this._riderService.AddRider(request);
        }

        public RiderEntity GetRiderById(int riderId)
        {
            return this._riderService.GetRiderById(riderId);
        }

        public string UpdateRider(UpdateRiderRequest request)
        {
            return this._riderService.UpdateRider(request);
        }

        public string DeleteRider(int riderId)
        {
            return this._riderService.DeleteRider(riderId);
        }

        public List<RiderEntity> GetRiderList()
        {
            return this._riderService.GetAllRiders();
        }
    }
}
