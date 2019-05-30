using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace FishFactoryServiceDAL.BindingM
{
    [DataContract]
    public class CustomerBindingM
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string CustomerFIO { get; set; } //ClientFIO
    }
}
