
namespace AppTRchicken.Vista
{
    partial class ReporteComprasVista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteComprasVista));
            this.dgreportecompras = new System.Windows.Forms.DataGridView();
            this.nombrecompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipocompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proovedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtisv = new System.Windows.Forms.TextBox();
            this.txtsubtotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dthasta = new System.Windows.Forms.DateTimePicker();
            this.dtpmesyano = new System.Windows.Forms.DateTimePicker();
            this.cbBcompras = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnexportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgreportecompras)).BeginInit();
            this.SuspendLayout();
            // 
            // dgreportecompras
            // 
            this.dgreportecompras.AllowUserToAddRows = false;
            this.dgreportecompras.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgreportecompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgreportecompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgreportecompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombrecompra,
            this.tipocompra,
            this.proovedor,
            this.Total,
            this.fecha});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgreportecompras.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgreportecompras.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgreportecompras.Location = new System.Drawing.Point(0, 263);
            this.dgreportecompras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgreportecompras.Name = "dgreportecompras";
            this.dgreportecompras.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgreportecompras.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgreportecompras.RowHeadersVisible = false;
            this.dgreportecompras.RowHeadersWidth = 51;
            this.dgreportecompras.RowTemplate.Height = 24;
            this.dgreportecompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgreportecompras.Size = new System.Drawing.Size(1284, 490);
            this.dgreportecompras.TabIndex = 124;
            // 
            // nombrecompra
            // 
            this.nombrecompra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombrecompra.HeaderText = "Nombre Compra";
            this.nombrecompra.MinimumWidth = 6;
            this.nombrecompra.Name = "nombrecompra";
            this.nombrecompra.ReadOnly = true;
            // 
            // tipocompra
            // 
            this.tipocompra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tipocompra.HeaderText = "Tipo Compra";
            this.tipocompra.MinimumWidth = 6;
            this.tipocompra.Name = "tipocompra";
            this.tipocompra.ReadOnly = true;
            // 
            // proovedor
            // 
            this.proovedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.proovedor.HeaderText = "Proovedor";
            this.proovedor.MinimumWidth = 6;
            this.proovedor.Name = "proovedor";
            this.proovedor.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fecha.HeaderText = "Fecha";
            this.fecha.MinimumWidth = 6;
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // txttotal
            // 
            this.txttotal.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txttotal.Location = new System.Drawing.Point(681, 98);
            this.txttotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(184, 34);
            this.txttotal.TabIndex = 123;
            // 
            // txtisv
            // 
            this.txtisv.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txtisv.Location = new System.Drawing.Point(396, 98);
            this.txtisv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtisv.Name = "txtisv";
            this.txtisv.Size = new System.Drawing.Size(184, 34);
            this.txtisv.TabIndex = 122;
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txtsubtotal.Location = new System.Drawing.Point(128, 98);
            this.txtsubtotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.Size = new System.Drawing.Size(184, 34);
            this.txtsubtotal.TabIndex = 121;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(606, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 27);
            this.label4.TabIndex = 120;
            this.label4.Text = "Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(336, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 27);
            this.label3.TabIndex = 119;
            this.label3.Text = "ISV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 27);
            this.label2.TabIndex = 118;
            this.label2.Text = "SubTotal";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.btnBuscar.Location = new System.Drawing.Point(396, 18);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(141, 35);
            this.btnBuscar.TabIndex = 117;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dthasta
            // 
            this.dthasta.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.dthasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dthasta.Location = new System.Drawing.Point(628, 16);
            this.dthasta.Name = "dthasta";
            this.dthasta.Size = new System.Drawing.Size(219, 34);
            this.dthasta.TabIndex = 116;
            // 
            // dtpmesyano
            // 
            this.dtpmesyano.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.dtpmesyano.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpmesyano.Location = new System.Drawing.Point(379, 16);
            this.dtpmesyano.Name = "dtpmesyano";
            this.dtpmesyano.Size = new System.Drawing.Size(219, 34);
            this.dtpmesyano.TabIndex = 115;
            // 
            // cbBcompras
            // 
            this.cbBcompras.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.cbBcompras.FormattingEnabled = true;
            this.cbBcompras.Items.AddRange(new object[] {
            "Dia",
            "Mes",
            "Año",
            "Desde - Hasta"});
            this.cbBcompras.Location = new System.Drawing.Point(174, 15);
            this.cbBcompras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbBcompras.Name = "cbBcompras";
            this.cbBcompras.Size = new System.Drawing.Size(199, 34);
            this.cbBcompras.TabIndex = 114;
            this.cbBcompras.SelectedIndexChanged += new System.EventHandler(this.cbBcompras_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 27);
            this.label1.TabIndex = 113;
            this.label1.Text = "Buscar Por:";
            // 
            // btnexportar
            // 
            this.btnexportar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnexportar.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexportar.Image = ((System.Drawing.Image)(resources.GetObject("btnexportar.Image")));
            this.btnexportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexportar.Location = new System.Drawing.Point(1207, 208);
            this.btnexportar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnexportar.Name = "btnexportar";
            this.btnexportar.Size = new System.Drawing.Size(116, 38);
            this.btnexportar.TabIndex = 125;
            this.btnexportar.Text = "Exportar";
            this.btnexportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnexportar.UseVisualStyleBackColor = false;
            this.btnexportar.Click += new System.EventHandler(this.btnexportar_Click);
            // 
            // ReporteComprasVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1284, 753);
            this.Controls.Add(this.btnexportar);
            this.Controls.Add(this.dgreportecompras);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.txtisv);
            this.Controls.Add(this.txtsubtotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dthasta);
            this.Controls.Add(this.dtpmesyano);
            this.Controls.Add(this.cbBcompras);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReporteComprasVista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReporteComprasVista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgreportecompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgreportecompras;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.TextBox txtisv;
        private System.Windows.Forms.TextBox txtsubtotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker dthasta;
        private System.Windows.Forms.DateTimePicker dtpmesyano;
        private System.Windows.Forms.ComboBox cbBcompras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnexportar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrecompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipocompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn proovedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
    }
}