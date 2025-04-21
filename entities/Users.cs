using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityProject.entities
{
    [Table("asset_capital_insurance_user")]
    public class Users
    { 
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public long id { get; set; }

        [Column("channelId")]
        public int ChannelId { get; set; }

        [Column("first_name")]
        public string FirstName { get; set; }

        [Column("last_name")]
        public string LastName { get; set; }

        [Column("username")]
        public string UserName { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("password")]
        public string Password { get; set; }

        [Column("phonenumber")]
        public string PhoneNumber { get; set; }

        [Column("picture")]
        public string ProfilePic { get; set; }

        [Column("status")]
        public int Status { get; set; } //1 for active , 2 for inactive

        [Column("bvn")]
        public string Bvn { get; set; }

        [Column("nin")]
        public string NIN { get; set; }

        [Column("address")]
        public string Address { get; set; }

        [Column("created_at")]
        public DateTime? createdAt { get; set; }

        [Column("createdon")]
        public DateTime? createdon { get; set; }

        [Column("user_type")]
        public string UserType { get; set; }

        [Column("client_unique_ref")]
        public long ClientUniqueRef { get; set; }

        [Column("customerid")]
        public string Customerid { get; set; }

    }
}
