using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace AdministradorWeb.Models
{
    public enum Horario
    {
        LunMieVier = 0,
        MarJue = 1,
    }
    public class Doctores
    {

        [Key]
        public int DoctorID { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 5, ErrorMessage = "Por favor ingrese entre 5 a 60 caracteres")]
        
        [Display(Name = "Nombre del Doctor(a) ")]
        public string Name { get; set; }
        [Required]
        
        [Display(Name = "Horario")]
        public Horario Dias { get; set; }
        
        [Display(Name = "Especialidad ")]
        public string Especialidad { get; set; }

    }
}
