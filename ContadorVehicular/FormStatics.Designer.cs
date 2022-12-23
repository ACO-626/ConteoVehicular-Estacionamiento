
namespace ContadorVehicular
{
    partial class FormStatics
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.simpleLabelGraficaAflu = new System.Windows.Forms.Label();
            this.chartAfluencia = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.simpleLabelTablaEve = new System.Windows.Forms.Label();
            this.tablaRegistro = new System.Windows.Forms.DataGridView();
            this.simpleLabelRestantes = new System.Windows.Forms.Label();
            this.simpleLabelVehiculos = new System.Windows.Forms.Label();
            this.labelRestantes = new System.Windows.Forms.Label();
            this.labelEstacionados = new System.Windows.Forms.Label();
            this.carIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estacionadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.horaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablaRegistroBindingSource = new System.Windows.Forms.BindingSource(this.components);

            ((System.ComponentModel.ISupportInitialize)(this.chartAfluencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaRegistro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaRegistroBindingSource)).BeginInit();
        
            this.SuspendLayout();
            // 
            // simpleLabelGraficaAflu
            // 
            this.simpleLabelGraficaAflu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.simpleLabelGraficaAflu.AutoSize = true;
            this.simpleLabelGraficaAflu.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleLabelGraficaAflu.Location = new System.Drawing.Point(14, 125);
            this.simpleLabelGraficaAflu.Name = "simpleLabelGraficaAflu";
            this.simpleLabelGraficaAflu.Size = new System.Drawing.Size(253, 27);
            this.simpleLabelGraficaAflu.TabIndex = 15;
            this.simpleLabelGraficaAflu.Text = "Gráfica de afluencia";
            // 
            // chartAfluencia
            // 
            this.chartAfluencia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chartAfluencia.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.Name = "ChartArea1";
            this.chartAfluencia.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartAfluencia.Legends.Add(legend1);
            this.chartAfluencia.Location = new System.Drawing.Point(12, 155);
            this.chartAfluencia.Name = "chartAfluencia";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartAfluencia.Series.Add(series1);
            this.chartAfluencia.Size = new System.Drawing.Size(621, 374);
            this.chartAfluencia.TabIndex = 16;
            this.chartAfluencia.Text = "chart1";
            // 
            // simpleLabelTablaEve
            // 
            this.simpleLabelTablaEve.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.simpleLabelTablaEve.AutoSize = true;
            this.simpleLabelTablaEve.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleLabelTablaEve.Location = new System.Drawing.Point(646, 125);
            this.simpleLabelTablaEve.Name = "simpleLabelTablaEve";
            this.simpleLabelTablaEve.Size = new System.Drawing.Size(204, 27);
            this.simpleLabelTablaEve.TabIndex = 17;
            this.simpleLabelTablaEve.Text = "Tabla de evento";
            // 
            // tablaRegistro
            // 
            this.tablaRegistro.AllowUserToAddRows = false;
            this.tablaRegistro.AllowUserToDeleteRows = false;
            this.tablaRegistro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tablaRegistro.AutoGenerateColumns = false;
            this.tablaRegistro.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tablaRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaRegistro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.carIDDataGridViewTextBoxColumn,
            this.estacionadoDataGridViewCheckBoxColumn,
            this.horaDataGridViewTextBoxColumn});
            this.tablaRegistro.DataSource = this.tablaRegistroBindingSource;
            this.tablaRegistro.Location = new System.Drawing.Point(651, 155);
            this.tablaRegistro.Name = "tablaRegistro";
            this.tablaRegistro.ReadOnly = true;
            this.tablaRegistro.Size = new System.Drawing.Size(334, 374);
            this.tablaRegistro.TabIndex = 18;
            // 
            // simpleLabelRestantes
            // 
            this.simpleLabelRestantes.AutoSize = true;
            this.simpleLabelRestantes.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleLabelRestantes.Location = new System.Drawing.Point(65, 9);
            this.simpleLabelRestantes.Name = "simpleLabelRestantes";
            this.simpleLabelRestantes.Size = new System.Drawing.Size(202, 24);
            this.simpleLabelRestantes.TabIndex = 19;
            this.simpleLabelRestantes.Text = "Espacios restantes:";
            // 
            // simpleLabelVehiculos
            // 
            this.simpleLabelVehiculos.AutoSize = true;
            this.simpleLabelVehiculos.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleLabelVehiculos.Location = new System.Drawing.Point(65, 41);
            this.simpleLabelVehiculos.Name = "simpleLabelVehiculos";
            this.simpleLabelVehiculos.Size = new System.Drawing.Size(251, 24);
            this.simpleLabelVehiculos.TabIndex = 20;
            this.simpleLabelVehiculos.Text = "Vehículos estacionados:";
            // 
            // labelRestantes
            // 
            this.labelRestantes.AutoSize = true;
            this.labelRestantes.Font = new System.Drawing.Font("Montserrat", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRestantes.Location = new System.Drawing.Point(261, 3);
            this.labelRestantes.Name = "labelRestantes";
            this.labelRestantes.Size = new System.Drawing.Size(73, 38);
            this.labelRestantes.TabIndex = 21;
            this.labelRestantes.Text = "274";
            // 
            // labelEstacionados
            // 
            this.labelEstacionados.AutoSize = true;
            this.labelEstacionados.Font = new System.Drawing.Font("Montserrat", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstacionados.Location = new System.Drawing.Point(312, 35);
            this.labelEstacionados.Name = "labelEstacionados";
            this.labelEstacionados.Size = new System.Drawing.Size(39, 38);
            this.labelEstacionados.TabIndex = 22;
            this.labelEstacionados.Text = "0";
            // 
            // carIDDataGridViewTextBoxColumn
            // 
            this.carIDDataGridViewTextBoxColumn.DataPropertyName = "CarID";
            this.carIDDataGridViewTextBoxColumn.HeaderText = "CarID";
            this.carIDDataGridViewTextBoxColumn.Name = "carIDDataGridViewTextBoxColumn";
            this.carIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estacionadoDataGridViewCheckBoxColumn
            // 
            this.estacionadoDataGridViewCheckBoxColumn.DataPropertyName = "Estacionado";
            this.estacionadoDataGridViewCheckBoxColumn.HeaderText = "Estacionado";
            this.estacionadoDataGridViewCheckBoxColumn.Name = "estacionadoDataGridViewCheckBoxColumn";
            this.estacionadoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // horaDataGridViewTextBoxColumn
            // 
            this.horaDataGridViewTextBoxColumn.DataPropertyName = "Hora";
            this.horaDataGridViewTextBoxColumn.HeaderText = "Hora";
            this.horaDataGridViewTextBoxColumn.Name = "horaDataGridViewTextBoxColumn";
            this.horaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tablaRegistroBindingSource
            // 
            this.tablaRegistroBindingSource.DataMember = "TablaRegistro";
         
            // 
            // dB_EstacionamientoDataSet
            // 

            // 
           
            // FormStatics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1036, 656);
            this.Controls.Add(this.labelEstacionados);
            this.Controls.Add(this.labelRestantes);
            this.Controls.Add(this.simpleLabelVehiculos);
            this.Controls.Add(this.simpleLabelRestantes);
            this.Controls.Add(this.tablaRegistro);
            this.Controls.Add(this.simpleLabelTablaEve);
            this.Controls.Add(this.chartAfluencia);
            this.Controls.Add(this.simpleLabelGraficaAflu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormStatics";
            this.Text = "FormStatics";
            this.Load += new System.EventHandler(this.FormStatics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartAfluencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaRegistro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaRegistroBindingSource)).EndInit();
          
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label simpleLabelGraficaAflu;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAfluencia;
        private System.Windows.Forms.Label simpleLabelTablaEve;
        private System.Windows.Forms.DataGridView tablaRegistro;
        private System.Windows.Forms.Label simpleLabelRestantes;
        private System.Windows.Forms.Label simpleLabelVehiculos;
        private System.Windows.Forms.Label labelRestantes;
        private System.Windows.Forms.Label labelEstacionados;
        private System.Windows.Forms.BindingSource tablaRegistroBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn carIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estacionadoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
    }
}