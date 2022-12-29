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

        
    }
}
