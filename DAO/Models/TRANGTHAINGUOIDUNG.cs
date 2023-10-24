namespace DAO.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TRANGTHAINGUOIDUNG")]
    public partial class TRANGTHAINGUOIDUNG
    {
        [Key]
        [StringLength(25)]
        public string MATRANGTHAI { get; set; }

        [StringLength(255)]
        public string TENTRANGTHAI { get; set; }
    }
}
