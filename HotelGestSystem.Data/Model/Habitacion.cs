using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelGestSystem.Data.Model
{
    [Table("Habitaciones")]
    public class Habitacion
    {
        public int Id { get; set; }
        [Required]
        [StringLength(7)]
        public string Numero { get; set; }        
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

        [StringLength(25)]
        public string Nombre { get; set; }
        public int Camas { get; set; }
        [StringLength(250)]
        public string Descripcion { get; set; }
        [Column(TypeName = "decimal(12,2")]
        public decimal Precio { get; set; }
        public int CapacidadPersonas { get; set; }

    }
}
