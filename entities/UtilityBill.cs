using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityProject.entities
{
    [Table("asset_capital_insurance_utilitybill")]
    public class UtilityBill
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public long id { get; set; }
        public string UserName { get; set; }
        public string UserType { get; set; }
        public string Filepath { get; set; }
        public int inititated { get; set; }  // 0 for new entry,1 for initiated
        public bool approvalstatus { get; set; } //false for new entry, true for approved

        [Column("createdon")]
        public DateTime? CreatedOn { get; set; }
    }
}


















