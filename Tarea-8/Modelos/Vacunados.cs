// Se crea la clase que va a contener las propiedades que se guardarán en la base de datos
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Linq;

namespace Tarea_8.Modelos
{
    public class Vacunados
    {
        [Key] //Aquí se le indica que el campo id será PK
        public int Id { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Fecha_nacimiento { get; set; }
        public int Vacuna_recibida { get; set; }
        public int Provincia { get; set; }
        public string Fecha_Dosis1 { get; set; }
        public string Fecha_Dosis2 { get; set; }
        public string signo_zodiaco { get; set; }
        public string Lat { get; set; }
        public string Lon { get; set; }
    }
}
