
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dglistafacturas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txttotalefectivo = new System.Windows.Forms.TextBox();
            this.txttotaltarjeta = new System.Windows.Forms.TextBox();
            this.txttotalventas = new System.Windows.Forms.TextBox();
            this.codigofactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facturacai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroorden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipopago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dinerorecibido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dineroentregado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACC = new System.Windows.Forms.DataGridViewImageColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dglistafacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.dglistafacturas, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txttotalefectivo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txttotaltarjeta, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txttotalventas, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1358, 808);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // dglistafacturas
            // 
            this.dglistafacturas.AllowUserToAddRows = false;
            this.dglistafacturas.AllowUserToDeleteRows = false;
            this.dglistafacturas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.tableLayoutPanel1.SetColumnSpan(this.dglistafacturas, 4);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dglistafacturas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dglistafacturas.Location = new System.Drawing.Point(3, 405);
            this.dglistafacturas.Name = "dglistafacturas";
            this.dglistafacturas.ReadOnly = true;
            this.dglistafacturas.RowHeadersVisible = false;
            this.dglistafacturas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.tableLayoutPanel1.SetRowSpan(this.dglistafacturas, 3);
            this.dglistafacturas.RowTemplate.Height = 24;
            this.dglistafacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dglistafacturas.Size = new System.Drawing.Size(1352, 400);
            this.dglistafacturas.TabIndex = 5;
            this.dglistafacturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dglistafacturas_CellContentClick);
            this.dglistafacturas.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dglistafacturas_CellMouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 19.8F);
            this.label2.Location = new System.Drawing.Point(3, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 41);
            this.label2.TabIndex = 51;
            this.label2.Text = "Total Efectivo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 19.8F);
            this.label1.Location = new System.Drawing.Point(3, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 41);
            this.label1.TabIndex = 52;
            this.label1.Text = "Total Tarjeta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 19.8F);
            this.label3.Location = new System.Drawing.Point(3, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(333, 41);
            this.label3.TabIndex = 53;
            this.label3.Text = "Total de Ventas";
            // 
            // txttotalefectivo
            // 
            this.txttotalefectivo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txttotalefectivo.Font = new System.Drawing.Font("Bookman Old Style", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalefectivo.Location = new System.Drawing.Point(342, 85);
            this.txttotalefectivo.Name = "txttotalefectivo";
            this.txttotalefectivo.Size = new System.Drawing.Size(333, 46);
            this.txttotalefectivo.TabIndex = 54;
            // 
            // txttotaltarjeta
            // 
            this.txttotaltarjeta.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txttotaltarjeta.Font = new System.Drawing.Font("Bookman Old Style", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotaltarjeta.Location = new System.Drawing.Point(342, 219);
            this.txttotaltarjeta.Name = "txttotaltarjeta";
            this.txttotaltarjeta.Size = new System.Drawing.Size(333, 46);
            this.txttotaltarjeta.TabIndex = 55;
            // 
            // txttotalventas
            // 
            this.txttotalventas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txttotalventas.Font = new System.Drawing.Font("Bookman Old Style", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalventas.Location = new System.Drawing.Point(342, 353);
            this.txttotalventas.Name = "txttotalventas";
            this.txttotalventas.Size = new System.Drawing.Size(333, 46);
            this.txttotalventas.TabIndex = 56;
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
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ListaFacturasVista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ListaFacturasVista_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dglistafacturas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.DataGridView dglistafacturas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttotaltarjeta;
        private System.Windows.Forms.TextBox txttotalventas;
        public System.Windows.Forms.TextBox txttotalefectivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigofactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn facturacai;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroorden;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipopago;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn dinerorecibido;
        private System.Windows.Forms.DataGridViewTextBoxColumn dineroentregado;
        private System.Windows.Forms.DataGridViewImageColumn ACC;
    }
}