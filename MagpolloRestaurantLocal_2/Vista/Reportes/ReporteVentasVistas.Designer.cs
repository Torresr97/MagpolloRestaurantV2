
namespace AppTRchicken.Vista
{
    partial class ReporteVentasVistas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteVentasVistas));
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtisv = new System.Windows.Forms.TextBox();
            this.txtsubtotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dthasta = new System.Windows.Forms.DateTimePicker();
            this.dtpmesyano = new System.Windows.Forms.DateTimePicker();
            this.cbBventas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgreporteventas = new System.Windows.Forms.DataGridView();
            this.idfactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facturacai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipopago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxfacturas = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtefectivo = new System.Windows.Forms.TextBox();
            this.txttarjeta = new System.Windows.Forms.TextBox();
            this.btnexportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgreporteventas)).BeginInit();
            this.SuspendLayout();
            // 
            // txttotal
            // 
            this.txttotal.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txttotal.Location = new System.Drawing.Point(685, 139);
            this.txttotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(199, 34);
            this.txttotal.TabIndex = 112;
            // 
            // txtisv
            // 
            this.txtisv.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txtisv.Location = new System.Drawing.Point(401, 139);
            this.txtisv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtisv.Name = "txtisv";
            this.txtisv.ReadOnly = true;
            this.txtisv.Size = new System.Drawing.Size(199, 34);
            this.txtisv.TabIndex = 111;
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txtsubtotal.Location = new System.Drawing.Point(133, 135);
            this.txtsubtotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.ReadOnly = true;
            this.txtsubtotal.Size = new System.Drawing.Size(199, 34);
            this.txtsubtotal.TabIndex = 110;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(611, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 27);
            this.label4.TabIndex = 109;
            this.label4.Text = "Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(341, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 27);
            this.label3.TabIndex = 108;
            this.label3.Text = "ISV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 27);
            this.label2.TabIndex = 107;
            this.label2.Text = "SubTotal";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.btnBuscar.Location = new System.Drawing.Point(899, 18);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(141, 34);
            this.btnBuscar.TabIndex = 106;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dthasta
            // 
            this.dthasta.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.dthasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dthasta.Location = new System.Drawing.Point(633, 17);
            this.dthasta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dthasta.Name = "dthasta";
            this.dthasta.Size = new System.Drawing.Size(219, 34);
            this.dthasta.TabIndex = 105;
            // 
            // dtpmesyano
            // 
            this.dtpmesyano.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.dtpmesyano.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpmesyano.Location = new System.Drawing.Point(384, 17);
            this.dtpmesyano.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpmesyano.Name = "dtpmesyano";
            this.dtpmesyano.Size = new System.Drawing.Size(219, 34);
            this.dtpmesyano.TabIndex = 104;
            // 
            // cbBventas
            // 
            this.cbBventas.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.cbBventas.FormattingEnabled = true;
            this.cbBventas.Items.AddRange(new object[] {
            "Dia",
            "Mes",
            "Año",
            "Desde - Hasta"});
            this.cbBventas.Location = new System.Drawing.Point(179, 16);
            this.cbBventas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbBventas.Name = "cbBventas";
            this.cbBventas.Size = new System.Drawing.Size(199, 34);
            this.cbBventas.TabIndex = 103;
            this.cbBventas.SelectedIndexChanged += new System.EventHandler(this.cbBventas_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 27);
            this.label1.TabIndex = 102;
            this.label1.Text = "Buscar Por:";
            // 
            // dgreporteventas
            // 
            this.dgreporteventas.AllowUserToAddRows = false;
            this.dgreporteventas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgreporteventas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgreporteventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgreporteventas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idfactura,
            this.facturacai,
            this.cliente,
            this.rtn,
            this.orden,
            this.tipopago,
            this.isv,
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
            this.dgreporteventas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgreporteventas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgreporteventas.Location = new System.Drawing.Point(0, 232);
            this.dgreporteventas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgreporteventas.Name = "dgreporteventas";
            this.dgreporteventas.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgreporteventas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgreporteventas.RowHeadersVisible = false;
            this.dgreporteventas.RowHeadersWidth = 51;
            this.dgreporteventas.RowTemplate.Height = 24;
            this.dgreporteventas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgreporteventas.Size = new System.Drawing.Size(1068, 454);
            this.dgreporteventas.TabIndex = 101;
            this.dgreporteventas.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgreporteventas_CellMouseClick);
            // 
            // idfactura
            // 
            this.idfactura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idfactura.HeaderText = "Codigo Factura";
            this.idfactura.MinimumWidth = 6;
            this.idfactura.Name = "idfactura";
            this.idfactura.ReadOnly = true;
            // 
            // facturacai
            // 
            this.facturacai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.facturacai.HeaderText = "FacturaCai";
            this.facturacai.MinimumWidth = 6;
            this.facturacai.Name = "facturacai";
            this.facturacai.ReadOnly = true;
            // 
            // cliente
            // 
            this.cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cliente.HeaderText = "Cliente";
            this.cliente.MinimumWidth = 6;
            this.cliente.Name = "cliente";
            this.cliente.ReadOnly = true;
            // 
            // rtn
            // 
            this.rtn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rtn.HeaderText = "Rtn";
            this.rtn.MinimumWidth = 6;
            this.rtn.Name = "rtn";
            this.rtn.ReadOnly = true;
            // 
            // orden
            // 
            this.orden.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.orden.HeaderText = "Orden";
            this.orden.MinimumWidth = 6;
            this.orden.Name = "orden";
            this.orden.ReadOnly = true;
            // 
            // tipopago
            // 
            this.tipopago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tipopago.HeaderText = "Tipo Pago";
            this.tipopago.MinimumWidth = 6;
            this.tipopago.Name = "tipopago";
            this.tipopago.ReadOnly = true;
            // 
            // isv
            // 
            this.isv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.isv.HeaderText = "ISV";
            this.isv.MinimumWidth = 6;
            this.isv.Name = "isv";
            this.isv.ReadOnly = true;
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
            this.estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.estado.HeaderText = "Estado";
            this.estado.MinimumWidth = 6;
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // cbxfacturas
            // 
            this.cbxfacturas.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.cbxfacturas.FormattingEnabled = true;
            this.cbxfacturas.Items.AddRange(new object[] {
            "Todas",
            "Activas",
            "Inactivas"});
            this.cbxfacturas.Location = new System.Drawing.Point(179, 71);
            this.cbxfacturas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxfacturas.Name = "cbxfacturas";
            this.cbxfacturas.Size = new System.Drawing.Size(199, 34);
            this.cbxfacturas.TabIndex = 113;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 27);
            this.label5.TabIndex = 114;
            this.label5.Text = "Facturas:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(396, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 27);
            this.label6.TabIndex = 115;
            this.label6.Text = "Efectivo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(718, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 27);
            this.label7.TabIndex = 116;
            this.label7.Text = "Tarjeta";
            // 
            // txtefectivo
            // 
            this.txtefectivo.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txtefectivo.Location = new System.Drawing.Point(513, 74);
            this.txtefectivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtefectivo.Name = "txtefectivo";
            this.txtefectivo.ReadOnly = true;
            this.txtefectivo.Size = new System.Drawing.Size(199, 34);
            this.txtefectivo.TabIndex = 117;
            // 
            // txttarjeta
            // 
            this.txttarjeta.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txttarjeta.Location = new System.Drawing.Point(823, 76);
            this.txttarjeta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttarjeta.Name = "txttarjeta";
            this.txttarjeta.ReadOnly = true;
            this.txttarjeta.Size = new System.Drawing.Size(199, 34);
            this.txttarjeta.TabIndex = 118;
            // 
            // btnexportar
            // 
            this.btnexportar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnexportar.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexportar.Image = ((System.Drawing.Image)(resources.GetObject("btnexportar.Image")));
            this.btnexportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexportar.Location = new System.Drawing.Point(940, 190);
            this.btnexportar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnexportar.Name = "btnexportar";
            this.btnexportar.Size = new System.Drawing.Size(116, 38);
            this.btnexportar.TabIndex = 119;
            this.btnexportar.Text = "Exportar";
            this.btnexportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnexportar.UseVisualStyleBackColor = false;
            this.btnexportar.Click += new System.EventHandler(this.btnexportar_Click);
            // 
            // ReporteVentasVistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1068, 686);
            this.Controls.Add(this.btnexportar);
            this.Controls.Add(this.txttarjeta);
            this.Controls.Add(this.txtefectivo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxfacturas);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.txtisv);
            this.Controls.Add(this.txtsubtotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dthasta);
            this.Controls.Add(this.dtpmesyano);
            this.Controls.Add(this.cbBventas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgreporteventas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ReporteVentasVistas";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReporteVentasVistas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgreporteventas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.TextBox txtisv;
        private System.Windows.Forms.TextBox txtsubtotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker dthasta;
        private System.Windows.Forms.DateTimePicker dtpmesyano;
        private System.Windows.Forms.ComboBox cbBventas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgreporteventas;
        private System.Windows.Forms.ComboBox cbxfacturas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtefectivo;
        private System.Windows.Forms.TextBox txttarjeta;
        private System.Windows.Forms.Button btnexportar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn facturacai;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn rtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orden;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipopago;
        private System.Windows.Forms.DataGridViewTextBoxColumn isv;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    }
}