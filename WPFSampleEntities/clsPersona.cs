using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFSampleEntities
{
    public class clsPersona
    {
        //Atributos
        public int Id { get; set; }
        [Required]
        public String Nombre { get; set; }
        [Required]
        public String Apellidos { get; set; }
        public DateTime FechaNac { get; set; }
        public String Direccion { get; set; }
        public String Telefono { get; set; }

        //Constructores
        public clsPersona()
        {
            Id = 1;
            Nombre = "";
            Apellidos = "";
            FechaNac = new DateTime();
            Direccion = "";
            Telefono = "";
        }

        public clsPersona(int id, String nombre, String apellidos, DateTime fechaNac, String direccion, String telefono)
        {
            Id = id;
            Nombre = nombre;
            Apellidos = apellidos;
            FechaNac = fechaNac;
            Direccion = direccion;
            Telefono = telefono;
        }
    }
}
