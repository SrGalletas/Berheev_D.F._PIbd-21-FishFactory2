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
    public class TypeOfFishViewM
    {
        [DataMember]
        public int Id { get; set; }
        [DisplayName("Название компонента")]
        [DataMember]
        public string TypeOfFishName { get; set; } //ComponentName
    }
}
