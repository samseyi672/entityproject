using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityProject.entities
{

    [Table("paymentnotificationoutsideofflutterwave")]
    public class PaymentNotificationOutsideOfFlutterwave
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public long id { get; set; }
        public string UserType { set; get; }

        public string BankName { set; get; }

        public string Session { set; get; }

        public string PaymentReference { set; get; }

        public string UserName { set; get; }

        public decimal Amount { set; get; }

        public string AccountNumber { set; get; }
    }
}
