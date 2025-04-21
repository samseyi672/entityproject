using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityProject.entities
{

    [Table("asset_capital_insurance_registration")]
    public class Registration
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public long Id { get; set; }

        [Column("username")]
        public string UserName { get; set; }

        [Column("validbvn")]
        public bool ValidBvn { get; set; }

        [Column("user_type")]
        public string UserType { get; set; }

        [Column("first_name")]
        public string FirstName { get; set; }

        [Column("bvn")]
        public string Bvn { get; set; }

        [Column("nin")]
        public string Nin { get; set; }

        [Column("last_name")]
        public string LastName { get; set; }

        [Column("address")]
        public string Address { get; set; }

        [Column("email")]
        public string email { get; set; }

        [Column("phonenumber")]
        public string phoneNumber { get; set; }

        [Column("othernames")]
        public string otherNames { get; set; }

        [Column("customerId")]
        public string CustomerId { get; set; } // from finedge if exists

        [Column("AccountOpened")]
        public int AccountOpened { get; set; }

        [Column("ProfiledOpened")]
        public int ProfiledOpened { get; set; }

        [Column("RequestReference")]
        public string RequestReference { get; set; }

        [Column("birth_date")]
        public string birth_date { set; get; } //(dd/MM/yyyy)

        [Column("client_unique_ref")]
        public int client_unique_ref;

        [Column("idCountry")]
        public string idCountry { get; set; }

        [Column("idState")]
        public string idState { get; set; }

        [Column("idLga")]
        public string idLga { get; set; }

        [Column("channelid")]
        public int Channelid { get; set; }

        [Column("title")]
        public string title { get; set; }
        //M or F
        [Column("gender")]
        public string gender { get; set; }

        [Column("marital_status")]
        public string maritalStatus { get; set; }

        [Column("maiden_name")]
        public string maidenName { get; set; }

        [Column("idreligion")]
        public int idReligion { get; set; }

        [Column("occupationId")]
        public int occupationId { get; set; }

        [Column("sourceOfFund")]
        public string sourceOfFund { get; set; }

        [Column("employerCode")]
        public string employerCode { get; set; }

        [Column("created_at")]
        public DateTime? CreatedAt { get; set; }

        [Column("createdon")]
        public DateTime? CreatedOn { get; set; }

        [Column("deviceId")]
        public string DeviceId { get; set; }

        [Column("devicename")]
        public string Devicename { get; set; }

        [Column("password")]
        public string Password { get; set; }

        [Column("transpin")]
        public string transpin { get; set; }
    }
}










