using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaProva1
{
    internal class Caminhao : Veículo
    {
        //atributos
        private int eixos;

        public int Eixos { get => eixos; set => eixos = value; }

        //métodos
        public Caminhao() : base()
        {

        }

        public Caminhao(string _placa, int _ano, int _eixos) : base(_placa, _ano)
        {
            eixos = _eixos;
        }

        public override double alugar()
        {
            return (300 * eixos) - (2023 - ano) * 50;
        }
    }
}
