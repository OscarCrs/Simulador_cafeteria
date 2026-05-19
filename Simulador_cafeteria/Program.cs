using System;

namespace Simulador_cafeteria
{
    public class Bebida
    {
        // Atributos privados
        private string nombre;
        private string tamano; 
        private float precio;

        // Propiedades
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Tamano
        {
            get { return tamano; }
            set { tamano = value; }
        }

        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        //  Constructor
        public Bebida(string nombre, string tamano, float precio)
        {
            this.nombre = nombre;
            this.tamano = tamano;
            this.precio = precio;
        }

        // Método Preparar
        public void Preparar()
        {
            Console.WriteLine($"Preparando un {nombre} tamaño {tamano}...");
        }

        //Método AplicarDescuento
        public void AplicarDescuento(double porcentaje)
        {
            
            float descuento = precio * (float)(porcentaje / 100.0);
            precio = precio - descuento;
            Console.WriteLine($"\n[Sistema] Se aplicó un {porcentaje}% de descuento a la bebida: {nombre}");
        }

        //Método MostrarDescripcion
        public void MostrarDescripcion()
        {
            Console.WriteLine($"Esto es un {nombre} de tamaño {tamano} con un costo de ${precio}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           

            // Bebida 1
            Console.WriteLine("--- Registro Bebida 1 ---");
            Console.Write("Nombre de la bebida: ");
            string n1 = Console.ReadLine();
            Console.Write("Tamaño (Chico/Mediano/Grande): ");
            string t1 = Console.ReadLine();
            Console.Write("Precio: ");
            float p1 = float.Parse(Console.ReadLine());
            Bebida bebida1 = new Bebida(n1, t1, p1);

            // Bebida 2
            Console.WriteLine("\n--- Registro Bebida 2 ---");
            Console.Write("Nombre de la bebida: ");
            string n2 = Console.ReadLine();
            Console.Write("Tamaño (Chico/Mediano/Grande): ");
            string t2 = Console.ReadLine();
            Console.Write("Precio: ");
            float p2 = float.Parse(Console.ReadLine());
            Bebida bebida2 = new Bebida(n2, t2, p2);

            // Bebida 3
            Console.WriteLine("\n--- Registro Bebida 3 ---");
            Console.Write("Nombre de la bebida: ");
            string n3 = Console.ReadLine();
            Console.Write("Tamaño (Chico/Mediano/Grande): ");
            string t3 = Console.ReadLine();
            Console.Write("Precio: ");
            float p3 = float.Parse(Console.ReadLine());
            Bebida bebida3 = new Bebida(n3, t3, p3);

            Console.WriteLine();

            
            // Elegimos aplicar un descuento del 15% a la primera bebida
            bebida1.AplicarDescuento(15);
            Console.WriteLine();

            // --- LLAMAR AL MÉTODO PREPARAR DE TODAS ---
            bebida1.Preparar();
            Console.WriteLine(); 

            bebida2.Preparar();
            Console.WriteLine();

            bebida3.Preparar();
            Console.WriteLine();

            // --- MOSTRAR LA DESCRIPCIÓN DE CADA BEBIDA ---
            bebida1.MostrarDescripcion();
            Console.WriteLine();

            bebida2.MostrarDescripcion();
            Console.WriteLine();

            bebida3.MostrarDescripcion();

            // Evitar que la consola se cierre de golpe
            Console.ReadLine();
        }
    }
}
