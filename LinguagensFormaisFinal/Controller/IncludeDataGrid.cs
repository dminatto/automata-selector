using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinguagensFormaisFinal.Controller
{
    class IncludeDataGrid
    {

            Object[] teste1 = {"->A", "B", "C"};
            Object[] teste2 = {"B", "A", "X"};
            Object[] teste3 = {"*C", "B", "-"};
            Object[] teste4 = {"*X", "B", "C"};
      

        
        public void HasDataGrid(DataGridView dataGrid)
        {
            
            dataGrid.Columns.Add("Coluna a", "a");
            dataGrid.Columns.Add("Coluna b", "b");
            dataGrid.Rows.Add(teste1);
            dataGrid.Rows.Add(teste2);
            dataGrid.Rows.Add(teste3);
            dataGrid.Rows.Add(teste4);
        }

        public void addColumns(DataGridView dataGrid,String name)
        {
            dataGrid.Columns.Add(name, name);
        }

        public void addRows(DataGridView dataGrid, object[] name)
        {
            dataGrid.Rows.Add(name);
        }
    }
}
