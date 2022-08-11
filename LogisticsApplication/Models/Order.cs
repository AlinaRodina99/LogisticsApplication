using System.ComponentModel.DataAnnotations;

namespace LogisticsApplication.Models
{
    public class Order
    {
        [Display(Name = "Идентификатор")]
        public int Id { get; set; }

        [Display(Name = "Город отправителя")]
        public string SenderCity { get; set; }

        [Display(Name = "Адрес отправителя")]
        public string SenderAddress { get; set; }

        [Display(Name = "Город получателя")]
        public string ReceiverCity { get; set; }

        [Display(Name = "Адрес получателя")]
        public string ReceiverAddress { get; set; }

        [Display(Name = "Вес груза")]
        public double CargoWeight { get; set; }

        [Display(Name = "Город отправителя")]
        [DataType(DataType.Date)]
        public DateTime CargoPickUpDate { get; set; }
    }
}
