using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management_System1.Model.Rider
{
    public class AddRiderRequest
    {
        public string Name { get; set; }
        public string PhoneNo { get; set; }
    }

    public class UpdateRiderRequest : AddRiderRequest
    {
        public int RiderId { get; set; }
    }
}
