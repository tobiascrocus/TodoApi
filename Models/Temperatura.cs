// namespace TodoApi.Models;

// public class Temperaturas
// {
//     public int Id { get; set; }
//     public decimal? Temperatura { get; set; }
// }

﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TodoApi.Models
{
    public class Temperatura
    {
        [Key]
        [Column("IdTemperatura")]
        public int IdTemperatura { get; set; }

        public float nivelTemperatura { get; set; }

        public DateTime fechaTemperatura { get; set; }

        public int IdBiodigestor { get; set; }

        // [ForeignKey("IdBiodigestor")]
        // public BiodigestorClass Biodigestor { get; set; } = null!;
    }
}