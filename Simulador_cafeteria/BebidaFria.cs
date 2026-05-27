using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Simulador_cafeteria
{
    internal class BebidaFria : Bebida
    {
        private int CantidadHielo;

        public int cantidadHielo
        {
            get { return CantidadHielo; }
            set
            {
                if (value > 0)
                {
                    CantidadHielo = value;
                }
                else
                {
                    CantidadHielo = -1;
                }
                
            }
        }

        public BebidaFria(string _nombre, string _tamaño, int _cantidadHielo, float _precio) : base(_nombre, _tamaño, _precio)
        {
            CantidadHielo = _cantidadHielo;
        }

        //metodo sobreescrito(Polimorfismo)
        public override string Preparar()
        {
            return "\n Preparando un : " + Nombre + " helado con " +CantidadHielo + " cubos de hielo, tamaño : " + Tamaño;
        }
    }
}
