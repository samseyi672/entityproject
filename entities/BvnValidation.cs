using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityProject.entities
{

    [Table("asset_capital_insurance_bvn_validation")]
    public class BvnValidation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public long ID { get; set; }
        public string BVN { get; set; }
        public string PHONENUMBER { get; set; }
        public string PHONENUMBER2 { get; set; }
        public string EMAIL { get; set; }
        public string GENDER { get; set; }
        public string LgaResidence { get; set; }
        public string LgaOrigin { get; set; }
        public string MARITALSTATUS { get; set; }
        public string NATIONALITY { get; set; }
        public string RESIDENTIALADDRESS { get; set; }
        public string STATEORIGIN { get; set; }
        public string StateResidence { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DOB { get; set; }
        public string FIRSTNAME { get; set; }
        public string MIDDLENAME { get; set; }
        public string LASTNAME { get; set; }
    }
}
