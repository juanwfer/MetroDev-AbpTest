using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDev.Boilerplate.Equipos {
    
    [Table("Categorias")]
    public class Categoria : FullAuditedEntity {
        public const int maxLength = 64;

        [Required]
        [Range(1,6)]
        public virtual int Numero { get; set; }

        [Required]
        [MaxLength(maxLength)]
        public virtual string Nombre { get; set; }

        public virtual ICollection<Equipo> Equipos { get; set; }
    }
}
