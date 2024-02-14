using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BillManagement.Models
{
    [DataContract]
    public class User
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember(IsRequired = false)]
        public string Email { get; set; }
        [DataMember]
        public string password { get; set; }
        [DataMember]
        public List<Bill> bills { get; set; }


    }
}
