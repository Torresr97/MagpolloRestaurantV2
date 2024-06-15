
namespace AppTRchicken.Vista.Reportes
{
    partial class ReportededuccionxempleadoVista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportededuccionxempleadoVista));
            this.dthasta = new System.Windows.Forms.DateTimePicker();
            this.dtpmesyano = new System.Windows.Forms.DateTimePicker();
            this.cbBuscar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbempleado = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgreportededuccion = new System.Windows.Forms.DataGridView();
            this.iddeduccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroplanilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deudccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnexportar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxestadodeduccion = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgreportededuccion)).BeginInit();
            this.SuspendLayout();
            // 
            // dthasta
            // 
            this.dthasta.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.dthasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dthasta.Location = new System.Drawing.Point(648, 21);
            this.dthasta.Name = "dthasta";
            this.dthasta.Size = new System.Drawing.Size(219, 34);
            this.dthasta.TabIndex = 114;
            // 
            // dtpmesyano
            // 
            this.dtpmesyano.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.dtpmesyano.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpmesyano.Location = new System.Drawing.Point(399, 21);
            this.dtpmesyano.Name = "dtpmesyano";
            this.dtpmesyano.Size = new System.Drawing.Size(219, 34);
            this.dtpmesyano.TabIndex = 113;
            // 
            // cbBuscar
            // 
            this.cbBuscar.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.cbBuscar.FormattingEnabled = true;
            this.cbBuscar.Items.AddRange(new object[] {
            "Dia",
            "Mes",
            "Año",
            "Desde - Hasta"});
            this.cbBuscar.Location = new System.Drawing.Point(194, 20);
            this.cbBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbBuscar.Name = "cbBuscar";
            this.cbBuscar.Size = new System.Drawing.Size(199, 34);
            this.cbBuscar.TabIndex = 112;
            this.cbBuscar.SelectedIndexChanged += new System.EventHandler(this.cbBuscar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 27);
            this.label1.TabIndex = 111;
            this.label1.Text = "Buscar Por:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 27);
            this.label3.TabIndex = 117;
            this.label3.Text = "Empleado";
            // 
            // cbempleado
            // 
            this.cbempleado.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.cbempleado.FormattingEnabled = true;
            this.cbempleado.Items.AddRange(new object[] {
            "Todos"});
            this.cbempleado.Location = new System.Drawing.Point(194, 72);
            this.cbempleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbempleado.Name = "cbempleado";
            this.cbempleado.Size = new System.Drawing.Size(520, 34);
            this.cbempleado.TabIndex = 116;
            // 
            // btnBuscar
            // 
            this.btnBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.btnBuscar.Location = new System.Drawing.Point(726, 78);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(141, 35);
            this.btnBuscar.TabIndex = 115;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txttotal
            // 
            this.txttotal.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txttotal.Location = new System.Drawing.Point(194, 167);
            this.txttotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(184, 34);
            this.txttotal.TabIndex = 119;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 27);
            this.label4.TabIndex = 118;
            this.label4.Text = "Total";
            // 
            // dgreportededuccion
            // 
            this.dgreportededuccion.AllowUserToAddRows = false;
            this.dgreportededuccion.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgreportededuccion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgreportededuccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgreportededuccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddeduccion,
            this.numeroplanilla,
            this.deudccion,
            this.total,
            this.fecha,
            this.estado});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgreportededuccion.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgreportededuccion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgreportededuccion.Location = new System.Drawing.Point(0, 377);
            this.dgreportededuccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgreportededuccion.Name = "dgreportededuccion";
            this.dgreportededuccion.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgreportededuccion.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgreportededuccion.RowHeadersVisible = false;
            this.dgreportededuccion.RowHeadersWidth = 51;
            this.dgreportededuccion.RowTemplate.Height = 24;
            this.dgreportededuccion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgreportededuccion.Size = new System.Drawing.Size(1286, 406);
            this.dgreportededuccion.TabIndex = 120;
            // 
            // iddeduccion
            // 
            this.iddeduccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iddeduccion.HeaderText = "ID Deduccion";
            this.iddeduccion.MinimumWidth = 6;
            this.iddeduccion.Name = "iddeduccion";
            this.iddeduccion.ReadOnly = true;
            // 
            // numeroplanilla
            // 
            this.numeroplanilla.HeaderText = "Cod. Planilla";
            this.numeroplanilla.MinimumWidth = 6;
            this.numeroplanilla.Name = "numeroplanilla";
            this.numeroplanilla.ReadOnly = true;
            this.numeroplanilla.Width = 125;
            // 
            // deudccion
            // 
            this.deudccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.deudccion.HeaderText = "Deduccion";
            this.deudccion.MinimumWidth = 6;
            this.deudccion.Name = "deudccion";
            this.deudccion.ReadOnly = true;
            // 
            // total
            // 
            this.total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.total.HeaderText = "Total";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fecha.HeaderText = "Fecha";
            this.fecha.MinimumWidth = 6;
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.MinimumWidth = 6;
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Width = 125;
            // 
            // btnexportar
            // 
            this.btnexportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnexportar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnexportar.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexportar.Image = ((System.Drawing.Image)(resources.GetObject("btnexportar.Image")));
            this.btnexportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexportar.Location = new System.Drawing.Point(1049, 335);
            this.btnexportar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnexportar.Name = "btnexportar";
            this.btnexportar.Size = new System.Drawing.Size(116, 38);
            this.btnexportar.TabIndex = 121;
            this.btnexportar.Text = "Exportar";
            this.btnexportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnexportar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 27);
            this.label2.TabIndex = 122;
            this.label2.Text = "Estado";
            // 
            // cbxestadodeduccion
            // 
            this.cbxestadodeduccion.AutoCompleteCustomSource.AddRange(new string[] {
            "Pendientes",
            "Cobradas"});
            this.cbxestadodeduccion.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.cbxestadodeduccion.FormattingEnabled = true;
            this.cbxestadodeduccion.Items.AddRange(new object[] {
            "Pendientes",
            "Cobradas"});
            this.cbxestadodeduccion.Location = new System.Drawing.Point(194, 121);
            this.cbxestadodeduccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxestadodeduccion.Name = "cbxestadodeduccion";
            this.cbxestadodeduccion.Size = new System.Drawing.Size(184, 34);
            this.cbxestadodeduccion.TabIndex = 123;
            // 
            // Reportededuccionxempleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1286, 783);
            this.Controls.Add(this.cbxestadodeduccion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnexportar);
            this.Controls.Add(this.dgreportededuccion);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbempleado);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dthasta);
            this.Controls.Add(this.dtpmesyano);
            this.Controls.Add(this.cbBuscar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Reportededuccionxempleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Reportededuccionxempleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgreportededuccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dthasta;
        private System.Windows.Forms.DateTimePicker dtpmesyano;
        private System.Windows.Forms.ComboBox cbBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbempleado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgreportededuccion;
        private System.Windows.Forms.Button btnexportar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxestadodeduccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddeduccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroplanilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn deudccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    }
}