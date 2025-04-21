using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityProject.entities
{

    [Table("asset_capital_insurance_reg_session")]
    public class RegistrationSession
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("user_id")]
        public long UserId { get; set; }

        [Column("session")]
        public string Session { get; set; }

        [Column("createdon")]
        public DateTime? CreatedOn { get; set; }

        [Column("status")]
        public int Status { get; set; }

        [Column("channelId")]
        public int ChannelId { get; set; }

        [Column("reg_id")]
        public int RegId { get; set; }

        [Column("user_type")]
        public string UserType { get; set; }
    }
}
