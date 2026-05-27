using System;
using  Simulador_cafeteria;

class Program
{
    static void Main(string[] args)
    {
        List<Bebida> pedido = new List<Bebida>();
        pedido.Add(new BebidaCaliente("café Americano", "Grande", 90.5f, 45.00f));
        pedido.Add(new BebidaFria("Frappé de capuchino", "Mediano", 5, 60.00f));
        pedido.Add(new BebidaCaliente("Chocolate", "Mediano", 80.0f, 35.00f));
        pedido.Add(new BebidaFria("Michelada", "Grande", 8, 80.00f));
        pedido.Add(new BebidaCaliente("Arroz Con Leche", "Chico", 89.0f, 25.00f));

        float CostoTotal = 0;

        foreach (Bebida BEBIDA in pedido)
        {
            Console.WriteLine(BEBIDA.Preparar());

            if (BEBIDA is BebidaCaliente BebidaCaliente)
            {
                if(BebidaCaliente.temperatura > 88)
                {
                    Console.WriteLine("\t ADVERTENCIA ¡CUIDADO, LA BEBIDA ESTA MUY CALIENTE ! \n");
                }
            }

            // Acumulador del costo utilizando la propiedad heredada 'precio'
            CostoTotal += BEBIDA.precio;
        }

        Console.WriteLine("Total a pagar: $" + CostoTotal);
        Console.ReadKey();
    }    
}


       


    