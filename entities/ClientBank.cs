using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityProject.entities
{
    [Table("asset_capital_insurance_clientbank")]
    public class ClientBank
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public long id { get; set; }
        public string UserName { get; set; }
        public string BankId { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public string UserType { get; set; }

        [Column("createdon")]
        public DateTime? CreatedOn { get; set; }
    }
}
