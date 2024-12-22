
namespace AppTRchicken.Vista.Reportes
{
    partial class ReporteMovimientoscajasVista
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteMovimientoscajasVista));
            this.dgreportemovimientoscaja = new System.Windows.Forms.DataGridView();
            this.idcaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.efectivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarjeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acc = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txttransferencia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnexportar = new System.Windows.Forms.Button();
            this.txttarjeta = new System.Windows.Forms.TextBox();
            this.cbxmovimientos = new System.Windows.Forms.ComboBox();
            this.txtefectivo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbBventas = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpmesyano = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dthasta = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgreportemovimientoscaja)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgreportemovimientoscaja
            // 
            this.dgreportemovimientoscaja.AllowUserToAddRows = false;
            this.dgreportemovimientoscaja.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgreportemovimientoscaja.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgreportemovimientoscaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgreportemovimientoscaja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcaja,
            this.tipo,
            this.motivo,
            this.efectivo,
            this.tarjeta,
            this.transferencia,
            this.total,
            this.fecha,
            this.acc});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgreportemovimientoscaja.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgreportemovimientoscaja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgreportemovimientoscaja.Location = new System.Drawing.Point(0, 384);
            this.dgreportemovimientoscaja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgreportemovimientoscaja.Name = "dgreportemovimientoscaja";
            this.dgreportemovimientoscaja.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgreportemovimientoscaja.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgreportemovimientoscaja.RowHeadersVisible = false;
            this.dgreportemovimientoscaja.RowHeadersWidth = 51;
            this.dgreportemovimientoscaja.RowTemplate.Height = 24;
            this.dgreportemovimientoscaja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgreportemovimientoscaja.Size = new System.Drawing.Size(1068, 406);
            this.dgreportemovimientoscaja.TabIndex = 140;
            this.dgreportemovimientoscaja.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgreportemovimientoscaja_CellClick);
            // 
            // idcaja
            // 
            this.idcaja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idcaja.HeaderText = "Codigo Caja";
            this.idcaja.MinimumWidth = 6;
            this.idcaja.Name = "idcaja";
            this.idcaja.ReadOnly = true;
            // 
            // tipo
            // 
            this.tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tipo.HeaderText = "Tipo";
            this.tipo.MinimumWidth = 6;
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            // 
            // motivo
            // 
            this.motivo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.motivo.HeaderText = "Motivo";
            this.motivo.MinimumWidth = 6;
            this.motivo.Name = "motivo";
            this.motivo.ReadOnly = true;
            // 
            // efectivo
            // 
            this.efectivo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.efectivo.HeaderText = "Efectivo";
            this.efectivo.MinimumWidth = 6;
            this.efectivo.Name = "efectivo";
            this.efectivo.ReadOnly = true;
            // 
            // tarjeta
            // 
            this.tarjeta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tarjeta.HeaderText = "Tarjeta";
            this.tarjeta.MinimumWidth = 6;
            this.tarjeta.Name = "tarjeta";
            this.tarjeta.ReadOnly = true;
            // 
            // transferencia
            // 
            this.transferencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.transferencia.HeaderText = "Transferencia";
            this.transferencia.MinimumWidth = 6;
            this.transferencia.Name = "transferencia";
            this.transferencia.ReadOnly = true;
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
            // acc
            // 
            this.acc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.acc.HeaderText = "ACC";
            this.acc.Image = ((System.Drawing.Image)(resources.GetObject("acc.Image")));
            this.acc.MinimumWidth = 6;
            this.acc.Name = "acc";
            this.acc.ReadOnly = true;
            this.acc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.acc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txttransferencia);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.txttarjeta);
            this.panel1.Controls.Add(this.cbxmovimientos);
            this.panel1.Controls.Add(this.txtefectivo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cbBventas);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dtpmesyano);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dthasta);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.txttotal);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 384);
            this.panel1.TabIndex = 141;
            // 
            // txttransferencia
            // 
            this.txttransferencia.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txttransferencia.Location = new System.Drawing.Point(217, 207);
            this.txttransferencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttransferencia.Name = "txttransferencia";
            this.txttransferencia.ReadOnly = true;
            this.txttransferencia.Size = new System.Drawing.Size(199, 34);
            this.txttransferencia.TabIndex = 141;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 27);
            this.label2.TabIndex = 140;
            this.label2.Text = "Transferencia";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnexportar, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 339);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1068, 45);
            this.tableLayoutPanel1.TabIndex = 139;
            // 
            // btnexportar
            // 
            this.btnexportar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnexportar.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexportar.Image = ((System.Drawing.Image)(resources.GetObject("btnexportar.Image")));
            this.btnexportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexportar.Location = new System.Drawing.Point(804, 2);
            this.btnexportar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnexportar.Name = "btnexportar";
            this.btnexportar.Size = new System.Drawing.Size(116, 38);
            this.btnexportar.TabIndex = 138;
            this.btnexportar.Text = "Exportar";
            this.btnexportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnexportar.UseVisualStyleBackColor = false;
            this.btnexportar.Click += new System.EventHandler(this.btnexportar_Click_1);
            // 
            // txttarjeta
            // 
            this.txttarjeta.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txttarjeta.Location = new System.Drawing.Point(217, 166);
            this.txttarjeta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttarjeta.Name = "txttarjeta";
            this.txttarjeta.ReadOnly = true;
            this.txttarjeta.Size = new System.Drawing.Size(199, 34);
            this.txttarjeta.TabIndex = 137;
            // 
            // cbxmovimientos
            // 
            this.cbxmovimientos.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.cbxmovimientos.FormattingEnabled = true;
            this.cbxmovimientos.Items.AddRange(new object[] {
            "Deposito",
            "Retiro",
            "Cierre de Caja"});
            this.cbxmovimientos.Location = new System.Drawing.Point(218, 80);
            this.cbxmovimientos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxmovimientos.Name = "cbxmovimientos";
            this.cbxmovimientos.Size = new System.Drawing.Size(242, 34);
            this.cbxmovimientos.TabIndex = 132;
            // 
            // txtefectivo
            // 
            this.txtefectivo.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txtefectivo.Location = new System.Drawing.Point(217, 125);
            this.txtefectivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtefectivo.Name = "txtefectivo";
            this.txtefectivo.ReadOnly = true;
            this.txtefectivo.Size = new System.Drawing.Size(199, 34);
            this.txtefectivo.TabIndex = 136;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 27);
            this.label1.TabIndex = 121;
            this.label1.Text = "Buscar Por:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 27);
            this.label7.TabIndex = 135;
            this.label7.Text = "Tarjeta";
            // 
            // cbBventas
            // 
            this.cbBventas.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.cbBventas.FormattingEnabled = true;
            this.cbBventas.Items.AddRange(new object[] {
            "Dia",
            "Desde - Hasta"});
            this.cbBventas.Location = new System.Drawing.Point(208, 22);
            this.cbBventas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbBventas.Name = "cbBventas";
            this.cbBventas.Size = new System.Drawing.Size(199, 34);
            this.cbBventas.TabIndex = 122;
            this.cbBventas.SelectedIndexChanged += new System.EventHandler(this.cbBventas_SelectedIndexChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 27);
            this.label6.TabIndex = 134;
            this.label6.Text = "Efectivo";
            // 
            // dtpmesyano
            // 
            this.dtpmesyano.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.dtpmesyano.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpmesyano.Location = new System.Drawing.Point(413, 23);
            this.dtpmesyano.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpmesyano.Name = "dtpmesyano";
            this.dtpmesyano.Size = new System.Drawing.Size(219, 34);
            this.dtpmesyano.TabIndex = 123;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 27);
            this.label5.TabIndex = 133;
            this.label5.Text = "Movimientos:";
            // 
            // dthasta
            // 
            this.dthasta.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.dthasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dthasta.Location = new System.Drawing.Point(662, 23);
            this.dthasta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dthasta.Name = "dthasta";
            this.dthasta.Size = new System.Drawing.Size(219, 34);
            this.dthasta.TabIndex = 124;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.btnBuscar.Location = new System.Drawing.Point(928, 24);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(141, 34);
            this.btnBuscar.TabIndex = 125;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // txttotal
            // 
            this.txttotal.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txttotal.Location = new System.Drawing.Point(217, 255);
            this.txttotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(199, 34);
            this.txttotal.TabIndex = 131;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 27);
            this.label4.TabIndex = 128;
            this.label4.Text = "Total";
            // 
            // ReporteMovimientoscajasVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1068, 790);
            this.Controls.Add(this.dgreportemovimientoscaja);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReporteMovimientoscajasVista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReporteMovimientoscajas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgreportemovimientoscaja)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgreportemovimientoscaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn motivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn efectivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarjeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn transferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewImageColumn acc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txttransferencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnexportar;
        private System.Windows.Forms.TextBox txttarjeta;
        private System.Windows.Forms.ComboBox cbxmovimientos;
        private System.Windows.Forms.TextBox txtefectivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbBventas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpmesyano;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dthasta;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label4;
    }
}