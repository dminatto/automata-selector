using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LinguagensFormaisFinal.Controller;

namespace LinguagensFormaisFinal.View
{
    public partial class IsAFDForm : Form
    {
        public IsAFDForm()
        {
            InitializeComponent();
            IncludeDataGrid includeData = new IncludeDataGrid();
            includeData.HasDataGrid(dataGridView2);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


       

    }
}
