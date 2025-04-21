using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityProject.entities
{

    [Table("asset_capital_insurance_custdatanotfrombvn")]
    public class CustomerDataNotFromBvn
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("channelId")]
        public int ChannelId { get; set; }

        [Column("user_id")]
        public long UserId { get; set; }

        [Column("username")]
        public string UserName { get; set; }

        [Column("regid")]
        public int RegId { get; set; }


        [Column("phonenumber")]
        public string PhoneNumber { get; set; }

        [Column("address")]
        public string Address { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("phonenumberfrombvn")]
        public string PhoneNumberNotFromBvn { get; set; }

        [Column("user_type")]
        public string UserType { get; set; }

        [Column("created_at")]
        public DateTime? created_at { get; set; }

        [Column("createdon")]
        public DateTime? CreatedOn { get; set; }
    }
}
