using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Automovel : Veiculo
    {
        public override void DefinirCategoria(string categoria)
        {
            this.Categoria = categoria;
        }

        public override void DefinirModelo(string modelo)
        {
            this.Modelo = modelo;
        }

        public override void DefinirMotor(string motor)
        {
            this.Motor = motor;
        }

        public override string ToString()
        {
            return string.Format("Caracteristicas do veículo: Categoria:{0}, Modelo:{1}, Motor{2}", this.Categoria, this.Modelo, this.Motor);
        }

        public override void Exibir() {
            Console.WriteLine(this.ToString());
        }
    }
}
