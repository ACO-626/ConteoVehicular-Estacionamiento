using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Threading;
using System.Runtime.InteropServices;

namespace ContadorVehicular
{
    public partial class MainForm : Form
    {
        #region ObjetosYvariables
        string pathBDRegistro = "Tabla_de_Registros.txt";
        string pathBDConteo = "Conteo_de_vehículos.txt";
        string pathBDCapacity = "Est_Capacaity.txt";
        
        bool endConection = false; //Bandera de comunicación serial
        bool salida;               //Variable que indica si el auto va de salida
        //string textEvento;         //Mensaje de comunicación serial 


        System.IO.Ports.SerialPort puerto = new System.IO.Ports.SerialPort(); //Instancia de la clase puerto
        List<string> listaEstacionamiento = new List<string>();  //Lista donde se almacenan los ID de los carros
        int ingresos = 0;   //Carros ingresados
        int cupo = 257;     //Capacidad estacionamiento
        #endregion
        #region Inicializar
        public MainForm()
        {
            InitializeComponent();     //Método de inicialización de Form
            puerto.PortName = "COM5";  //Indicación de puerto por defecto
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
            
            Thread Hilo = new Thread(EscuchaPuerto); //Se crea hilo de escucha de puerto
            Hilo.Start(); //Se inicia hilo
            AbrirFormulario(new FormEstacionamiento());
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
                            #region GuardadoEnRam
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
                                RegistrarBD(cadena,"salida ",pathBDRegistro);
                                ReplaceValueBD(ingresos.ToString(), pathBDConteo);
                            }
                            else
                            {
                                listaEstacionamiento.Add(cadena);
                                labelCom.Text = "entrada" + cadena;
                                ingresos++;
                                labelCounterCar.Text = ingresos.ToString();
                                RegistrarBD(cadena, "entrada",pathBDRegistro);
                                ReplaceValueBD(ingresos.ToString(),pathBDConteo);
                            }

                            labelEspacios.Text = (cupo - ingresos).ToString();
                            #endregion                           
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

       
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        #region BarraVentana
        #region Maximizar
        private void BtnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMax.Visible = false;
            btnMax2.Visible = true;
        }
        private void BtnMax2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMax.Visible = true;
            btnMax2.Visible = false;
        }
        #endregion

        #region Minimizar


        private void BtnMinimiza_Click(object sender, EventArgs e)
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

        private Form activeForm = null;
        private void AbrirFormulario(Form formHijo)
        {
            /*
            if(this.panelCont.Controls.Count > 0)
            {
                this.panelCont.Controls.RemoveAt(0);
            }
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelCont.Controls.Add(fh);
            this.panelCont.Tag = fh;
            fh.Show();  */
            
            if (activeForm != null)
            {
                activeForm.Close();
            }
                
            activeForm = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            this.panelCont.Controls.Add(formHijo);
            this.panelCont.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();


        }



        #endregion
        #region PestañasBtns
        private void BtnEstacionamiento_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormEstacionamiento());
            labelHeaderTittle.Text = "Sistema de conteo";
            labelHeaderSubtittle.Text = "vehicular";
            
            
            btnSesion.BackColor = Color.FromArgb(31, 31, 31);
            btnSettings.BackColor = Color.FromArgb(31, 31, 31);
            btnStatics.BackColor = Color.FromArgb(31, 31, 31);
            btnEstacionamiento.BackColor = Color.FromArgb(205, 23, 30);
        }

        private void BtnStatics_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormStatics());
            labelHeaderTittle.Text = "Estadística";
            labelHeaderSubtittle.Text = "Análisis de datos";
            btnEstacionamiento.BackColor = Color.FromArgb(31, 31, 31);
            btnSesion.BackColor = Color.FromArgb(31, 31, 31);
            btnSettings.BackColor = Color.FromArgb(31, 31, 31);
            btnStatics.BackColor = Color.FromArgb(205, 23, 30);
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormSettings());
            labelHeaderTittle.Text = "Ajustes";
            labelHeaderSubtittle.Text = "Requiere identificación";
            btnEstacionamiento.BackColor = Color.FromArgb(31, 31, 31);
            btnSesion.BackColor = Color.FromArgb(31, 31, 31);         
            btnStatics.BackColor = Color.FromArgb(31, 31, 31);
            btnSettings.BackColor = Color.FromArgb(205, 23, 30);

        }

        private void BtnSesion_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Inicio());
            labelHeaderTittle.Text = "Sesión";
            labelHeaderSubtittle.Text = "Identificación de trabajador";
            btnEstacionamiento.BackColor = Color.FromArgb(31, 31, 31);
            
            btnSettings.BackColor = Color.FromArgb(31, 31, 31);
            btnStatics.BackColor = Color.FromArgb(31, 31, 31);
            btnSesion.BackColor = Color.FromArgb(205, 23, 30);
        }


        #endregion
        #region EscribirBD

        private void RegistrarBD(string id, string evento, string bdPath)
        {
            id = id.Replace("\r", "");
            StreamWriter writer = File.AppendText(bdPath);
            writer.WriteLine(id + "        " + evento + "        " + DateTime.Now.ToString());
            writer.Close();
            MessageBox.Show("Datos guardados de registro", "datos guardados");
        }
        #endregion
        #region makeCount
        private void ReplaceValueBD(string text, string bdPath)
        {
            TextWriter textWriter = new StreamWriter(bdPath);
            textWriter.WriteLine(text);
            textWriter.Close();
            MessageBox.Show("Datos guardados de conteo", "datos guardados");
        }
        #endregion
    }
}
