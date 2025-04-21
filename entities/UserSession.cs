using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityProject.entities
{

    [Table("asset_capital_insurance_user_session")]
    public class UserSession
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public long Id { get; set; }

        [Column("user_id")]
        public long UserId { get; set; }

        [Column("ucid")]
        public long ucid { get; set; }

        [Column("session")]
        public string Session { get; set; }

        [Column("created_on")]
        public DateTime? CreatedOn { get; set; }

        [Column("status")]
        public int Status { get; set; }

        [Column("user_type")]
        public string UserType { get; set; }

        [Column("channelId")]
        public int ChannelId { get; set; }

        [Column("last_activity")]
        public DateTime? LastActivity { get; set; }
    }
}





















































































