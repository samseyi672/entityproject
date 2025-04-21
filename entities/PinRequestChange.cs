using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityProject.entities
{

    [Table("asset_capital_insurance_pinrequestchange")]
    public class PinRequestChange
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public long id { get; set; }

        [Column("createdon")]
        public DateTime? createdon { get; set; }

        [Column("user_type")]
        public string UserType { get; set; }


        [Column("request")]
        public string Comment { get; set; }

        [Column("approvalstatus")]
        public bool ApprovalStatus { get; set; } = false;

        [Column("initiated")]
        public bool initiated { get; set; } = false;

        [Column("userid")]
        public long UserId { get; set; }

    }
}

