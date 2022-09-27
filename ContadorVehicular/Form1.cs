using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace ContadorVehicular
{
    public partial class Form1 : Form
    {

        bool endConection = false; //Bandera de conexión
        System.IO.Ports.SerialPort puerto = new System.IO.Ports.SerialPort(); //Instancia de la clase puerto

        public Form1()
        {
            InitializeComponent();
            puerto.PortName = "COM4";  //Indicación de puerto por defecto
            puerto.BaudRate = 9600;    //Indicación de la velocidad de comunicación 
            puerto.ReadTimeout = 500;  //Tiempo de espera para periodo de espera en lectura
            try
            {
                puerto.Open();
            }
            catch { }
            
        }

        private void EscuchaPuerto()
        {
            while(!endConection)
            {
                try
                {
                    string cadena = puerto.ReadLine();
                    comLabel.Invoke(new MethodInvoker(
                        delegate
                        {
                            comLabel.Text = cadena;
                        }
                        ));
                    
                }
                catch { }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread Hilo = new Thread(EscuchaPuerto);
            Hilo.Start();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            endConection = true;
            if (puerto.IsOpen)
            {
                puerto.Close();
            }
        }
    }
}
