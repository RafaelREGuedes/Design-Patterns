using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class FiatUno : BuilderVeiculo
    {
        private Veiculo veiculo;

        public FiatUno()
        {
            this.veiculo = new Automovel();
        }

        public override void Categoria()
        {
            veiculo.DefinirCategoria("Hatch");
        }

        public override void Modelo()
        {
            veiculo.DefinirModelo("FiatUno");
        }

        public override void Motor()
        {
            veiculo.DefinirMotor("1.0");
        }

        public override Veiculo ObterVeiculo()
        {
            return veiculo;
        }
    }
}
