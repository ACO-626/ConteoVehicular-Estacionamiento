using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace ContadorVehicular
{

    public partial class FormEstacionamiento : Form
    {

        

        public FormEstacionamiento()
        {
            InitializeComponent();
        }

        #region Variables Encapsuladas

        //Encapsulado

        string ingresos;
        public string Ingresos
        {
            set
            {
                ingresos = value;
            }
        }

        string espacios;
        public string Espacios
        {
            set
            {
                espacios = value;
            }
        }

        #endregion
        public void refrescarValor()
        {
            VerificarFuente(int.Parse(ingresos), int.Parse(espacios));
            labelIngresos.Text = ingresos ;
            labelEspacios.Text = espacios ;
        }

        #region simpleConsult
        private string SimpleConsult(string pathBD)
        {
            TextReader lectorSimple = new StreamReader(pathBD);
            return lectorSimple.ReadLine();
        }
        #endregion

        private void VerificarFuente(int ingresos, int espacios)
        {
            if (ingresos > 999 && ingresos < 9999)
            {
                labelIngresos.Font = new Font("Montserrat", 100f, labelEspacios.Font.Style);
            }
            else if (ingresos > 9999)
            {
                labelIngresos.Font = new Font("Montserrat", 75f, labelEspacios.Font.Style);
              //  MessageBox.Show(labelEspacios.Font.Size.ToString());
            }

            if (espacios > 999 && espacios < 9999)
            {
                labelEspacios.Font = new Font("Montserrat", 100f, labelIngresos.Font.Style);
            }
            else if (espacios > 9999)
            {
                labelEspacios.Font = new Font("Montserrat", 75f, labelIngresos.Font.Style);
                //MessageBox.Show(labelEspacios.Font.Size.ToString());
            }
        }

        private void lbSimpleBy_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/ACO-626");
        }
    }
}
