using System;

namespace practica_06
{
    class ClaseC : ClaseB
    {

        //Constructor de la ClaseB.
        public string Clasec;
        public ClaseC()
        {
            Clasec = "Hola!, esta esta es la clase C";
        }

        public void Main(string[] args)
        {

            //Objeto de la ClaseC, la cual hereda los constructores de la ClaseA y la ClaseB.
            ClaseC ConstructorClaseC = new ClaseC();
            Console.WriteLine(ConstructorClaseC.Clasea);
            Console.WriteLine(ConstructorClaseC.Claseb);
            Console.WriteLine(ConstructorClaseC.Clasec);





        }


    }

}