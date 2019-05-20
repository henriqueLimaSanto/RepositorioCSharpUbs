using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursiva
{
    public class Diretorio
    {
        public string Pasta { get; set; }
        public string Caminho { get; set; }
        public List<Arquivos> arq = new List<Arquivos>();
    }
}
