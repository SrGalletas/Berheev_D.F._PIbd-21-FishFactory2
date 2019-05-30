using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace FishFactoryServiceDAL.ViewM
{
    [DataContract]
    public class CustomerRequestsM
    {
        [DataContract]
        public string CustomerName { get; set; }
        [DataMember]
        public string DateCreate { get; set; }
        [DataMember]
        public string CannedFoodName { get; set; }
        [DataMember]
        public int Total { get; set; }
        [DataMember]
        public decimal Amount { get; set; }
        [DataMember]
        public string Status { get; set; }
    }
}
