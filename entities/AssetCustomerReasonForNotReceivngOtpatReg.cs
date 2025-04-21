using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityProject.entities
{

    [Table("asset_capital_insurance_customerissues")]
    public class AssetCustomerReasonForNotReceivngOtpatReg
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public long id { get; set; }
        public string bvn {  get; set; }
        public string requestreference { get; set; }
        public string reason { get; set; }
        public string user_type { get; set; }
        public DateTime? createdon { get; set; }
    }
}
