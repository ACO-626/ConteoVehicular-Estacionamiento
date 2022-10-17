
namespace ContadorVehicular
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelCom = new System.Windows.Forms.Label();
            this.labelCounterCar = new System.Windows.Forms.Label();
            this.labelSimpleEspacios = new System.Windows.Forms.Label();
            this.labelEspacios = new System.Windows.Forms.Label();
            this.BarraTittle = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelCont = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnMax = new System.Windows.Forms.PictureBox();
            this.btnMinimiza = new System.Windows.Forms.PictureBox();
            this.btnMax2 = new System.Windows.Forms.PictureBox();
            this.btnEstacionamiento = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnStatics = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnSesion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BarraTittle.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelCont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimiza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCom
            // 
            this.labelCom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCom.AutoSize = true;
            this.labelCom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCom.Location = new System.Drawing.Point(3, 613);
            this.labelCom.Name = "labelCom";
            this.labelCom.Size = new System.Drawing.Size(87, 25);
            this.labelCom.TabIndex = 0;
            this.labelCom.Text = "Mensaje";
            // 
            // labelCounterCar
            // 
            this.labelCounterCar.AutoSize = true;
            this.labelCounterCar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelCounterCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCounterCar.Location = new System.Drawing.Point(279, 3);
            this.labelCounterCar.Name = "labelCounterCar";
            this.labelCounterCar.Size = new System.Drawing.Size(24, 26);
            this.labelCounterCar.TabIndex = 2;
            this.labelCounterCar.Text = "0";
            // 
            // labelSimpleEspacios
            // 
            this.labelSimpleEspacios.AutoSize = true;
            this.labelSimpleEspacios.BackColor = System.Drawing.Color.Transparent;
            this.labelSimpleEspacios.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSimpleEspacios.Location = new System.Drawing.Point(3, 0);
            this.labelSimpleEspacios.Name = "labelSimpleEspacios";
            this.labelSimpleEspacios.Size = new System.Drawing.Size(107, 26);
            this.labelSimpleEspacios.TabIndex = 4;
            this.labelSimpleEspacios.Text = "Espacios:";
            // 
            // labelEspacios
            // 
            this.labelEspacios.AutoSize = true;
            this.labelEspacios.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelEspacios.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEspacios.Location = new System.Drawing.Point(106, 3);
            this.labelEspacios.Name = "labelEspacios";
            this.labelEspacios.Size = new System.Drawing.Size(24, 26);
            this.labelEspacios.TabIndex = 5;
            this.labelEspacios.Text = "0";
            // 
            // BarraTittle
            // 
            this.BarraTittle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.BarraTittle.Controls.Add(this.btnMax2);
            this.BarraTittle.Controls.Add(this.btnMinimiza);
            this.BarraTittle.Controls.Add(this.btnMax);
            this.BarraTittle.Controls.Add(this.btnClose);
            this.BarraTittle.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTittle.Location = new System.Drawing.Point(0, 0);
            this.BarraTittle.Name = "BarraTittle";
            this.BarraTittle.Size = new System.Drawing.Size(1189, 35);
            this.BarraTittle.TabIndex = 6;
            this.BarraTittle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTittle_MouseDown);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panelMenu.Controls.Add(this.btnSesion);
            this.panelMenu.Controls.Add(this.panel3);
            this.panelMenu.Controls.Add(this.btnSettings);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Controls.Add(this.btnStatics);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.btnEstacionamiento);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 35);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(66, 653);
            this.panelMenu.TabIndex = 7;
            // 
            // panelCont
            // 
            this.panelCont.Controls.Add(this.label1);
            this.panelCont.Controls.Add(this.labelEspacios);
            this.panelCont.Controls.Add(this.labelCounterCar);
            this.panelCont.Controls.Add(this.labelCom);
            this.panelCont.Controls.Add(this.labelSimpleEspacios);
            this.panelCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCont.Location = new System.Drawing.Point(66, 35);
            this.panelCont.Name = "panelCont";
            this.panelCont.Size = new System.Drawing.Size(1123, 653);
            this.panelCont.TabIndex = 8;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1153, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMax.Image = ((System.Drawing.Image)(resources.GetObject("btnMax.Image")));
            this.btnMax.Location = new System.Drawing.Point(1113, 7);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(20, 20);
            this.btnMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMax.TabIndex = 2;
            this.btnMax.TabStop = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMinimiza
            // 
            this.btnMinimiza.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimiza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimiza.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimiza.Image")));
            this.btnMinimiza.Location = new System.Drawing.Point(1072, 7);
            this.btnMinimiza.Name = "btnMinimiza";
            this.btnMinimiza.Size = new System.Drawing.Size(20, 20);
            this.btnMinimiza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimiza.TabIndex = 3;
            this.btnMinimiza.TabStop = false;
            this.btnMinimiza.Click += new System.EventHandler(this.btnMinimiza_Click);
            // 
            // btnMax2
            // 
            this.btnMax2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMax2.Image = ((System.Drawing.Image)(resources.GetObject("btnMax2.Image")));
            this.btnMax2.Location = new System.Drawing.Point(1113, 7);
            this.btnMax2.Name = "btnMax2";
            this.btnMax2.Size = new System.Drawing.Size(20, 20);
            this.btnMax2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMax2.TabIndex = 4;
            this.btnMax2.TabStop = false;
            this.btnMax2.Visible = false;
            this.btnMax2.Click += new System.EventHandler(this.btnMax2_Click);
            // 
            // btnEstacionamiento
            // 
            this.btnEstacionamiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnEstacionamiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEstacionamiento.FlatAppearance.BorderSize = 0;
            this.btnEstacionamiento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.btnEstacionamiento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.btnEstacionamiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstacionamiento.Font = new System.Drawing.Font("Montserrat", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstacionamiento.ForeColor = System.Drawing.Color.White;
            this.btnEstacionamiento.Location = new System.Drawing.Point(2, 287);
            this.btnEstacionamiento.Name = "btnEstacionamiento";
            this.btnEstacionamiento.Size = new System.Drawing.Size(66, 71);
            this.btnEstacionamiento.TabIndex = 0;
            this.btnEstacionamiento.Text = "E";
            this.btnEstacionamiento.UseVisualStyleBackColor = false;
            this.btnEstacionamiento.Click += new System.EventHandler(this.btnEstacionamiento_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.panel1.Location = new System.Drawing.Point(0, 287);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(8, 71);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.panel2.Location = new System.Drawing.Point(-2, 414);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 71);
            this.panel2.TabIndex = 1;
            // 
            // btnStatics
            // 
            this.btnStatics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnStatics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStatics.FlatAppearance.BorderSize = 0;
            this.btnStatics.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.btnStatics.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.btnStatics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatics.Font = new System.Drawing.Font("Montserrat", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatics.ForeColor = System.Drawing.Color.White;
            this.btnStatics.Image = ((System.Drawing.Image)(resources.GetObject("btnStatics.Image")));
            this.btnStatics.Location = new System.Drawing.Point(0, 414);
            this.btnStatics.Name = "btnStatics";
            this.btnStatics.Size = new System.Drawing.Size(66, 71);
            this.btnStatics.TabIndex = 2;
            this.btnStatics.UseVisualStyleBackColor = false;
            this.btnStatics.Click += new System.EventHandler(this.btnStatics_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.panel3.Location = new System.Drawing.Point(-2, 537);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(8, 71);
            this.panel3.TabIndex = 3;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Montserrat", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.Location = new System.Drawing.Point(0, 537);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(66, 71);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnSesion
            // 
            this.btnSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSesion.FlatAppearance.BorderSize = 0;
            this.btnSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.btnSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.btnSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSesion.Font = new System.Drawing.Font("Montserrat", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSesion.ForeColor = System.Drawing.Color.White;
            this.btnSesion.Image = ((System.Drawing.Image)(resources.GetObject("btnSesion.Image")));
            this.btnSesion.Location = new System.Drawing.Point(0, 36);
            this.btnSesion.Name = "btnSesion";
            this.btnSesion.Size = new System.Drawing.Size(66, 71);
            this.btnSesion.TabIndex = 5;
            this.btnSesion.UseVisualStyleBackColor = false;
            this.btnSesion.Click += new System.EventHandler(this.btnSesion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Espacios:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1189, 688);
            this.Controls.Add(this.panelCont);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.BarraTittle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BarraTittle.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelCont.ResumeLayout(false);
            this.panelCont.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimiza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelCom;
        private System.Windows.Forms.Label labelCounterCar;
        private System.Windows.Forms.Label labelSimpleEspacios;
        private System.Windows.Forms.Label labelEspacios;
        private System.Windows.Forms.Panel BarraTittle;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelCont;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btnMinimiza;
        private System.Windows.Forms.PictureBox btnMax;
        private System.Windows.Forms.PictureBox btnMax2;
        private System.Windows.Forms.Button btnEstacionamiento;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnStatics;
        private System.Windows.Forms.Button btnSesion;
        private System.Windows.Forms.Label label1;
    }
}

