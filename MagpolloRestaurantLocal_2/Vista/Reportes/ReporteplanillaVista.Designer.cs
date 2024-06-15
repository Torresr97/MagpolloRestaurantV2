
namespace AppTRchicken.Vista.Reportes
{
    partial class ReporteplanillaVista
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteplanillaVista));
            this.label3 = new System.Windows.Forms.Label();
            this.cbempleado = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dthasta = new System.Windows.Forms.DateTimePicker();
            this.dtpmesyano = new System.Windows.Forms.DateTimePicker();
            this.cbBuscar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgreporteplanilla = new System.Windows.Forms.DataGridView();
            this.idplanilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaemision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sueldobase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingresoextra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deducciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalpagado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnexportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgreporteplanilla)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 27);
            this.label3.TabIndex = 124;
            this.label3.Text = "Empleado";
            // 
            // cbempleado
            // 
            this.cbempleado.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.cbempleado.FormattingEnabled = true;
            this.cbempleado.Items.AddRange(new object[] {
            "Todos"});
            this.cbempleado.Location = new System.Drawing.Point(187, 74);
            this.cbempleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbempleado.Name = "cbempleado";
            this.cbempleado.Size = new System.Drawing.Size(520, 34);
            this.cbempleado.TabIndex = 123;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.btnBuscar.Location = new System.Drawing.Point(719, 81);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(141, 35);
            this.btnBuscar.TabIndex = 122;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dthasta
            // 
            this.dthasta.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.dthasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dthasta.Location = new System.Drawing.Point(641, 23);
            this.dthasta.Name = "dthasta";
            this.dthasta.Size = new System.Drawing.Size(219, 34);
            this.dthasta.TabIndex = 121;
            // 
            // dtpmesyano
            // 
            this.dtpmesyano.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.dtpmesyano.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpmesyano.Location = new System.Drawing.Point(392, 23);
            this.dtpmesyano.Name = "dtpmesyano";
            this.dtpmesyano.Size = new System.Drawing.Size(219, 34);
            this.dtpmesyano.TabIndex = 120;
            // 
            // cbBuscar
            // 
            this.cbBuscar.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.cbBuscar.FormattingEnabled = true;
            this.cbBuscar.Items.AddRange(new object[] {
            "Mes",
            "Año"});
            this.cbBuscar.Location = new System.Drawing.Point(187, 22);
            this.cbBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbBuscar.Name = "cbBuscar";
            this.cbBuscar.Size = new System.Drawing.Size(199, 34);
            this.cbBuscar.TabIndex = 119;
            this.cbBuscar.SelectedIndexChanged += new System.EventHandler(this.cbBuscar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 27);
            this.label1.TabIndex = 118;
            this.label1.Text = "Buscar Por:";
            // 
            // dgreporteplanilla
            // 
            this.dgreporteplanilla.AllowUserToAddRows = false;
            this.dgreporteplanilla.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgreporteplanilla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgreporteplanilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgreporteplanilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idplanilla,
            this.fechaemision,
            this.desde,
            this.hasta,
            this.sueldobase,
            this.ingresoextra,
            this.deducciones,
            this.totalpagado});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgreporteplanilla.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgreporteplanilla.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgreporteplanilla.Location = new System.Drawing.Point(0, 377);
            this.dgreporteplanilla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgreporteplanilla.Name = "dgreporteplanilla";
            this.dgreporteplanilla.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgreporteplanilla.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgreporteplanilla.RowHeadersVisible = false;
            this.dgreporteplanilla.RowHeadersWidth = 51;
            this.dgreporteplanilla.RowTemplate.Height = 24;
            this.dgreporteplanilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgreporteplanilla.Size = new System.Drawing.Size(1286, 406);
            this.dgreporteplanilla.TabIndex = 125;
            // 
            // idplanilla
            // 
            this.idplanilla.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idplanilla.HeaderText = "Cod. Planilla";
            this.idplanilla.MinimumWidth = 6;
            this.idplanilla.Name = "idplanilla";
            this.idplanilla.ReadOnly = true;
            // 
            // fechaemision
            // 
            this.fechaemision.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fechaemision.HeaderText = "Fecha Emision";
            this.fechaemision.MinimumWidth = 6;
            this.fechaemision.Name = "fechaemision";
            this.fechaemision.ReadOnly = true;
            // 
            // desde
            // 
            this.desde.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.desde.HeaderText = "Desde";
            this.desde.MinimumWidth = 6;
            this.desde.Name = "desde";
            this.desde.ReadOnly = true;
            // 
            // hasta
            // 
            this.hasta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hasta.HeaderText = "Hasta";
            this.hasta.MinimumWidth = 6;
            this.hasta.Name = "hasta";
            this.hasta.ReadOnly = true;
            // 
            // sueldobase
            // 
            this.sueldobase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sueldobase.HeaderText = "Sueldo Base";
            this.sueldobase.MinimumWidth = 6;
            this.sueldobase.Name = "sueldobase";
            this.sueldobase.ReadOnly = true;
            // 
            // ingresoextra
            // 
            this.ingresoextra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ingresoextra.HeaderText = "Ingreso Extra";
            this.ingresoextra.MinimumWidth = 6;
            this.ingresoextra.Name = "ingresoextra";
            this.ingresoextra.ReadOnly = true;
            // 
            // deducciones
            // 
            this.deducciones.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.deducciones.HeaderText = "Deducciones";
            this.deducciones.MinimumWidth = 6;
            this.deducciones.Name = "deducciones";
            this.deducciones.ReadOnly = true;
            // 
            // totalpagado
            // 
            this.totalpagado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalpagado.HeaderText = "Total Pagado";
            this.totalpagado.MinimumWidth = 6;
            this.totalpagado.Name = "totalpagado";
            this.totalpagado.ReadOnly = true;
            // 
            // btnexportar
            // 
            this.btnexportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnexportar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnexportar.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexportar.Image = ((System.Drawing.Image)(resources.GetObject("btnexportar.Image")));
            this.btnexportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexportar.Location = new System.Drawing.Point(1029, 335);
            this.btnexportar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnexportar.Name = "btnexportar";
            this.btnexportar.Size = new System.Drawing.Size(116, 38);
            this.btnexportar.TabIndex = 126;
            this.btnexportar.Text = "Exportar";
            this.btnexportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnexportar.UseVisualStyleBackColor = false;
            // 
            // Reporteplanilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1286, 783);
            this.Controls.Add(this.btnexportar);
            this.Controls.Add(this.dgreporteplanilla);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbempleado);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dthasta);
            this.Controls.Add(this.dtpmesyano);
            this.Controls.Add(this.cbBuscar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Reporteplanilla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Reporteplanilla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgreporteplanilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbempleado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker dthasta;
        private System.Windows.Forms.DateTimePicker dtpmesyano;
        private System.Windows.Forms.ComboBox cbBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgreporteplanilla;
        private System.Windows.Forms.Button btnexportar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idplanilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaemision;
        private System.Windows.Forms.DataGridViewTextBoxColumn desde;
        private System.Windows.Forms.DataGridViewTextBoxColumn hasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn sueldobase;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingresoextra;
        private System.Windows.Forms.DataGridViewTextBoxColumn deducciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalpagado;
    }
}