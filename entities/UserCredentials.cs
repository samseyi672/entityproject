using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityProject.entities
{

    [Table("asset_capital_insurance_user_credentials")]
    public class UserCredentials
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public long Id { get; set; }

        [Column("user_id")]
        public long UserId { get; set; }

        [Column("retries")]
        public int retries { get; set; }

        [Column("credential")]
        public string credential { get; set; }

        [Column("credential_type")]  // type 1 for password, type 2 for  pin
        public string credentialtype { get; set; }

        [Column("created_at")]  
        public DateTime? createdAt { get; set; }


        [Column("createdon")]
        public DateTime? CreatedOn { get; set; }

        [Column("user_type")]
        public string UserType { get; set; }

        [Column("status")]
        public bool Status { get; set; }

        [Column("temporarypin")]
        public string TemporaryPIn { get; set; } 

        [Column("ucid")]
        public int ucid { get; set; }
    }
}





































