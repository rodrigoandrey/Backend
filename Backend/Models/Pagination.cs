using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
 
    public class Pagination
    {
        public Paginacao paginacao { get; set; }

        public int filtroId { get; set; }

        public int filtroNome { get; set; }
    }

    public class Paginacao
    {
        public int paginaAtual { get; set; }

        public int itemsPorPagina { get; set; }
    }
}

