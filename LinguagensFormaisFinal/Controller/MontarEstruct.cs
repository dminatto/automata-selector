using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LinguagensFormaisFinal.Model;
using LinguagensFormaisFinal.View;

namespace LinguagensFormaisFinal.Controller
{
    class MontarEstruct
    {


        Estrutura estrutura = new Estrutura();
        

        public void resgateLinguagem(String inicial,String final, String entrada, String saida, String Transições)
        {
            estrutura.entrada = estrutura.QuebrarFinal(entrada);
            estrutura.saida = estrutura.QuebrarFinal(saida);
            estrutura.transicoes = estrutura.QuebrarFinal(Transições);
            estrutura.final = estrutura.QuebrarFinal(final);
            estrutura.inicial = estrutura.QuebrarFinal(inicial);
        }
    }
}
