using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SS001
{
    class Validacion
    {
        public void letras(KeyPressEventArgs ev)
        {
            try
            {
                if (Char.IsLetter(ev.KeyChar) || Char.IsControl(ev.KeyChar) || Char.IsSeparator(ev.KeyChar))
                {
                    ev.Handled = false;
                }
                else
                {
                    ev.Handled = true;
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void letrasSinEspacios(KeyPressEventArgs ev)
        {
            try
            {
                if (Char.IsLetter(ev.KeyChar) || Char.IsControl(ev.KeyChar) )
                {
                    ev.Handled = false;
                }
                else
                {
                    ev.Handled = true;
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void numeros(KeyPressEventArgs ev)
        {
            try
            {
                if (Char.IsNumber(ev.KeyChar) || Char.IsControl(ev.KeyChar))
                {
                    ev.Handled = false;
                }
                else
                {
                    ev.Handled = true;
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
