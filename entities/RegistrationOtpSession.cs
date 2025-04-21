using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityProject.entities
{

    [Table("asset_capital_insurance_registration_otp_session")]
    public class RegistrationOtpSession
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("created_at")]
        public DateTime? createdAt { get; set; }

        [Column("createdon")]
        public DateTime? CreatedOn { get; set; }

        [Column("user_type")]
        public string UserType { get; set; }

        [Column("session")]
        public string Session { get; set; }

        [Column("otp")]
        public string Otp { get; set; }

        [Column("otp_type")]
        public int OtpType { get; set; }

        [Column("status")]
        public int status { get; set; }

        [Column("bvn")]
        public string bvn { get; set; }
    }
}
