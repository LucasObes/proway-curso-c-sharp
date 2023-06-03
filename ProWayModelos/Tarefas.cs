using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProWayModelos
{
    public class Tarefas
    {
        public int codigo { get; set; }
        public string nomeResponsavel { get; set; }
        public string tarefa { get; set; }
        public string descricao { get; set; }
        public DateTime data { get; set; }
        public TarefaNivel nivel { get; set; }

    }

    public enum TarefaNivel
    {
         Baixa, Media, Alta, Urgente
    }
}
