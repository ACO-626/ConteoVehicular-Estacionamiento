using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContadorVehicular
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        #region FuncionamientoEntrada
        private void textBoxUsuario_Enter(object sender, EventArgs e)
        {
            if(textBoxUsuario.Text == "Número trabajador")
            {
                textBoxUsuario.Text = "";
                textBoxUsuario.ForeColor = Color.Black;
                textBoxUsuario.Font = new System.Drawing.Font(textBoxUsuario.Font,FontStyle.Regular);
            }
        }


        

        private void textBoxUsuario_Leave(object sender, EventArgs e)
        {
            if (textBoxUsuario.Text == "")
            {
                textBoxUsuario.Font = new System.Drawing.Font(textBoxUsuario.Font, FontStyle.Italic);
                textBoxUsuario.ForeColor = Color.Gray;
                textBoxUsuario.Text = "Número trabajador";
                
                
            }
        }

        private void textBoxClave_Enter(object sender, EventArgs e)
        {
            if (textBoxClave.Text == "Clave")
            {

                textBoxClave.Text = "";
                textBoxClave.UseSystemPasswordChar = true;
                textBoxClave.PasswordChar = '*';
                textBoxClave.ForeColor = Color.Black;
                textBoxClave.Font = new System.Drawing.Font(textBoxUsuario.Font, FontStyle.Regular);
            }
        }

        private void textBoxClave_Leave(object sender, EventArgs e)
        {
            if (textBoxClave.Text == "")
            {
                textBoxClave.Font = new System.Drawing.Font(textBoxUsuario.Font, FontStyle.Italic);
                textBoxClave.UseSystemPasswordChar = false;
                textBoxClave.PasswordChar = '\0';
                textBoxClave.Text = "Clave";                
                textBoxClave.ForeColor = Color.Gray;
                
            }
        }
        #endregion
    }
}
