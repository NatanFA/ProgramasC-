using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaProva1
{
    internal class Veículo
    {
        //atributos
        protected string placa;
        protected int ano;

        public string Placa { get => placa; set => placa = value; }
        public int Ano { get => ano; set => ano = value; }

        //metodos

        public Veículo()
        {

        }

        public Veículo(string _placa, int _ano)
        {
            placa = _placa;
            ano = _ano;
        }
        public virtual double alugar()
        {
            return 0.0;
        }
    }
}
