using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos
{
    // abstract: não sei como vai funcionar o processo, quem honrar esse método que vai aplicar de forma exata. Funciona com a Heranca
    // método que a classe pai não sabe como vai ser implementada a ação, essa função vai para as classes filhas
    // abstract mantém a função permanentemente; virtual da a ação mas permite mudanças
    public abstract class Executor
    {
        public abstract void Executar();
    }
}
