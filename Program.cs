using System;
using System.Collections.Generic;
using CentroEducativoLab.Edu.Kinal.Lab.Entities;

namespace CentroEducativoLab
{
    public class Program
    {
        static List<Persona> listaGeneral = new List<Persona>();
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Alumno alumno1 =new Alumno("12345","Melendez","Alfonso","alfonso.garcia@vitalialimentos.com","car-001",1);
            Persona alumno2 =new Alumno("65432","Lopez","Jorge","Luis.garcia@vitalialimentos.com","car-002",3);
            Profesor profesor1 =new Profesor("A54545","Alvares","Juan","Jun.garcia@vitalialimentos.com","343434","Maatematicas");
            Persona profesor2 = new Profesor("Z12345","Galvez","Armando","Armando.garcia@vitalialimentos.com","car-001","Sociales");
            OperarRegistro(alumno1);
            OperarRegistro(alumno2);
            OperarRegistro(profesor1);
            OperarRegistro(profesor2);

            foreach (var persona in listaGeneral){
                RegistrarAsistecia(persona);
                VerMisDatos(persona);
            }
            QuitarAsignatura(alumno2);
            QuitarAsignatura(profesor1);

        }
        static void OperarRegistro(Persona persona){
            listaGeneral.Add(persona);
        }
        static void RegistrarAsistecia(Persona persona){
            if(persona is Profesor){
                ((Profesor)persona).TomarAsistencia();
            }
            if(persona is Alumno){
                ((Alumno)persona).TomarAsistencia();
            }
        }
        static void VerMisDatos(Persona persona){
            if(persona is Profesor){
                ((Profesor)persona).ListarMisDatos(((Profesor)persona).CUI);
            }else if(persona is Alumno){
                ((Alumno)persona).ListarMisDatos(((Alumno)persona).Carne);
            }
        }
        static void QuitarAsignatura(Persona persona){
            if (persona is Profesor){
                ((Profesor)persona).EliminarAsignatura("Matematicas");
                } else if (persona is Alumno){
                    ((Alumno)persona).EliminarAsignatura("Sociales");
                }
            }
            
        }
    }
