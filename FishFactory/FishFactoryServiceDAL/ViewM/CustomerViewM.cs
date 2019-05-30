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
    public class CustomerViewM
    {
        [DataMember]
        public int Id { get; set; }
        [DisplayName("ФИО Клиента")]
        [DataMember]
        public string CustomerFIO { get; set; } //ClientFIO
    }
}
