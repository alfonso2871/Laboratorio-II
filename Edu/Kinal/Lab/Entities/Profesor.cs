using System;
using CentroEducativoLab.Edu.Kinal.Lab.Interfaces;

namespace CentroEducativoLab.Edu.Kinal.Lab.Entities
{
    public class Profesor: Persona, IOperaciones
    {
        public string CUI {get; set; }
        public string Cargo{get; set;}

        public Profesor(string uuid, string apellidos, string nombres, string email,string cui, string cargo)
        :base(uuid,apellidos,nombres,email){
            this.CUI = cui;
            this.Cargo = cargo;
        }
   
        public override void TomarAsistencia()
        {
            Console.WriteLine($"Profesor: {this.Nombres} asistio en la fecha {DateTime.Now}");
        }

        public void ListarMisDatos(string identificacdor)
        {
           Console.WriteLine($"{this.UUID} - {this.Apellidos}, {this.Nombres} - {this.Cargo} - {identificacdor}");
        }

        public bool EliminarAsignatura(string asignatura)
        {
             Console.WriteLine($"Se ha eliminado la asignatura {asignatura} del profesor {this.Nombres} {this.Apellidos}");
             return true;
        }

    }
}