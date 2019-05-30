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
    public class StorageFishViewM
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int StorageId { get; set; }
        [DataMember]
        public int TypeOfFishId { get; set; }
        [DisplayName("Название компонента")]
        [DataMember]
        public string TypeOfFishName { get; set; }
        [DisplayName("Количество")]
        [DataMember]
        public int Total { get; set; }
    }
}
