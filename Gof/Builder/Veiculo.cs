using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class Veiculo
    {
        public string Modelo { get; protected set; }
        public string Motor { get; protected set; }
        public string Categoria { get; protected set; }

        public abstract void DefinirModelo(string modelo);
        public abstract void DefinirMotor(string motor);
        public abstract void DefinirCategoria(string categoria);
        public abstract void Exibir();
    }
}
