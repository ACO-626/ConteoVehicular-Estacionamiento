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
using System.Runtime.InteropServices;

namespace ContadorVehicular
{
    public partial class MainForm : Form
    {
        #region OBJETOS Y VARIABLES

        bool endConection = false; //Bandera de conexión
        bool salida;  //VAriable 



        System.IO.Ports.SerialPort puerto = new System.IO.Ports.SerialPort(); //Instancia de la clase puerto
        List<string> listaEstacionamiento = new List<string>();  //Lista donde se almacenan los ID de los carros
        int ingresos = 0;
        int cupo = 257;
        #endregion

        #region Inicializar
        public MainForm()
        {
            InitializeComponent();     //Método de inicialización de Form
            puerto.PortName = "COM3";  //Indicación de puerto por defecto
            puerto.BaudRate = 9600;    //Indicación de la velocidad de comunicación 
            puerto.ReadTimeout = 500;  //Tiempo de espera para periodo de espera en lectura
            try
            {
                puerto.Open();  //Se aplica el método Open para entablar comunicación
            }
            catch { }
            labelEspacios.Text = (cupo - ingresos).ToString();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Thread Hilo = new Thread(EscuchaPuerto);
            Hilo.Start();
        }

        #region MoverVentana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();


        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion
        #endregion

        #region MetodoEscuchaPuerto
        private void EscuchaPuerto() //método escuchar puerto para ejecutar en un hilo
        {
            while(!endConection) //Mientra no termine la conexión
            {
                try
                {
                    string cadena = puerto.ReadLine(); //Cadena de lectura
                    //Se hace uso del delegado para acceder a labelCom
                    labelCom.Invoke(new MethodInvoker( 
                        delegate
                        {
                            foreach (var i in listaEstacionamiento)
                            {
                                if(i == cadena)
                                {
                                    salida = true;
                                }
                            }
                             if(salida)
                            {
                                listaEstacionamiento.Remove(cadena);
                                labelCom.Text = "salida" + cadena;
                                ingresos--;
                                labelCounterCar.Text = ingresos.ToString();
                                salida = false;
                            }
                            else
                            {
                                listaEstacionamiento.Add(cadena);
                                labelCom.Text = "entrada" + cadena;
                                ingresos++;
                                labelCounterCar.Text = ingresos.ToString();
                            }

                            labelEspacios.Text = (cupo - ingresos).ToString();
 
                        }
                        ));
                    
                }
                catch { }
            }
        }

        #endregion

        #region CloseAPP
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            endConection = true;
            if (puerto.IsOpen)
            {
                puerto.Close();
            }
        }

       
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region BARRAVentana
        #region Maximizar
        private void btnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMax.Visible = false;
            btnMax2.Visible = true;
        }
        private void btnMax2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMax.Visible = true;
            btnMax2.Visible = false;
        }
        #endregion

        #region Minimizar


        private void btnMinimiza_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion
        private void BarraTittle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Formularios hijos

        private void AbrirFormulario(object formHijo)
        {
            if(this.panelCont.Controls.Count > 0)
            {
                this.panelCont.Controls.RemoveAt(0);
            }
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelCont.Controls.Add(fh);
            this.panelCont.Tag = fh;
            fh.Show();  
        }



        #endregion

        private void btnEstacionamiento_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormEstacionamiento());
        }

        private void btnStatics_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormStatics());
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormSettings());
        }

        private void btnSesion_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Inicio());
        }
    }
}
