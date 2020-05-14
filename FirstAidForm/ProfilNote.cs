namespace FirstAidForm
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ProfilNote
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nama { get; set; }

        public int Umur { get; set; }

        [Required]
        [StringLength(100)]
        public string Penyakit { get; set; }

        [Required]
        [StringLength(100)]
        public string Alergi { get; set; }

        [Required]
        [StringLength(100)]
        public string Obat { get; set; }

        [Required]
        [StringLength(200)]
        public string Kejadian { get; set; }

        [Required]
        [StringLength(200)]
        public string Keluhan { get; set; }

        [Required]
        [StringLength(200)]
        public string Diagnosa { get; set; }

        public int Nafas { get; set; }

        public int? Nadi { get; set; }
    }
}
