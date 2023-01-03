using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Threading;
using System.Runtime.InteropServices;
using System.Media;
using System.Diagnostics;

namespace ContadorVehicular
{
    public partial class MainForm : Form
    {
        #region ObjetosYvariables
        string pathBDRegistro = "Tabla_de_Registros.txt";
        string pathBDConteo = "Conteo_de_vehículos.txt";
        string pathBDCapacity = "Est_Capacaity.txt";

        FormEstacionamiento formEstacionamiento;
        FormSettings formSettings;
        FormStatics formStatics;
        Inicio formInicio;

        bool tabEstacionamiento;
        bool tabAjustes;
        bool tabStatics;
        bool tabInicio;

        SoundPlayer regisBeep = new SoundPlayer();
        SoundPlayer  salidaBeep = new SoundPlayer();
        SoundPlayer regisBeepRnd = new SoundPlayer();
        SoundPlayer salidaBeepRnd = new SoundPlayer();


        bool endConection = false; //Bandera de comunicación serial
        bool salida;               //Variable que indica si el auto va de salida
        bool advertencia = false;
        //string textEvento;         //Mensaje de comunicación serial 

        private Form activeForm = null;

        System.IO.Ports.SerialPort puerto = new System.IO.Ports.SerialPort(); //Instancia de la clase puerto
        List<string> listaEstacionamiento = new List<string>();  //Lista donde se almacenan los ID de los carros
        int ingresos = 0;   //Carros ingresados
        int capacidad;     //Capacidad estacionamiento
        int capacidadDefault = 257;

        Random rnd = new Random();
        bool rndAudio = false;
        int randomNumber;

        #endregion
        #region Inicializar
        public MainForm()
        {
            InitializeComponent();     //Método de inicialización de Form
            puerto.PortName = "COM4";  //Indicación de puerto por defecto
            puerto.BaudRate = 9600;    //Indicación de la velocidad de comunicación 
            puerto.ReadTimeout = 500;  //Tiempo de espera para periodo de espera en lectura
            try
            {
                puerto.Open();  //Se aplica el método Open para entablar comunicación
            }
            catch { }
            if(!File.Exists(pathBDCapacity))
            {
                ReplaceValueBD(capacidadDefault.ToString(), pathBDCapacity);
                capacidad = capacidadDefault;
                //VerificarFuente();

            }
            else
            {
                capacidad = int.Parse(SimpleConsult(pathBDCapacity));
                //VerificarFuente();
            }
            
            
            try
            {
                regisBeep.SoundLocation = @"..\..\sound\registerBeep.wav";
                salidaBeep.SoundLocation = @"..\..\sound\salidaBeep.wav";
                

            }
            catch (Exception)
            {
                MessageBox.Show("Faltan Archivos de sonido, error: 1001");
            }
            

        }
        private void Form1_Load(object sender, EventArgs e)
        {          
            
            Thread Hilo = new Thread(EscuchaPuerto); //Se crea hilo de escucha de puerto
            Hilo.Start(); //Se inicia hilo
            formEstacionamiento = new FormEstacionamiento();
            AbrirFormularioEstacionamiento();
            
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
                                
                                salida = false;
                                RegistrarBD(cadena,"salida ",pathBDRegistro,true);
                                ReplaceValueBD(ingresos.ToString(), pathBDConteo);
                            }
                            else
                            {
                                listaEstacionamiento.Add(cadena);
                                labelCom.Text = "entrada" + cadena;
                                ingresos++;
                                
                                RegistrarBD(cadena, "entrada",pathBDRegistro,false);
                                ReplaceValueBD(ingresos.ToString(),pathBDConteo);

                            }
                            formEstacionamiento.Ingresos = ingresos.ToString();
                            formEstacionamiento.Espacios = (capacidad - ingresos).ToString();
                            formEstacionamiento.refrescarValor();
                            
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

        
        private void AbrirFormulario(Form formHijo)
        {
                       
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

        private void AbrirFormularioEstacionamiento()
        {
            CierraFormActivo();
            formEstacionamiento = new FormEstacionamiento();
            formEstacionamiento.TopLevel = false;
            formEstacionamiento.FormBorderStyle = FormBorderStyle.None;
            formEstacionamiento.Dock = DockStyle.Fill;
            this.panelCont.Controls.Add(formEstacionamiento);
            formEstacionamiento.BringToFront();

            formEstacionamiento.Ingresos = ingresos.ToString();
            formEstacionamiento.Espacios = (capacidad - ingresos).ToString();
            formEstacionamiento.refrescarValor();
            formEstacionamiento.Show();
            tabEstacionamiento = true;

        }
        private void AbrirFormularioStatics()
        {
            CierraFormActivo();
            formStatics = new FormStatics();
            formStatics.TopLevel = false;
            formStatics.FormBorderStyle = FormBorderStyle.None;
            formStatics.Dock = DockStyle.Fill;
            this.panelCont.Controls.Add(formStatics);
            formStatics.BringToFront();
            formStatics.Show();
            tabStatics = true;
        }

        private void AbrirFormularioSettings()
        {
            CierraFormActivo();
            formSettings = new FormSettings();
            formSettings.TopLevel = false;
            formSettings.FormBorderStyle = FormBorderStyle.None;
            formSettings.Dock = DockStyle.Fill;
            this.panelCont.Controls.Add(formSettings);
            formSettings.BringToFront();
            formSettings.Show();
            tabAjustes = true;
        }
        private void AbrirFormularioInicio()
        {
            CierraFormActivo();
            formInicio = new Inicio();
            formInicio.TopLevel = false;
            formInicio.FormBorderStyle = FormBorderStyle.None;
            formSettings.Dock = DockStyle.Fill;
            this.panelCont.Controls.Add(formInicio);
            formInicio.BringToFront();
            formInicio.Show();
            tabInicio = true;
        }

        #endregion
        #region PestañasBtns
        private void BtnEstacionamiento_Click(object sender, EventArgs e)
        {
            //AbrirFormulario(new FormEstacionamiento());
            if (!File.Exists(pathBDCapacity))
            {
                ReplaceValueBD(capacidadDefault.ToString(), pathBDCapacity);
                capacidad = capacidadDefault;

            }
            else
            {
                capacidad = int.Parse(SimpleConsult(pathBDCapacity));
                
            }
            //VerificarFuente();
            AbrirFormularioEstacionamiento();
            
            labelHeaderTittle.Text = "Sistema de conteo";
            labelHeaderSubtittle.Text = "vehicular";
            
            
            btnSesion.BackColor = Color.FromArgb(31, 31, 31);
            btnSettings.BackColor = Color.FromArgb(31, 31, 31);
            btnStatics.BackColor = Color.FromArgb(31, 31, 31);
            btnEstacionamiento.BackColor = Color.FromArgb(205, 23, 30);
            
        }

        private void BtnStatics_Click(object sender, EventArgs e)
        {
            //AbrirFormulario(new FormStatics());
            AbrirFormularioStatics();
            labelHeaderTittle.Text = "Estadística";
            labelHeaderSubtittle.Text = "Análisis de datos";
            btnEstacionamiento.BackColor = Color.FromArgb(31, 31, 31);
            btnSesion.BackColor = Color.FromArgb(31, 31, 31);
            btnSettings.BackColor = Color.FromArgb(31, 31, 31);
            btnStatics.BackColor = Color.FromArgb(205, 23, 30);
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            //AbrirFormulario(new FormSettings());
            AbrirFormularioSettings();
            labelHeaderTittle.Text = "Ajustes";
            labelHeaderSubtittle.Text = "Requiere identificación";
            btnEstacionamiento.BackColor = Color.FromArgb(31, 31, 31);
            btnSesion.BackColor = Color.FromArgb(31, 31, 31);         
            btnStatics.BackColor = Color.FromArgb(31, 31, 31);
            btnSettings.BackColor = Color.FromArgb(205, 23, 30);

        }

        private void BtnSesion_Click(object sender, EventArgs e)
        {
            //AbrirFormulario(new Inicio());
            AbrirFormularioInicio();
            labelHeaderTittle.Text = "Sesión";
            labelHeaderSubtittle.Text = "Identificación de trabajador";
            btnEstacionamiento.BackColor = Color.FromArgb(31, 31, 31);
            
            btnSettings.BackColor = Color.FromArgb(31, 31, 31);
            btnStatics.BackColor = Color.FromArgb(31, 31, 31);
            btnSesion.BackColor = Color.FromArgb(205, 23, 30);
        }


        #endregion
        #region EscribirBD

        private void RegistrarBD(string id, string evento, string bdPath, bool salida)
        {
            id = id.Replace("\r", "");
            StreamWriter writer = File.AppendText(bdPath);
            writer.WriteLine(id + "        " + evento + "        " + DateTime.Now.ToString());
            writer.Close();
            //MessageBox.Show("Datos guardados de registro", "datos guardados");
            PlaySound(rndAudio, salida);        
            
        }
        #endregion
        #region makeCount
        private void ReplaceValueBD(string text, string bdPath)
        {
            TextWriter textWriter = new StreamWriter(bdPath);
            textWriter.WriteLine(text);
            textWriter.Close();
            //MessageBox.Show("Datos guardados de conteo", "datos guardados");
            
        }

        
        #endregion

        #region simpleConsult
        private string SimpleConsult(string pathBD)
        {
            TextReader lectorSimple = new StreamReader(pathBD);
            //lectorSimple.ReadLine();
            string consulta = lectorSimple.ReadLine();
            lectorSimple.Close();
            return consulta;
        }
        #endregion

        #region AsignAudio
        private void PlaySound(bool random, bool salida)
        {
            
            if(random)
            {
                randomNumber = rnd.Next(0, 2);
                if (salida)
                {

                    salidaBeepRnd.SoundLocation = @"..\..\sound\salidaVoice"+randomNumber+".wav";
                    salidaBeepRnd.Play();
                }
                else
                {
                    regisBeepRnd.SoundLocation = @"..\..\sound\registerVoice" + randomNumber + ".wav";
                    regisBeepRnd.Play();
                }
            }
            else
            {
                if(salida)
                {
                    salidaBeep.Play();
                }
                else
                {
                    regisBeep.Play();
                }
            }
        }

        #endregion

        #region CerrarFormActivo
        private void CierraFormActivo()
        {
            if (tabEstacionamiento)
            {
                formEstacionamiento.Close();
                tabEstacionamiento = false;
            }else if(tabStatics)
            {
                formStatics.Close();
                tabStatics = false;
            }else if (tabAjustes)
            {
                formSettings.Close();
                tabAjustes = false;
            }else if (tabInicio)
            {
                formInicio.Close();
                tabInicio = false;
            }        
            

        }
        #endregion

        #region MenuStrip

        #region Archivo
        private void bDRegistrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(pathBDRegistro);
        }
      

        private void bDIngresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(pathBDConteo);
        }

        private void bDCapacidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(pathBDCapacity);
        }
            //Audio
        private void interfazPorVozToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rndAudio = true;
            interfazNotificaciónToolStripMenuItem.Enabled = true;
            interfazPorVozToolStripMenuItem.Enabled = false;
        }

        private void interfazNotificaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rndAudio = false;
            interfazNotificaciónToolStripMenuItem.Enabled = false;
            interfazPorVozToolStripMenuItem.Enabled = true;
        }

        private void activadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnManualPlus.Visible = true;
            btnManualLess.Visible = true;
            activadoToolStripMenuItem.Enabled = false;
            desactivadoToolStripMenuItem.Enabled = true;
        }
        private void desactivadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnManualPlus.Visible = false;
            btnManualLess.Visible = false;
            activadoToolStripMenuItem.Enabled = true;
            desactivadoToolStripMenuItem.Enabled = false;
        }

        private void reiniciarConteoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ingresos = 0;
            ReplaceValueBD("0", pathBDConteo);
            formEstacionamiento.Ingresos = ingresos.ToString();
            formEstacionamiento.Espacios = (capacidad - ingresos).ToString();
            formEstacionamiento.refrescarValor();

        }


        #endregion

        #region Editar
        private void registrarIngresoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManualPlus();

        }

        private void registrarSalidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManualLess();
            
        }

        //Editar capacidad

        private void modificarCapacidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioSettings();
            labelHeaderTittle.Text = "Ajustes";
            labelHeaderSubtittle.Text = "Requiere identificación";
            btnEstacionamiento.BackColor = Color.FromArgb(31, 31, 31);
            btnSesion.BackColor = Color.FromArgb(31, 31, 31);
            btnStatics.BackColor = Color.FromArgb(31, 31, 31);
            btnSettings.BackColor = Color.FromArgb(205, 23, 30);
        }







        #endregion

        #region Configuracion
        private void puertoLectorToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            puertoLectorToolStripMenuItem.DropDownItems.Clear();
            string[] ports = SerialPort.GetPortNames();
            foreach (var i in ports)
            {
                puertoLectorToolStripMenuItem.DropDownItems.Add(i);
            }
        }
        private void puertoLectorToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //Button btn = sender as Button;
            //MessageBox.Show(btn.Text);
            puerto.Close();
            puerto.PortName = e.ClickedItem.Text;
            //MessageBox.Show("Aseguresé de tener conectado el lector al puerto: "+e.ClickedItem.Text+ " para una adecuada lectura","Cambio de puerto",MessageBoxButtons.OK);
            puerto.Open();
        }

        private void puertoLectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            puertoLectorToolStripMenuItem.DropDownItems.Clear();
            string[] ports = SerialPort.GetPortNames();
            foreach (var i in ports)
            {
                puertoLectorToolStripMenuItem.DropDownItems.Add(i);
            }
        }
        #endregion

        #region Ayuda
        private void githubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/ACO-626/ConteoVehicular-Estacionamiento");
        }
        private void soporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://aco-626.github.io/ConteoVehicular-Estacionamiento/soporte.html");
        }

        private void sitioWebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://aco-626.github.io/ConteoVehicular-Estacionamiento/index.html");
        }
        #endregion

        #endregion

        #region BTNPLUS  LESS
        private void btnManualPlus_MouseUp(object sender, MouseEventArgs e)
        {
            ManualPlus();
        }

        private void btnManualLess_MouseUp(object sender, MouseEventArgs e)
        {
            ManualLess();
           
        }

        #endregion

        #region FuncionesManipulacionManual
        private void ManualPlus()
        {
            bool rndActual = rndAudio;
            if (rndAudio)
            {               
                rndAudio = false;
            }
           
            ingresos++;
            RegistrarBD("Registro manual", "entrada", pathBDRegistro, false);
            ReplaceValueBD(ingresos.ToString(), pathBDConteo);
            formEstacionamiento.Ingresos = ingresos.ToString();
            formEstacionamiento.Espacios = (capacidad - ingresos).ToString();
            formEstacionamiento.refrescarValor();
            if (ingresos > capacidad)
            {
                if(!advertencia)
                {
                    MessageBox.Show("El número de vehículos establecido ha sido rebasado", "Desborde vehicualr", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    advertencia = true;
                }
                
            }else 
            {
                advertencia = false;
            }
            rndAudio = rndActual;
        }

        private void ManualLess()
        {
            if (ingresos > 0)
            {
                bool rndActual = rndAudio;
                if (rndAudio)
                {
                    rndAudio = false;
                }
              
                ingresos--;
                RegistrarBD("Registro manual", "salida", pathBDRegistro, true);
                ReplaceValueBD(ingresos.ToString(), pathBDConteo);
                formEstacionamiento.Ingresos = ingresos.ToString();
                formEstacionamiento.Espacios = (capacidad - ingresos).ToString();
                formEstacionamiento.refrescarValor();
                rndAudio = rndActual;
            }
            else
            {
                MessageBox.Show("No puede registrar una salida porque no hay ingresos registrados", "REGISTRO IMPOSIBLE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
















        #endregion

        
    }
}
