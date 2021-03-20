using System;

namespace practica_06
{
    class Persona
    {

        uint cedula; //utilizamos uint para permitir datos numericos de mayor longitud.
        int edad;
        string nombre, apellido;

        public void MostrarDatos()
        {
            cedula = 4018527891;
            nombre = "Pablo Manuel";
            apellido = "Ramírez López";
            edad = 49;
            Console.WriteLine("Número de Cedula: {0}, Nombre: {1}, Apellido: {2}, Edad: {3} años", cedula, nombre, apellido, edad);
        }


    }
}