using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Montar
    {
        public void Construir(BuilderVeiculo builder) {
            builder.Categoria();
            builder.Modelo();
            builder.Motor();
        }
    }
}
