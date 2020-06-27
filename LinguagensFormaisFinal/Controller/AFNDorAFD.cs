using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LinguagensFormaisFinal.Model;

namespace LinguagensFormaisFinal.Controller
{
    class AFNDorAFD
    {
        Estrutura estrutura;
         IncludeDataGrid include = new IncludeDataGrid();

        private void MontrarEstrutura(Estrutura estrutura)
        {

        }

        private void MontarCabecalho(Estrutura estrutura, DataGridView dataGrid)
        {
            for (int i = 0; i < estrutura.entrada.Length; i++)
            {
                include.addColumns(dataGrid, estrutura.entrada[i]);    
            }
            
        }

        private void MontarTransições(Estrutura estrutura, DataGridView dataGrid)
        {
            for (int i = 0; i < estrutura.saida.Length; i++)
            {
                object[] aux = null;

                if (estrutura.saida[i] == estrutura.transicoes[i])
                {
                   // aux = (object[]) estrutura.transicoes[i + 2];
                }
            }
        }

    }
}
