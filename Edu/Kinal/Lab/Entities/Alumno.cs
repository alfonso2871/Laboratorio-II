using System;
using CentroEducativoLab.Edu.Kinal.Lab.Interfaces;

namespace CentroEducativoLab.Edu.Kinal.Lab.Entities
{
    public class Alumno : Persona, IOperaciones
    {
        public string Carne { get; set; }
        public int NumeroCreditos { get; set; }

        public Alumno(string uuid, string apellidos, string nombres, string email, string carne, int numeroCreditos)
        : base(uuid, apellidos, nombres, email)
        {
            this.Carne = carne;
            this.NumeroCreditos = numeroCreditos;
        }
        public override void TomarAsistencia()
        {
            Console.WriteLine($"Alumno {this.Nombres} Asistio en la fecha {DateTime.Now}");
        }

        public void ListarMisDatos(string identificacdor)
        {
            Console.WriteLine($"{this.UUID} - {this.Apellidos},{this.Nombres}-{this.NumeroCreditos}-{identificacdor}");
        }

        public bool EliminarAsignatura(string asignatura)
        {
            Console.WriteLine($"Se ha eliminado la asignatura de {this.Nombres} {this.Apellidos} Perdera la cantidad de creditos de {this.NumeroCreditos}");
            return true;
        }

    }
}