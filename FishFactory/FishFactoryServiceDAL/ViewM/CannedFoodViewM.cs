using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace FishFactoryServiceDAL.ViewM
{
    [DataContract]
    public class CannedFoodViewM
    {
        [DataMember]
        public int Id { get; set; }
        [DisplayName("Название продукта")]
        [DataMember]
        public string CannedFoodName { get; set; }
        [DisplayName("Цена")]
        [DataMember]
        public decimal Cost { get; set; } //Price
        [DataMember]
        public List<TypeOfCannedViewM> TypeOfCanned { get; set; }
    }
}
