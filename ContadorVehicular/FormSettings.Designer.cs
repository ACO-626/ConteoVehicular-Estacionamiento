
namespace ContadorVehicular
{
    partial class FormSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SimpleLbCapa = new System.Windows.Forms.Label();
            this.btnDefinir = new System.Windows.Forms.Button();
            this.textBoxCapacidad = new System.Windows.Forms.TextBox();
            this.lbLinkAyuda = new System.Windows.Forms.LinkLabel();
            this.SimplelbCapacidadAct = new System.Windows.Forms.Label();
            this.lbCapacity = new System.Windows.Forms.Label();
            this.lbSimpleBy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SimpleLbCapa
            // 
            this.SimpleLbCapa.AutoSize = true;
            this.SimpleLbCapa.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimpleLbCapa.Location = new System.Drawing.Point(98, 91);
            this.SimpleLbCapa.Name = "SimpleLbCapa";
            this.SimpleLbCapa.Size = new System.Drawing.Size(259, 27);
            this.SimpleLbCapa.TabIndex = 25;
            this.SimpleLbCapa.Text = "Modificar capacidad";
            // 
            // btnDefinir
            // 
            this.btnDefinir.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnDefinir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDefinir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDefinir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDefinir.Location = new System.Drawing.Point(103, 198);
            this.btnDefinir.Name = "btnDefinir";
            this.btnDefinir.Size = new System.Drawing.Size(140, 45);
            this.btnDefinir.TabIndex = 26;
            this.btnDefinir.Text = "Definir";
            this.btnDefinir.UseVisualStyleBackColor = false;
            this.btnDefinir.Click += new System.EventHandler(this.btnDefinir_Click);
            // 
            // textBoxCapacidad
            // 
            this.textBoxCapacidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCapacidad.Location = new System.Drawing.Point(134, 140);
            this.textBoxCapacidad.Name = "textBoxCapacidad";
            this.textBoxCapacidad.Size = new System.Drawing.Size(316, 35);
            this.textBoxCapacidad.TabIndex = 27;
            // 
            // lbLinkAyuda
            // 
            this.lbLinkAyuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbLinkAyuda.AutoSize = true;
            this.lbLinkAyuda.Font = new System.Drawing.Font("SansSerif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lbLinkAyuda.Location = new System.Drawing.Point(22, 511);
            this.lbLinkAyuda.Name = "lbLinkAyuda";
            this.lbLinkAyuda.Size = new System.Drawing.Size(54, 12);
            this.lbLinkAyuda.TabIndex = 29;
            this.lbLinkAyuda.TabStop = true;
            this.lbLinkAyuda.Text = "|I| AYUDA";
            this.lbLinkAyuda.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbLinkAyuda_LinkClicked);
            // 
            // SimplelbCapacidadAct
            // 
            this.SimplelbCapacidadAct.AutoSize = true;
            this.SimplelbCapacidadAct.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimplelbCapacidadAct.Location = new System.Drawing.Point(660, 91);
            this.SimplelbCapacidadAct.Name = "SimplelbCapacidadAct";
            this.SimplelbCapacidadAct.Size = new System.Drawing.Size(221, 27);
            this.SimplelbCapacidadAct.TabIndex = 30;
            this.SimplelbCapacidadAct.Text = "Capacidad actual";
            // 
            // lbCapacity
            // 
            this.lbCapacity.AutoSize = true;
            this.lbCapacity.Font = new System.Drawing.Font("Montserrat", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCapacity.Location = new System.Drawing.Point(575, 140);
            this.lbCapacity.Name = "lbCapacity";
            this.lbCapacity.Size = new System.Drawing.Size(415, 53);
            this.lbCapacity.TabIndex = 31;
            this.lbCapacity.Text = "Capacidad actual";
            // 
            // lbSimpleBy
            // 
            this.lbSimpleBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSimpleBy.AutoSize = true;
            this.lbSimpleBy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSimpleBy.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSimpleBy.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lbSimpleBy.Location = new System.Drawing.Point(790, 532);
            this.lbSimpleBy.Name = "lbSimpleBy";
            this.lbSimpleBy.Size = new System.Drawing.Size(62, 18);
            this.lbSimpleBy.TabIndex = 32;
            this.lbSimpleBy.Text = "By ACO";
            this.lbSimpleBy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbSimpleBy.Click += new System.EventHandler(this.lbSimpleBy_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 559);
            this.Controls.Add(this.lbSimpleBy);
            this.Controls.Add(this.lbCapacity);
            this.Controls.Add(this.SimplelbCapacidadAct);
            this.Controls.Add(this.lbLinkAyuda);
            this.Controls.Add(this.textBoxCapacidad);
            this.Controls.Add(this.btnDefinir);
            this.Controls.Add(this.SimpleLbCapa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSettings";
            this.Text = "FormSettings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label SimpleLbCapa;
        private System.Windows.Forms.Button btnDefinir;
        private System.Windows.Forms.TextBox textBoxCapacidad;
        private System.Windows.Forms.LinkLabel lbLinkAyuda;
        private System.Windows.Forms.Label SimplelbCapacidadAct;
        private System.Windows.Forms.Label lbCapacity;
        private System.Windows.Forms.Label lbSimpleBy;
    }
}