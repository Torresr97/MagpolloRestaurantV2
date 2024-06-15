
namespace AppTRchicken.Vista
{
    partial class InventarioVista
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
            this.dginventario = new System.Windows.Forms.DataGridView();
            this.txtcosto = new System.Windows.Forms.TextBox();
            this.txtnombreproducto = new System.Windows.Forms.TextBox();
            this.txtcodigoinventario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtprecioventa = new System.Windows.Forms.TextBox();
            this.txtexistencia = new System.Windows.Forms.TextBox();
            this.codigoinv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreinv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.existencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioventa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dginventario)).BeginInit();
            this.SuspendLayout();
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn3.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.btn3.Location = new System.Drawing.Point(703, 340);
            this.btn3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(277, 89);
            this.btn3.TabIndex = 97;
            this.btn3.Text = "ELIMINAR";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn2.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.btn2.Location = new System.Drawing.Point(381, 340);
            this.btn2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(277, 89);
            this.btn2.TabIndex = 96;
            this.btn2.Text = "ACTUALIZAR";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn1.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.btn1.Location = new System.Drawing.Point(51, 340);
            this.btn1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(277, 87);
            this.btn1.TabIndex = 95;
            this.btn1.Text = "NUEVO";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // dginventario
            // 
            this.dginventario.AllowUserToAddRows = false;
            this.dginventario.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dginventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dginventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dginventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoinv,
            this.nombreinv,
            this.existencia,
            this.costo,
            this.precioventa});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dginventario.DefaultCellStyle = dataGridViewCellStyle2;
            this.dginventario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dginventario.Location = new System.Drawing.Point(0, 451);
            this.dginventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dginventario.Name = "dginventario";
            this.dginventario.ReadOnly = true;
            this.dginventario.RowHeadersVisible = false;
            this.dginventario.RowHeadersWidth = 51;
            this.dginventario.RowTemplate.Height = 24;
            this.dginventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dginventario.Size = new System.Drawing.Size(1028, 299);
            this.dginventario.TabIndex = 94;
            this.dginventario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dginventario_CellClick);
            // 
            // txtcosto
            // 
            this.txtcosto.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txtcosto.Location = new System.Drawing.Point(332, 176);
            this.txtcosto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcosto.Name = "txtcosto";
            this.txtcosto.Size = new System.Drawing.Size(153, 34);
            this.txtcosto.TabIndex = 92;
            // 
            // txtnombreproducto
            // 
            this.txtnombreproducto.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txtnombreproducto.Location = new System.Drawing.Point(332, 74);
            this.txtnombreproducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnombreproducto.Name = "txtnombreproducto";
            this.txtnombreproducto.Size = new System.Drawing.Size(441, 34);
            this.txtnombreproducto.TabIndex = 89;
            // 
            // txtcodigoinventario
            // 
            this.txtcodigoinventario.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txtcodigoinventario.Location = new System.Drawing.Point(332, 7);
            this.txtcodigoinventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcodigoinventario.Name = "txtcodigoinventario";
            this.txtcodigoinventario.ReadOnly = true;
            this.txtcodigoinventario.Size = new System.Drawing.Size(153, 34);
            this.txtcodigoinventario.TabIndex = 88;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 27);
            this.label6.TabIndex = 87;
            this.label6.Text = "Precio Venta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 27);
            this.label4.TabIndex = 86;
            this.label4.Text = "Costo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 27);
            this.label5.TabIndex = 84;
            this.label5.Text = "Existencia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 27);
            this.label2.TabIndex = 83;
            this.label2.Text = "Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 27);
            this.label1.TabIndex = 82;
            this.label1.Text = "Codigo de Inventario";
            // 
            // txtprecioventa
            // 
            this.txtprecioventa.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txtprecioventa.Location = new System.Drawing.Point(332, 226);
            this.txtprecioventa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtprecioventa.Name = "txtprecioventa";
            this.txtprecioventa.Size = new System.Drawing.Size(153, 34);
            this.txtprecioventa.TabIndex = 101;
            // 
            // txtexistencia
            // 
            this.txtexistencia.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txtexistencia.Location = new System.Drawing.Point(332, 121);
            this.txtexistencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtexistencia.Name = "txtexistencia";
            this.txtexistencia.Size = new System.Drawing.Size(153, 34);
            this.txtexistencia.TabIndex = 103;
            // 
            // codigoinv
            // 
            this.codigoinv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codigoinv.HeaderText = "Cod. Inventario";
            this.codigoinv.MinimumWidth = 6;
            this.codigoinv.Name = "codigoinv";
            this.codigoinv.ReadOnly = true;
            // 
            // nombreinv
            // 
            this.nombreinv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreinv.HeaderText = "Producto";
            this.nombreinv.MinimumWidth = 6;
            this.nombreinv.Name = "nombreinv";
            this.nombreinv.ReadOnly = true;
            // 
            // existencia
            // 
            this.existencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.existencia.HeaderText = "Existencia";
            this.existencia.MinimumWidth = 6;
            this.existencia.Name = "existencia";
            this.existencia.ReadOnly = true;
            // 
            // costo
            // 
            this.costo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.costo.HeaderText = "Costo";
            this.costo.MinimumWidth = 6;
            this.costo.Name = "costo";
            this.costo.ReadOnly = true;
            // 
            // precioventa
            // 
            this.precioventa.HeaderText = "Precio Venta";
            this.precioventa.MinimumWidth = 6;
            this.precioventa.Name = "precioventa";
            this.precioventa.ReadOnly = true;
            this.precioventa.Width = 125;
            // 
            // InventarioVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 750);
            this.Controls.Add(this.txtexistencia);
            this.Controls.Add(this.txtprecioventa);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.dginventario);
            this.Controls.Add(this.txtcosto);
            this.Controls.Add(this.txtnombreproducto);
            this.Controls.Add(this.txtcodigoinventario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InventarioVista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.InventarioVista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dginventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.DataGridView dginventario;
        private System.Windows.Forms.TextBox txtcosto;
        private System.Windows.Forms.TextBox txtnombreproducto;
        private System.Windows.Forms.TextBox txtcodigoinventario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtprecioventa;
        private System.Windows.Forms.TextBox txtexistencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoinv;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreinv;
        private System.Windows.Forms.DataGridViewTextBoxColumn existencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioventa;
    }
}