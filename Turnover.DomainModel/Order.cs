using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnover.DomainModel
{
    public class Order
    {

        private Dictionary<Guid, Quantity> orderLines;  

        public Order()
        {
            orderLines = new Dictionary<Guid, Quantity>();
        }

        public void ChangeProductQuantity(Guid productId, Quantity quantity)
        {

        }

        public void Delete()
        {
            
        }
    }
}
