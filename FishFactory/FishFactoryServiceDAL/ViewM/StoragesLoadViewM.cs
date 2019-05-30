using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace FishFactoryServiceDAL.ViewM
{
    [DataContract]
    public class StoragesLoadViewM
    {
        [DataMember]
        public string StorageNominal { get; set; }
        [DataMember]
        public int TotalTotal { get; set; }
        [DataMember]
        public IEnumerable<Tuple<string, int>> TypesOfFish { get; set; }
    }
}
