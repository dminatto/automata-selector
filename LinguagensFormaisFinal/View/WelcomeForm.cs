using System;
using System.Drawing;
using System.Windows.Forms;
using LinguagensFormaisFinal.Controller;

namespace LinguagensFormaisFinal.View
{
    public partial class Welcome : Form
    {

        enum FormType
        {
            Welcome,
            Language,
            _AFNDorAFD,
            IsAFD,
            IsAFND,
            _Transformer,
            Convert,
            Sentence,
            _ProcessToSentence,
            Result,
            
         }

        public Welcome()
        {
            InitializeComponent();
            Menu((int)FormType.Welcome);
            
                    
        }

        public Form _FormActive;
        public int _FormType;

        /*
         * Tamanho do Form
         * 682, 374
         * Posição
         * 0, 27
         */

        private void BTAvancar_Click(object sender, EventArgs e)
        {
          _FormType++;
           Menu(_FormType);
            
        }

        public void Menu(int _FormType)
        {
            switch (_FormType)
            {
                case (int)FormType.Welcome:
                    {
                        
                        this.SuspendLayout();
                        _FormActive = new WelcomeTwocs();
                        _FormActive.MdiParent = this;
                        _FormActive.Location = new Point(0, 27);
                        _FormActive.Size = new Size(682, 374);
                        _FormActive.Show();
                        _FormActive.Top = 0;

                        BTVoltar.Visible = false;
                        this.ResumeLayout();
                        
                    }
                    break;
                case (int)FormType.Language:
                    {
                        this.SuspendLayout();
                        _FormActive = new LanguageForm();
                        _FormActive.MdiParent = this;
                        _FormActive.Location = new Point(0, 27);
                        _FormActive.Size = new Size(682, 374);
                        _FormActive.Show();
                        _FormActive.Top = 0;
                        
                        BTVoltar.Visible = true;
                        this.ResumeLayout();
                        
                    }
                    break;

                case (int)FormType._AFNDorAFD:
                {
                    LanguageForm language = _FormActive as LanguageForm;
                    MontarEstruct montarEstruct = new MontarEstruct();
                    montarEstruct.resgateLinguagem(language.textBox5.Text, language.textBox4.Text, language.textBox1.Text, language.textBox2.Text, language.textBox3.Text);
                    toolStripStatusLabel1.Text = "Aguarde enquanto estamos processando sua sentença...";
                }
                    break;
                case (int)FormType.IsAFD:
                    {
                        this.SuspendLayout();
                        _FormActive.Close();
                        _FormActive = new IsAFDForm();
                        _FormActive.MdiParent = this;
                        _FormActive.Location = new Point(0, 27);
                        _FormActive.Size = new Size(682, 374);
                        _FormActive.Show();
                        _FormActive.Top = 0;
                        BTVoltar.Visible = true;
                        toolStripStatusLabel1.Text = "";
                        this.ResumeLayout();
                    }
                    break;

                case (int)FormType.IsAFND:
                    {
                        this.SuspendLayout();
                        _FormActive.Close();
                        _FormActive = new IsAFNDForm();
                        _FormActive.MdiParent = this;
                        _FormActive.Location = new Point(0, 27);
                        _FormActive.Size = new Size(682, 374);
                        _FormActive.Show();
                        _FormActive.Top = 0;
                        toolStripStatusLabel1.Text = "";
                        BTVoltar.Visible = true;
                        this.ResumeLayout();
                    }
                    break;
                case (int)FormType._Transformer:
                {
                    toolStripStatusLabel1.Text = "Aguarde enquanto o programa transforma seu AFND...";
                }
                    break;
                case (int)FormType.Convert:
                    {
                        this.SuspendLayout();
                        _FormActive.Close();
                        _FormActive = new ConvertForm();
                        _FormActive.MdiParent = this;
                        _FormActive.Location = new Point(0, 27);
                        _FormActive.Size = new Size(682, 374);
                        _FormActive.Show();
                        _FormActive.Top = 0;
                        toolStripStatusLabel1.Text = "";
                    }
                    break;
                case (int)FormType.Sentence:
                    {
                        this.SuspendLayout();
                        _FormActive.Close();
                        _FormActive = new SentenceForm();
                        _FormActive.MdiParent = this;
                        _FormActive.Location = new Point(0, 27);
                        _FormActive.Size = new Size(682, 374);
                        _FormActive.Show();
                        _FormActive.Top = 0;
                     

                    } break;

                case(int)FormType._ProcessToSentence:
                {
                    toolStripStatusLabel1.Text = "Aguarde enquanto o programa processa sua sentença...";
                }
                    break;
                case (int)FormType.Result:
                    {
                        this.SuspendLayout();
                        _FormActive.Close();
                        _FormActive = new ResultForm();
                        _FormActive.MdiParent = this;
                        _FormActive.Location = new Point(0, 27);
                        _FormActive.Size = new Size(682, 374);
                        _FormActive.Show();
                        _FormActive.Top = 0;
                        toolStripStatusLabel1.Text = "";
                        BTAvancar.Enabled = false;

                    } break;

            }
        }

        private void BTVoltar_Click(object sender, EventArgs e)
        {
            _FormType--;
            Menu(_FormType);
        }

        private void BTCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
