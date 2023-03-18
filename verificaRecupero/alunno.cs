using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verificaRecupero
{
    internal class alunno
    {
        public string nome { get; set; }
        public string cognome { get; set; }
        public int età { get; set; }
        public string cittàResidenza { get; set; }

        public alunno(string nome, string cognome, int età, string cittàResidenza)
        {
            nome = nome;
            cognome = cognome;
            età = età;
            cittàResidenza = cittàResidenza;
        }
        public string ToString()
        {
            return nome + cognome + età + cittàResidenza;
        }
        
        public string classi()
        {
            if(età < 16)
            {
                return "biennio";
            }
            else
            {
                return "triennio";
            }
        }

    }
}
