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
    public class RequestViewM
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int CustomerId { get; set; }
        [DataMember]
        [DisplayName("ФИО Клиента")]
        public string CustomerFIO { get; set; }

        [DataMember]
        public int CannedFoodId { get; set; }
        [DisplayName("Продукт")]
        [DataMember]
        public string CannedFoodName { get; set; }
        [DisplayName("Количество")]
        [DataMember]
        public int Total { get; set; }
        [DisplayName("Сумма")]
        [DataMember]
        public decimal Amount { get; set; }
        [DisplayName("Статус")]
        [DataMember]
        public string Status { get; set; }
        [DisplayName("Дата создания")]
        [DataMember]
        public string DateCreate { get; set; }
        [DisplayName("Дата выполнения")]
        [DataMember]
        public string DateImplement { get; set; }
    }
}
