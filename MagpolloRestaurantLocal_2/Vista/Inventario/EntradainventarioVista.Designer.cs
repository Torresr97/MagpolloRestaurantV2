
namespace AppTRchicken.Vista.Inventario
{
    partial class EntradainventarioVista
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbproductoinventario = new System.Windows.Forms.ComboBox();
            this.cbproovedor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.dgconfiginventario = new System.Windows.Forms.DataGridView();
            this.codentradainv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnagregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgconfiginventario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 27);
            this.label1.TabIndex = 83;
            this.label1.Text = "Producto";
            // 
            // cbproductoinventario
            // 
            this.cbproductoinventario.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.cbproductoinventario.FormattingEnabled = true;
            this.cbproductoinventario.Location = new System.Drawing.Point(183, 27);
            this.cbproductoinventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbproductoinventario.Name = "cbproductoinventario";
            this.cbproductoinventario.Size = new System.Drawing.Size(441, 34);
            this.cbproductoinventario.TabIndex = 91;
            this.cbproductoinventario.SelectedIndexChanged += new System.EventHandler(this.cbproductoinventario_SelectedIndexChanged);
            // 
            // cbproovedor
            // 
            this.cbproovedor.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.cbproovedor.FormattingEnabled = true;
            this.cbproovedor.Location = new System.Drawing.Point(183, 80);
            this.cbproovedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbproovedor.Name = "cbproovedor";
            this.cbproovedor.Size = new System.Drawing.Size(441, 34);
            this.cbproovedor.TabIndex = 93;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 27);
            this.label2.TabIndex = 92;
            this.label2.Text = "Proovedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 27);
            this.label3.TabIndex = 94;
            this.label3.Text = "Cantidad";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txtcantidad.Location = new System.Drawing.Point(183, 141);
            this.txtcantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(153, 34);
            this.txtcantidad.TabIndex = 102;
            // 
            // dgconfiginventario
            // 
            this.dgconfiginventario.AllowUserToAddRows = false;
            this.dgconfiginventario.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgconfiginventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgconfiginventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgconfiginventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codentradainv,
            this.proveedor,
            this.producto,
            this.cantidad,
            this.Fecha});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgconfiginventario.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgconfiginventario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgconfiginventario.Location = new System.Drawing.Point(0, 339);
            this.dgconfiginventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgconfiginventario.Name = "dgconfiginventario";
            this.dgconfiginventario.ReadOnly = true;
            this.dgconfiginventario.RowHeadersVisible = false;
            this.dgconfiginventario.RowHeadersWidth = 51;
            this.dgconfiginventario.RowTemplate.Height = 24;
            this.dgconfiginventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgconfiginventario.Size = new System.Drawing.Size(934, 299);
            this.dgconfiginventario.TabIndex = 103;
            // 
            // codentradainv
            // 
            this.codentradainv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codentradainv.HeaderText = "Cod Entrada";
            this.codentradainv.MinimumWidth = 6;
            this.codentradainv.Name = "codentradainv";
            this.codentradainv.ReadOnly = true;
            // 
            // proveedor
            // 
            this.proveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.proveedor.HeaderText = "Proveedor";
            this.proveedor.MinimumWidth = 6;
            this.proveedor.Name = "proveedor";
            this.proveedor.ReadOnly = true;
            // 
            // producto
            // 
            this.producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.producto.HeaderText = "Producto";
            this.producto.MinimumWidth = 6;
            this.producto.Name = "producto";
            this.producto.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.MinimumWidth = 6;
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnagregar.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.btnagregar.Location = new System.Drawing.Point(183, 214);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(221, 87);
            this.btnagregar.TabIndex = 104;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // EntradainventarioVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 638);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.dgconfiginventario);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbproovedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbproductoinventario);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EntradainventarioVista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Entradainventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgconfiginventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbproductoinventario;
        private System.Windows.Forms.ComboBox cbproovedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.DataGridView dgconfiginventario;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codentradainv;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
    }
}