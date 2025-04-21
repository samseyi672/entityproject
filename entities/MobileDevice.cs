using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityProject.entities
{

    [Table("asset_capital_insurance_mobile_device")]
    public class MobileDevice
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int id { get; set; }

        [Column("device_token")]
        public string DeviceToken { get; set; }

        [Column("channelId")]
        public int ChannelId { get; set; }

        [Column("device")]
        public string DeviceId { get; set; }

        [Column("device_name")]
        public string DeviceName { get; set; }

        [Column("user_id")]
        public long UserId { get; set; }

        [Column("status")]
        public int Status { get; set; }

        [Column("user_type")]
        public string UserType { get; set; }

        [Column("createdon")]
        public DateTime? created_at { get; set; }

    }
}
