using System;

namespace practica_06
{
    class Profesor : Persona  //La clase Profesor está herenciada con la clase Persona.
    {

        int Sueldo = 45600;

        public void MostrarSueldo()
        {

            Console.WriteLine("Sueldo: {0}", Sueldo);

        }

    }
}