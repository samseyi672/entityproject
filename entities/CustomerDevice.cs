using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityProject.entities
{

    [Table("asset_capital_insurance_customerdevice")]
    public class CustomerDevice
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("login_status")]
        public int LoginStatus { get; set; }

        [Column("username")]
        public string UserName { get; set; }

        [Column("device")]
        public string Device { get; set; }

        [Column("track_device")]
        public string TrackDevice { get; set; }

        [Column("session")]
        public string Session { get; set; }

        [Column("user_type")]
        public string UserType { get; set; }

        [Column("channelId")]
        public int ChannelId { get; set; }

        [Column("created_at")]
        public DateTime? created_at { get; set; }

        [Column("createdon")]
        public DateTime? CreatedOn { get; set; }

    }
}
