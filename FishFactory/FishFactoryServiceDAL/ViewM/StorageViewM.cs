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
    public class StorageViewM
    {
        [DataMember]
        public int Id { get; set; }
        [DisplayName("Название склада")]
        [DataMember]
        public string StorageName { get; set; }
        [DataMember]
        public List<StorageFishViewM> StorageFishes { get; set; }
    }
}
