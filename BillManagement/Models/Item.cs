using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BillManagement.Models
{
    [DataContract]
    public class Item
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember(IsRequired = false)]
        public string Description { get; set; }
        [DataMember]
        public int Price { get; set; }
    }
}
