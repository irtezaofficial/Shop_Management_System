using Pharmacy_Management_System1.Model.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management_System1.Model.Rider
{
    public class RiderEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNo { get; set; }

        public List<OrderEntity> Orders { get; set; }
    }
}
