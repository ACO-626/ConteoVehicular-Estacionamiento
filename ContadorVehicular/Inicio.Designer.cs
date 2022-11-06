
namespace ContadorVehicular
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.textBoxClave = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(320, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(271, 262);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsuario.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxUsuario.Location = new System.Drawing.Point(320, 318);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(271, 35);
            this.textBoxUsuario.TabIndex = 11;
            this.textBoxUsuario.Text = "Número trabajador";
            this.textBoxUsuario.Enter += new System.EventHandler(this.textBoxUsuario_Enter);
            this.textBoxUsuario.Leave += new System.EventHandler(this.textBoxUsuario_Leave);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciar.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(347, 436);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(193, 45);
            this.btnIniciar.TabIndex = 12;
            this.btnIniciar.Text = "IDENTIFICARSE";
            this.btnIniciar.UseVisualStyleBackColor = false;
            // 
            // textBoxClave
            // 
            this.textBoxClave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxClave.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxClave.Location = new System.Drawing.Point(320, 373);
            this.textBoxClave.Name = "textBoxClave";
            this.textBoxClave.Size = new System.Drawing.Size(271, 35);
            this.textBoxClave.TabIndex = 13;
            this.textBoxClave.Text = "Clave";
            this.textBoxClave.Enter += new System.EventHandler(this.textBoxClave_Enter);
            this.textBoxClave.Leave += new System.EventHandler(this.textBoxClave_Leave);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(895, 567);
            this.Controls.Add(this.textBoxClave);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio";
            this.Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.TextBox textBoxClave;
    }
}