
namespace ContadorVehicular
{
    partial class FormEstacionamiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEstacionamiento));
            this.SimpleLabelRest = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelEspacios = new System.Windows.Forms.Label();
            this.labelIngresos = new System.Windows.Forms.Label();
            this.SimpleLabelEstacionados = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // SimpleLabelRest
            // 
            this.SimpleLabelRest.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SimpleLabelRest.AutoSize = true;
            this.SimpleLabelRest.Font = new System.Drawing.Font("Montserrat", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimpleLabelRest.Location = new System.Drawing.Point(63, 426);
            this.SimpleLabelRest.Name = "SimpleLabelRest";
            this.SimpleLabelRest.Size = new System.Drawing.Size(398, 49);
            this.SimpleLabelRest.TabIndex = 12;
            this.SimpleLabelRest.Text = "Espacios restantes";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.panel2.Location = new System.Drawing.Point(474, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(23, 235);
            this.panel2.TabIndex = 10;
            // 
            // labelEspacios
            // 
            this.labelEspacios.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelEspacios.AutoSize = true;
            this.labelEspacios.Font = new System.Drawing.Font("Montserrat", 150F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEspacios.Location = new System.Drawing.Point(50, 131);
            this.labelEspacios.Name = "labelEspacios";
            this.labelEspacios.Size = new System.Drawing.Size(447, 244);
            this.labelEspacios.TabIndex = 11;
            this.labelEspacios.Text = "274";
            this.labelEspacios.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelIngresos
            // 
            this.labelIngresos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelIngresos.AutoSize = true;
            this.labelIngresos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.labelIngresos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelIngresos.Font = new System.Drawing.Font("Montserrat", 75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIngresos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelIngresos.Location = new System.Drawing.Point(635, 181);
            this.labelIngresos.Name = "labelIngresos";
            this.labelIngresos.Size = new System.Drawing.Size(262, 122);
            this.labelIngresos.TabIndex = 13;
            this.labelIngresos.Text = "000";
            this.labelIngresos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SimpleLabelEstacionados
            // 
            this.SimpleLabelEstacionados.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SimpleLabelEstacionados.AutoSize = true;
            this.SimpleLabelEstacionados.Font = new System.Drawing.Font("Montserrat", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimpleLabelEstacionados.Location = new System.Drawing.Point(577, 426);
            this.SimpleLabelEstacionados.Name = "SimpleLabelEstacionados";
            this.SimpleLabelEstacionados.Size = new System.Drawing.Size(496, 49);
            this.SimpleLabelEstacionados.TabIndex = 14;
            this.SimpleLabelEstacionados.Text = "Vehiculos estacionados";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(527, 131);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(584, 315);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.panel1.Location = new System.Drawing.Point(32, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(23, 235);
            this.panel1.TabIndex = 11;
            // 
            // FormEstacionamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1123, 592);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SimpleLabelEstacionados);
            this.Controls.Add(this.labelIngresos);
            this.Controls.Add(this.SimpleLabelRest);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelEspacios);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEstacionamiento";
            this.Text = "FormEstacionamiento";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SimpleLabelRest;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelEspacios;
        private System.Windows.Forms.Label labelIngresos;
        private System.Windows.Forms.Label SimpleLabelEstacionados;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
    }
}