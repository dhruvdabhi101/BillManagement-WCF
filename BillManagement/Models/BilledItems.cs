using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BillManagement.Models
{
    [DataContract]
    public class BilledItems
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public Item Item { get; set; }
        [DataMember]
        public int Quantity { get; set; }
    }
}
