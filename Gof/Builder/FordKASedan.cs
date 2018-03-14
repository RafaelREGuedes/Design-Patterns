using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class FordKASedan : BuilderVeiculo
    {
        private Veiculo veiculo;

        public FordKASedan()
        {
            this.veiculo = new Automovel();
        }

        public override void Categoria()
        {
            this.veiculo.DefinirCategoria("Sedan");
        }

        public override void Modelo()
        {
            this.veiculo.DefinirModelo("FordKA");
        }

        public override void Motor()
        {
            this.veiculo.DefinirMotor("1.5");
        }

        public override Veiculo ObterVeiculo()
        {
            return this.veiculo;
        }
    }
}
