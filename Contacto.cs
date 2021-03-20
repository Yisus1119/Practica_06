using System;

namespace practica_06
{
    class Contacto
    {
        //atributos con sus propiedades sin cambiar.
        string nombre = "Liriano Gómez";
        string apellidos = "Martínez Jímenez";

        string direccion = "Calle Juanita No. 27, guachupita. Santo Domingo, R.D";
        long telefono = 8094567890;

        //metodo para cambiar todos los atributos usando el parametro con la palabra clave this
        public void SetContacto()
        {
            this.nombre = "Pedro Henríquez";
            this.apellidos = "Matias Vasquez";
            this.telefono = 8291234567;
            this.direccion = "Aut. San Isidro, Res. La Moneda. Edificio 2, apartamento 1A. Santo Domingo Este. R.D";

            Console.WriteLine("{0} {1} mi número de teléfono es: {2} y resido en {3} ", nombre, apellidos, telefono, direccion);

        }

        public void Saludar()
        {
            Console.Write("Hola soy ");

        }



    }
}