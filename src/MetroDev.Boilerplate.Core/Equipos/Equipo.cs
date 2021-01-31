using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDev.Boilerplate.Equipos {
    
    [Table("Equipos")]
    public class Equipo : FullAuditedEntity {
        public const int maxLength = 64;

        [Required]
        [MaxLength(maxLength)]
        public virtual string Nombre { get; set; }

        [Required]
        public virtual Categoria Categoria { get; set; }

        public ICollection<Campeonato> Campeonatos { get; set; }
    }
}
