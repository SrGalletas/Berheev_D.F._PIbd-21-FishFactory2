using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace FishFactoryServiceDAL.BindingM
{
    [DataContract]
    public class TypeOfFishBindingM
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string TypeOfFishName { get; set; } //ComponentName
    }
}
