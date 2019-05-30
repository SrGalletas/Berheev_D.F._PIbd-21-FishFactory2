using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace FishFactoryServiceDAL.BindingM
{
    [DataContract]
    public class CannedFoodBindingM
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string CannedFoodName { get; set; }
        [DataMember]
        public decimal Cost { get; set; } //Price
        [DataMember]
        public List<TypeOfCannedBindingM> TypeOfCanneds { get; set; }
    }
}
