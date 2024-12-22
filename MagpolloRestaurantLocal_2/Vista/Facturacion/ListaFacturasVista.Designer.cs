
namespace AppTRchicken.Vista
{
    partial class ListaFacturasVista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaFacturasVista));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txttotaltransferencia = new System.Windows.Forms.TextBox();
            this.txttotalefectivo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttotalventas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txttotaltarjeta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dglistafacturas = new System.Windows.Forms.DataGridView();
            this.codigofactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facturacai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroorden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipopago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dinerorecibido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dineroentregado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACC = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dglistafacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txttotaltransferencia);
            this.panel1.Controls.Add(this.txttotalefectivo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txttotalventas);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txttotaltarjeta);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1358, 337);
            this.panel1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 19.8F);
            this.label5.Location = new System.Drawing.Point(21, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(330, 41);
            this.label5.TabIndex = 59;
            this.label5.Text = "Total Transferencia";
            // 
            // txttotaltransferencia
            // 
            this.txttotaltransferencia.Font = new System.Drawing.Font("Bookman Old Style", 18F);
            this.txttotaltransferencia.Location = new System.Drawing.Point(394, 167);
            this.txttotaltransferencia.Name = "txttotaltransferencia";
            this.txttotaltransferencia.ReadOnly = true;
            this.txttotaltransferencia.Size = new System.Drawing.Size(311, 43);
            this.txttotaltransferencia.TabIndex = 58;
            // 
            // txttotalefectivo
            // 
            this.txttotalefectivo.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalefectivo.Location = new System.Drawing.Point(394, 33);
            this.txttotalefectivo.Name = "txttotalefectivo";
            this.txttotalefectivo.ReadOnly = true;
            this.txttotalefectivo.Size = new System.Drawing.Size(311, 43);
            this.txttotalefectivo.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 19.8F);
            this.label2.Location = new System.Drawing.Point(21, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 41);
            this.label2.TabIndex = 51;
            this.label2.Text = "Total Efectivo";
            // 
            // txttotalventas
            // 
            this.txttotalventas.Font = new System.Drawing.Font("Bookman Old Style", 18F);
            this.txttotalventas.Location = new System.Drawing.Point(394, 235);
            this.txttotalventas.Name = "txttotalventas";
            this.txttotalventas.ReadOnly = true;
            this.txttotalventas.Size = new System.Drawing.Size(311, 43);
            this.txttotalventas.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 19.8F);
            this.label1.Location = new System.Drawing.Point(21, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 41);
            this.label1.TabIndex = 52;
            this.label1.Text = "Total Tarjeta";
            // 
            // txttotaltarjeta
            // 
            this.txttotaltarjeta.Font = new System.Drawing.Font("Bookman Old Style", 18F);
            this.txttotaltarjeta.Location = new System.Drawing.Point(394, 98);
            this.txttotaltarjeta.Name = "txttotaltarjeta";
            this.txttotaltarjeta.ReadOnly = true;
            this.txttotaltarjeta.Size = new System.Drawing.Size(311, 43);
            this.txttotaltarjeta.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 19.8F);
            this.label3.Location = new System.Drawing.Point(21, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 41);
            this.label3.TabIndex = 53;
            this.label3.Text = "Total de Ventas";
            // 
            // dglistafacturas
            // 
            this.dglistafacturas.AllowUserToAddRows = false;
            this.dglistafacturas.AllowUserToDeleteRows = false;
            this.dglistafacturas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dglistafacturas.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dglistafacturas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dglistafacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dglistafacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigofactura,
            this.facturacai,
            this.numeroorden,
            this.descuento,
            this.tipopago,
            this.total,
            this.dinerorecibido,
            this.dineroentregado,
            this.ACC});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dglistafacturas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dglistafacturas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dglistafacturas.Location = new System.Drawing.Point(0, 337);
            this.dglistafacturas.Name = "dglistafacturas";
            this.dglistafacturas.ReadOnly = true;
            this.dglistafacturas.RowHeadersVisible = false;
            this.dglistafacturas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dglistafacturas.RowTemplate.Height = 24;
            this.dglistafacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dglistafacturas.Size = new System.Drawing.Size(1358, 471);
            this.dglistafacturas.TabIndex = 6;
            this.dglistafacturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dglistafacturas_CellContentClick_1);
            this.dglistafacturas.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dglistafacturas_CellMouseClick_1);
            // 
            // codigofactura
            // 
            this.codigofactura.HeaderText = "Codigo Factura";
            this.codigofactura.MinimumWidth = 6;
            this.codigofactura.Name = "codigofactura";
            this.codigofactura.ReadOnly = true;
            this.codigofactura.Width = 140;
            // 
            // facturacai
            // 
            this.facturacai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.facturacai.HeaderText = "FacturaCai";
            this.facturacai.MinimumWidth = 6;
            this.facturacai.Name = "facturacai";
            this.facturacai.ReadOnly = true;
            // 
            // numeroorden
            // 
            this.numeroorden.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numeroorden.HeaderText = "Orden";
            this.numeroorden.MinimumWidth = 6;
            this.numeroorden.Name = "numeroorden";
            this.numeroorden.ReadOnly = true;
            // 
            // descuento
            // 
            this.descuento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descuento.HeaderText = "Descuento";
            this.descuento.MinimumWidth = 6;
            this.descuento.Name = "descuento";
            this.descuento.ReadOnly = true;
            // 
            // tipopago
            // 
            this.tipopago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tipopago.HeaderText = "Metodo Pago";
            this.tipopago.MinimumWidth = 6;
            this.tipopago.Name = "tipopago";
            this.tipopago.ReadOnly = true;
            // 
            // total
            // 
            this.total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.total.HeaderText = "Total";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // dinerorecibido
            // 
            this.dinerorecibido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dinerorecibido.HeaderText = "Dinero Recibido";
            this.dinerorecibido.MinimumWidth = 6;
            this.dinerorecibido.Name = "dinerorecibido";
            this.dinerorecibido.ReadOnly = true;
            // 
            // dineroentregado
            // 
            this.dineroentregado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dineroentregado.HeaderText = "Dinero Entregado";
            this.dineroentregado.MinimumWidth = 6;
            this.dineroentregado.Name = "dineroentregado";
            this.dineroentregado.ReadOnly = true;
            // 
            // ACC
            // 
            this.ACC.HeaderText = "ACC";
            this.ACC.Image = ((System.Drawing.Image)(resources.GetObject("ACC.Image")));
            this.ACC.MinimumWidth = 6;
            this.ACC.Name = "ACC";
            this.ACC.ReadOnly = true;
            this.ACC.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ACC.Width = 125;
            // 
            // ListaFacturasVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 808);
            this.Controls.Add(this.dglistafacturas);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ListaFacturasVista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ListaFacturasVista_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dglistafacturas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txttotaltransferencia;
        public System.Windows.Forms.TextBox txttotalefectivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttotalventas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttotaltarjeta;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DataGridView dglistafacturas;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigofactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn facturacai;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroorden;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipopago;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn dinerorecibido;
        private System.Windows.Forms.DataGridViewTextBoxColumn dineroentregado;
        private System.Windows.Forms.DataGridViewImageColumn ACC;
        private System.Windows.Forms.Label label5;
    }
}