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
    public partial class IsAFNDForm: Form
    {
        public IsAFNDForm()
        {
            InitializeComponent();
            IncludeDataGrid iDataGrid = new IncludeDataGrid();
            iDataGrid.HasDataGrid(dataGridView1);
        }

        ControllerButtons controller = new ControllerButtons();
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            controller.ControllerButtonAFND(0);
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            controller.ControllerButtonAFND(2);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            controller.ControllerButtonAFND(1);
        }

       
    }
}
