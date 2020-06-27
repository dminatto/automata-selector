using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinguagensFormaisFinal.Model
{
    class Estrutura
    {
        public String[] saida { get; set; }
        public String[] entrada { get; set; }
        public String[] transicoes { get; set; }
        public String[] inicial { get; set; }
        public String[] final { get; set; }

       public string[] QuebrarFinal(String _string)
        {
           return _string.Split(new[] { ',', '.', ';','{','}','(',')' });
        }


    }
}
