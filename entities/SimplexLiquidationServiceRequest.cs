using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityProject.entities
{
    [Table("asset_mutualfundliquidation")]
    public class SimplexLiquidationServiceRequest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int id { get; set; }
        public string UserType { set; get; }
        public decimal Amount { set; get; }
        public string UserName { set; get; }
        public string RedemptionAccount { set; get; }
        public bool PartialOrFull { set; get; }
        public string BankName { set; get; }
        public string InvestmentId { set; get; }
        public DateTime? CreatedAt { set; get; }
    }
}
















































































