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
    public partial class LanguageForm : Form
    {
        public LanguageForm()
        {
            InitializeComponent();
        }

        private string _inicial { get; set; }
    
        /*
        public string Inicial
        {
            get { return _inicial; }
            set { _inicial = textBox5.Text; }

        }*/
        private string _final { get; set; }

        /*public string Final
        {
            get { return _final; }
            set { _final = textBox4.Text; }

        }*/

        private string _entrada { get; set; }
        /*public string Entrada
        {
            get { return _entrada; }
            set { _entrada = textBox1.Text; }

        }*/

        private string _saida { get; set; }
        /*public string Saida
        {
            get { return _saida; }
            set { _saida = textBox2.Text; }

        } */

        private string _transicao{ get; set; }

      /*  public string Transicao
        {
            get { return _transicao; }
            set { _transicao = textBox2.Text; } 

        } */
    }
}
