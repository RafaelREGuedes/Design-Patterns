using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class BuilderVeiculo
    {
        public abstract void Modelo();
        public abstract void Motor();
        public abstract void Categoria();
        public abstract Veiculo ObterVeiculo();
    }
}
