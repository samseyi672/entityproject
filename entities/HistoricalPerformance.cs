using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityProject.entities
{
    [Table("portfolio_historicalperformance")]
    public class HistoricalPerformance
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("portfolio_id")]
        public int PortfolioId { get; set; }


        [Column("productby")]
        public string ProductBy { set; get; }

        [Column("year")]
        public string Year { set; get; }

        [Column("yield")]
        public string yield { set; get; }

        [Column("createdon")]
        public DateTime? CreatedOn { set; get; }

        [Column("updatedon")]
        public DateTime? UpdatedOn { set; get; }

    }
}
