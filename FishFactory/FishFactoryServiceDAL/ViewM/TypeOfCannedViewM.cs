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
    public class TypeOfCannedViewM
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int CannedFoodId { get; set; } //ProductId
        [DataMember]
        public int TypeOfFishId { get; set; } //ComponentId
        [DisplayName("Количество")]
        [DataMember]
        public int Total { get; set; } //Count
        [DisplayName("Компонент")]
        [DataMember]
        public string TypeOfFishName { get; set; }
    }
}
