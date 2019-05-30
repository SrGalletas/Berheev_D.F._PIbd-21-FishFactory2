using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace FishFactoryServiceDAL.BindingM
{
    [DataContract]
    public class ReptBindingM
    {
        [DataMember]
        public string FileNominal { get; set; }
        [DataMember]
        public DateTime? DateFrom { get; set; }
        [DataMember]
        public DateTime? DateTo { get; set; }
    }
}
