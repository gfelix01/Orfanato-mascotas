using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CRUDWinFormsMVP.Models
{
    public class PetModel
    {
        // Campos
        private int id;
        private string name;
        private string type;
        private string colour;

        // Propiedades
        [DisplayName("ID Mascota")]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [DisplayName("Nombre")]
        [Required(ErrorMessage ="Nombre de mascota es requerido.")]
        [StringLength(50,MinimumLength =3, ErrorMessage ="El nombre de la mascota debe de tener entre 3 a 50 caracteres.")]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [DisplayName("Tipo")]
        [Required(ErrorMessage = "Tipo de mascota es requerido.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El tipo de la mascota debe de tener entre 3 a 50 caracteres.")]
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        [DisplayName("Color")]
        [Required(ErrorMessage = "Color de mascota es requerido.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El color de la mascota debe de tener entre 3 a 50 caracteres.")]
        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }
    }
}
