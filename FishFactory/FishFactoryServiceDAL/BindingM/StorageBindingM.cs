using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace FishFactoryServiceDAL.BindingM
{
    [DataContract]
    public class StorageBindingM
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string StorageName { get; set; }
    }
}
