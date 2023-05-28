using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management_System1.Model.Rider
{
    public interface IRiderService
    {
        string AddRider(AddRiderRequest request);
        RiderEntity GetRiderById(int riderId);
        string UpdateRider(UpdateRiderRequest request);
        string DeleteRider(int riderId);
        List<RiderEntity> GetAllRiders();
    }
}
