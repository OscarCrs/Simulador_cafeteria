using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_cafeteria
{
    internal class BebidaCaliente : Bebida
    {
        private float Temperatura;

        public float temperatura
        {
            get {  return Temperatura; } 
            set { Temperatura = value; }
        }

        //constructor que hereda
        public BebidaCaliente(string _nombre, string _tamaño, float _temperatura, float _precio):base(_nombre,_tamaño,_precio)
        {
            Temperatura = _temperatura;
        }

        //metodo sobreescrito(Polimorfismo)
        public override string Preparar()
        {
            return "\n Preparando un  " + Nombre + " Caliente a una temperatura de: "+Temperatura + ", tamaño : " + Tamaño ;
        } 

    }
}
