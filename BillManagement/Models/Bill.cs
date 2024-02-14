using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BillManagement.Models
{
    [DataContract]
    public class Bill
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public ICollection<BilledItems> BilledItems{ get; set; }
        [DataMember]
        public int Amount { get; set; }
        [DataMember]
        public User user { get; set; }


    }
}
