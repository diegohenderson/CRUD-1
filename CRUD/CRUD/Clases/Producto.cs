using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Clases
{
    public class Producto
    {
        [Key]
        public int ID { get; set; }
        [StringLength(255)]
        public string Nombre { get; set; }
        
        public Decimal Stock { get; set; }
        
        public Decimal Precio { get; set; }
        
        public string Descripcion { get; set; }
        
        public string ImageUrl { get; set; }
    }
}
