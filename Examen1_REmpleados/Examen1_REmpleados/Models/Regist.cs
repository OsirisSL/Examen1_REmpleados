using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Examen1_REmpleados.Models
{
    public class Regist
    {
        [Key]
        [Display(Name = "Código")]
        public int RegistId { get; set; }

        [Required(ErrorMessage = "El apellido es obligatorio")]
        [Display(Name = "Apellido")]
        [StringLength(70,ErrorMessage = "No debe tener mas de 70 caracteres.")]
        [MinLength(3, ErrorMessage = "Debe tener mas de tres caracteres")]
        public string RegistApellido { get; set; }


        [Required(ErrorMessage = "El nombre es obligatorio")]
        [Display(Name = "Nombre")]
        [StringLength(70, ErrorMessage = "No debe tener mas de 70 caracteres.")]
        [MinLength(3, ErrorMessage = "Debe tener mas de tres caracteres")]
        public string RegistNombre { get; set; }


        [Display(Name = "Apodo")]
        public string RegistApodo { get; set; }


        [Required(ErrorMessage = "La dirección es obligatoria")]
        [Display(Name = "Dirección")]
        [StringLength(70, ErrorMessage = "No debe tener mas de 70 caracteres.")]
        [MinLength(3, ErrorMessage = "Debe tener mas de tres caracteres")]
        public string RegistDireccion { get; set; }


      
        [Display(Name = "Código Postal")]
        public int RegistCPostal { get; set; }


        [Display(Name = "Teléfono")]
        public int RegistTelefono { get; set; }


       
        [Display(Name = "Celular")]
        public int RegistCelular { get; set; }



        [Display(Name = "Fax")]
        public string RegistFax { get; set; }


       
        [Display(Name = "Email")]
        public string RegistEmail { get; set; }
        

        [Display(Name = "Observaciones")]
        public string RegistObsrvaciones { get; set; }
       

    }
}
