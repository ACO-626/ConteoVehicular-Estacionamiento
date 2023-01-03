using System;
using System.IO;
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
    public partial class FormSettings : Form
    {

        string pathBDCapacity = "Est_Capacaity.txt";

        int newCapacidad = 257;

        public FormSettings()
        {
            InitializeComponent();
            RefreshCapacidad();
        }

        private void RefreshCapacidad()
        {
            lbCapacity.Text = SimpleConsult(pathBDCapacity);
        }



        private string SimpleConsult(string pathBD)
        {
            TextReader lectorSimple = new StreamReader(pathBD);
            //lectorSimple.ReadLine();
            string consulta = lectorSimple.ReadLine();
            lectorSimple.Close();
            return consulta;
        }

       
        private void btnDefinir_Click(object sender, EventArgs e)
        {
            if(Int32.TryParse(textBoxCapacidad.Text,out newCapacidad))
            {
                if(newCapacidad > 0 && newCapacidad < 99999)
                {
                    ReplaceValueBD(textBoxCapacidad.Text,pathBDCapacity);
                    RefreshCapacidad();
                }
                else
                {
                    MensajeErrorEntrada();
                    textBoxCapacidad.Clear();
                }

            }
            else
            {
                MensajeErrorEntrada();
            }
        }


        private void ReplaceValueBD(string text, string bdPath)
        {
            TextWriter textWriter = new StreamWriter(bdPath);
            textWriter.WriteLine(text);
            textWriter.Close();
            MessageBox.Show("Modificación realizada con éxito", "Datos guardados",MessageBoxButtons.OK);

        }

        private void MensajeErrorEntrada()
        {
            MessageBox.Show("Valor de capacidad invalido", "Revisar la capacidad ingresada", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void lbLinkAyuda_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/ACO-626/ConteoVehicular-Estacionamiento");
        }

        private void lbSimpleBy_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/ACO-626");
        }
    }
}
