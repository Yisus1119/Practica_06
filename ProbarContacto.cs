using System;

namespace practica_06
{
    class ProbarContacto
    {

        /*para ejecutar esta clase hay que cambiar el public por el static antes del void, 
         y en la clase  Practica_06 quitamos el static y ponemos el public, esto se hace para especificar
        que clase queremos ejecutar, solo puede haber una static. Si hay 2 o más, el programa tirará error. */
        public void Main(string[] args)
        {

            //creacion de dos objetos a partir de la clase contacto
            Contacto Objeto1 = new Contacto();
            Contacto Objeto2 = new Contacto();

            Objeto1.Saludar();
            Objeto2.SetContacto();



        }

    }

}