using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaProva1
{
    internal class Onibus : Veículo
    {
        //atributos
        private int assentos;

        public int Assentos { get => assentos; set => assentos = value; }

        //métodos
        public Onibus() : base()
        {

        }

        public Onibus(string _placa, int _ano, int _assentos) : base(_placa, _ano)
        {
            assentos = _assentos;
        }

        public override double alugar()
        {
            return (30 * assentos) - (2023 - ano) * 70;
        }
    }
}
