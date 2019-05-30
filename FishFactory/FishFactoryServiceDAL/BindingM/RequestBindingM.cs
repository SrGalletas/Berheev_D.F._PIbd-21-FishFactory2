using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace FishFactoryServiceDAL.BindingM
{
    [DataContract]
    public class RequestBindingM
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int CustomerId { get; set; } //ClientId
        [DataMember]
        public int CannedFoodId { get; set; } //ProductId
        [DataMember]
        public int Total { get; set; } //Count
        [DataMember]
        public decimal Amount { get; set; } //Sum
    }
}
