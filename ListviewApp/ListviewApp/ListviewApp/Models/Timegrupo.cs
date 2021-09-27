using System;
using System.Collections.Generic;
using System.Text;

namespace ListviewApp.Models
{
    public class Timegrupo: List<Time>
    {
        public string Nome
        {
            set;
            get;
        }

        public string criterioGrupo
        {
            set;
            get;
        }

        public Timegrupo(string nome, string criteriogrupo)
        {
            Nome = nome;
            criterioGrupo = criteriogrupo;
        }
    }
}
