using System;

namespace practica_06
{
    class practica_06
    {
        static void Main(string[] args)
        {

            //ejercicio 1
            Console.WriteLine("| EJERCICIO 1 |");
            Persona ClasePersona = new Persona();
            Profesor ClaseProfesor = new Profesor();

            ClasePersona.MostrarDatos();
            ClaseProfesor.MostrarSueldo();

            //ejercicio 2
            Console.WriteLine("| EJERCICIO 2 |");
            Contacto ClaseContacto = new Contacto();
            ClaseContacto.Saludar();
            ClaseContacto.SetContacto();
            //en la clase ProbarContacto está la otra parte del ejercicio 2.

            //ejercicio 3
            Console.WriteLine("| EJERCICIO 3 |");

            //objeto de la Clase C, la cual hereda los constructores de la Clase A y la Clase B.
            ClaseC ConstructorClaseC = new ClaseC();
            Console.WriteLine(ConstructorClaseC.Clasea);
            Console.WriteLine(ConstructorClaseC.Claseb);
            Console.WriteLine(ConstructorClaseC.Clasec);




        }
    }
}
