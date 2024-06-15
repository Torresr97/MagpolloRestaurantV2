
namespace AppTRchicken.Vista
{
    partial class CompraVista
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
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.dgnuevacompra = new System.Windows.Forms.DataGridView();
            this.codigocompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrecompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipocompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtfechacompra = new System.Windows.Forms.DateTimePicker();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.cbproveedor = new System.Windows.Forms.ComboBox();
            this.cbtipocompra = new System.Windows.Forms.ComboBox();
            this.txtnombrecompra = new System.Windows.Forms.TextBox();
            this.txtcodigocompra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgnuevacompra)).BeginInit();
            this.SuspendLayout();
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn3.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.btn3.Location = new System.Drawing.Point(527, 282);
            this.btn3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(208, 72);
            this.btn3.TabIndex = 79;
            this.btn3.Text = "ELIMINAR";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn2.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.btn2.Location = new System.Drawing.Point(286, 282);
            this.btn2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(208, 72);
            this.btn2.TabIndex = 78;
            this.btn2.Text = "ACTUALIZAR";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn1.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.btn1.Location = new System.Drawing.Point(38, 282);
            this.btn1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(208, 71);
            this.btn1.TabIndex = 77;
            this.btn1.Text = "NUEVO";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // dgnuevacompra
            // 
            this.dgnuevacompra.AllowUserToAddRows = false;
            this.dgnuevacompra.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgnuevacompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgnuevacompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgnuevacompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigocompra,
            this.nombrecompra,
            this.tipocompra,
            this.proveedor,
            this.total,
            this.fecha});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgnuevacompra.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgnuevacompra.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgnuevacompra.Location = new System.Drawing.Point(0, 394);
            this.dgnuevacompra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgnuevacompra.Name = "dgnuevacompra";
            this.dgnuevacompra.ReadOnly = true;
            this.dgnuevacompra.RowHeadersVisible = false;
            this.dgnuevacompra.RowHeadersWidth = 51;
            this.dgnuevacompra.RowTemplate.Height = 24;
            this.dgnuevacompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgnuevacompra.Size = new System.Drawing.Size(771, 215);
            this.dgnuevacompra.TabIndex = 76;
            this.dgnuevacompra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgnuevacompra_CellClick);
            // 
            // codigocompra
            // 
            this.codigocompra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codigocompra.HeaderText = "Cod. Compra";
            this.codigocompra.MinimumWidth = 6;
            this.codigocompra.Name = "codigocompra";
            this.codigocompra.ReadOnly = true;
            // 
            // nombrecompra
            // 
            this.nombrecompra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombrecompra.HeaderText = "Producto";
            this.nombrecompra.MinimumWidth = 6;
            this.nombrecompra.Name = "nombrecompra";
            this.nombrecompra.ReadOnly = true;
            // 
            // tipocompra
            // 
            this.tipocompra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tipocompra.HeaderText = "Categoria";
            this.tipocompra.MinimumWidth = 6;
            this.tipocompra.Name = "tipocompra";
            this.tipocompra.ReadOnly = true;
            // 
            // proveedor
            // 
            this.proveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.proveedor.HeaderText = "Proveedor";
            this.proveedor.MinimumWidth = 6;
            this.proveedor.Name = "proveedor";
            this.proveedor.ReadOnly = true;
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
            // dtfechacompra
            // 
            this.dtfechacompra.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtfechacompra.Location = new System.Drawing.Point(249, 239);
            this.dtfechacompra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtfechacompra.Name = "dtfechacompra";
            this.dtfechacompra.Size = new System.Drawing.Size(332, 26);
            this.dtfechacompra.TabIndex = 75;
            // 
            // txttotal
            // 
            this.txttotal.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txttotal.Location = new System.Drawing.Point(249, 195);
            this.txttotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(332, 29);
            this.txttotal.TabIndex = 74;
            // 
            // cbproveedor
            // 
            this.cbproveedor.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.cbproveedor.FormattingEnabled = true;
            this.cbproveedor.Location = new System.Drawing.Point(249, 152);
            this.cbproveedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbproveedor.Name = "cbproveedor";
            this.cbproveedor.Size = new System.Drawing.Size(332, 28);
            this.cbproveedor.TabIndex = 73;
            // 
            // cbtipocompra
            // 
            this.cbtipocompra.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.cbtipocompra.FormattingEnabled = true;
            this.cbtipocompra.Location = new System.Drawing.Point(249, 107);
            this.cbtipocompra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbtipocompra.Name = "cbtipocompra";
            this.cbtipocompra.Size = new System.Drawing.Size(332, 28);
            this.cbtipocompra.TabIndex = 72;
            // 
            // txtnombrecompra
            // 
            this.txtnombrecompra.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txtnombrecompra.Location = new System.Drawing.Point(249, 66);
            this.txtnombrecompra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtnombrecompra.Name = "txtnombrecompra";
            this.txtnombrecompra.Size = new System.Drawing.Size(332, 29);
            this.txtnombrecompra.TabIndex = 71;
            // 
            // txtcodigocompra
            // 
            this.txtcodigocompra.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txtcodigocompra.Location = new System.Drawing.Point(249, 12);
            this.txtcodigocompra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtcodigocompra.Name = "txtcodigocompra";
            this.txtcodigocompra.ReadOnly = true;
            this.txtcodigocompra.Size = new System.Drawing.Size(116, 29);
            this.txtcodigocompra.TabIndex = 70;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 241);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 21);
            this.label6.TabIndex = 69;
            this.label6.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 197);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 21);
            this.label4.TabIndex = 68;
            this.label4.Text = "Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 21);
            this.label3.TabIndex = 67;
            this.label3.Text = "Proovedor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 110);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 21);
            this.label5.TabIndex = 66;
            this.label5.Text = "Categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 65;
            this.label2.Text = "Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 21);
            this.label1.TabIndex = 64;
            this.label1.Text = "Codigo de Compra";
            // 
            // Compravista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 609);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.dgnuevacompra);
            this.Controls.Add(this.dtfechacompra);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.cbproveedor);
            this.Controls.Add(this.cbtipocompra);
            this.Controls.Add(this.txtnombrecompra);
            this.Controls.Add(this.txtcodigocompra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Compravista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Compravista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgnuevacompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.DataGridView dgnuevacompra;
        private System.Windows.Forms.DateTimePicker dtfechacompra;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.ComboBox cbproveedor;
        private System.Windows.Forms.ComboBox cbtipocompra;
        private System.Windows.Forms.TextBox txtnombrecompra;
        private System.Windows.Forms.TextBox txtcodigocompra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigocompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrecompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipocompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
    }
}