using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verificaRecupero
{
    internal class scuola
    {
        public string nomeScuola { get; set; }
        public string indirizzoScuola { get; set; }
        public string orarioApertura { get; set; }
        public string orarioChiusura { get; set; }

        private list<alunno> alunni = new list<alunno>();

        public void aggiungiAlunno(alunno alunno)
        {
            alunni.Add(alunno);
        }

        public int numeroAlunni()
        {
            return alunni.count;
        }
        public int ricercaPerCognome()
        {
            return alunni.Where;
        }
    }
}
