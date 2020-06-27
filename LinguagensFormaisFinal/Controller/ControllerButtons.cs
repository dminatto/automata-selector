using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LinguagensFormaisFinal.View;

namespace LinguagensFormaisFinal.Controller
{
    class ControllerButtons
    {
        enum TypeButtons
        {
            Transformar,
            Desistir,
            Editar,
        }

        Welcome welcome = new Welcome();
       

        public void ControllerButtonAFND(int _typeButtons)
        {

            switch (_typeButtons)
            {
                case (int)TypeButtons.Transformar:
                {
                    welcome.Menu(welcome._FormType += 1);
                }
                    break;
                case (int)TypeButtons.Desistir:
                {
                    Application.Exit();
                }
                    break;
                case (int)TypeButtons.Editar:
                {
                    welcome.Menu(1);
                    break;
                }
                    break;
                
              }
        }

    }
}
