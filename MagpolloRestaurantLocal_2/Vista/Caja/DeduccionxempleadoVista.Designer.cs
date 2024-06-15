
namespace AppTRchicken.Vista
{
    partial class DeduccionxempleadoVista
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
            this.dgdeduccionxempleado = new System.Windows.Forms.DataGridView();
            this.codigocredito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoempleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.cbempleado = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtsaldo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgdeduccionxempleado)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgdeduccionxempleado
            // 
            this.dgdeduccionxempleado.AllowUserToAddRows = false;
            this.dgdeduccionxempleado.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgdeduccionxempleado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgdeduccionxempleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdeduccionxempleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigocredito,
            this.codigoempleado,
            this.Producto,
            this.total,
            this.fecha});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgdeduccionxempleado.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgdeduccionxempleado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgdeduccionxempleado.Location = new System.Drawing.Point(0, 364);
            this.dgdeduccionxempleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgdeduccionxempleado.Name = "dgdeduccionxempleado";
            this.dgdeduccionxempleado.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgdeduccionxempleado.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgdeduccionxempleado.RowHeadersVisible = false;
            this.dgdeduccionxempleado.RowHeadersWidth = 51;
            this.dgdeduccionxempleado.RowTemplate.Height = 24;
            this.dgdeduccionxempleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgdeduccionxempleado.Size = new System.Drawing.Size(1065, 286);
            this.dgdeduccionxempleado.TabIndex = 58;
            this.dgdeduccionxempleado.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgdeduccionxempleado_CellMouseClick);
            // 
            // codigocredito
            // 
            this.codigocredito.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codigocredito.FillWeight = 45.92568F;
            this.codigocredito.HeaderText = "Cod. Credito";
            this.codigocredito.MinimumWidth = 6;
            this.codigocredito.Name = "codigocredito";
            this.codigocredito.ReadOnly = true;
            // 
            // codigoempleado
            // 
            this.codigoempleado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codigoempleado.FillWeight = 80.21391F;
            this.codigoempleado.HeaderText = "Cod. Empleado";
            this.codigoempleado.MinimumWidth = 6;
            this.codigoempleado.Name = "codigoempleado";
            this.codigoempleado.ReadOnly = true;
            // 
            // Producto
            // 
            this.Producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Producto.FillWeight = 200.3922F;
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 6;
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // total
            // 
            this.total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.total.FillWeight = 86.57088F;
            this.total.HeaderText = "Total";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fecha.FillWeight = 86.89735F;
            this.fecha.HeaderText = "Fecha";
            this.fecha.MinimumWidth = 6;
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 27);
            this.label2.TabIndex = 59;
            this.label2.Text = "Empleado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 27);
            this.label1.TabIndex = 60;
            this.label1.Text = "Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 27);
            this.label3.TabIndex = 61;
            this.label3.Text = "Total";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnagregar);
            this.groupBox1.Controls.Add(this.btn1);
            this.groupBox1.Controls.Add(this.txttotal);
            this.groupBox1.Controls.Add(this.txtproducto);
            this.groupBox1.Controls.Add(this.cbempleado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(0, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1152, 219);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion";
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnagregar.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.Location = new System.Drawing.Point(788, 134);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(178, 74);
            this.btnagregar.TabIndex = 66;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn1.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(670, 70);
            this.btn1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(121, 44);
            this.btn1.TabIndex = 65;
            this.btn1.Text = "Buscar";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // txttotal
            // 
            this.txttotal.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txttotal.Location = new System.Drawing.Point(223, 127);
            this.txttotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(93, 34);
            this.txttotal.TabIndex = 64;
            // 
            // txtproducto
            // 
            this.txtproducto.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txtproducto.Location = new System.Drawing.Point(223, 74);
            this.txtproducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.Size = new System.Drawing.Size(441, 34);
            this.txtproducto.TabIndex = 63;
            // 
            // cbempleado
            // 
            this.cbempleado.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.cbempleado.FormattingEnabled = true;
            this.cbempleado.Location = new System.Drawing.Point(223, 19);
            this.cbempleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbempleado.Name = "cbempleado";
            this.cbempleado.Size = new System.Drawing.Size(486, 34);
            this.cbempleado.TabIndex = 62;
            this.cbempleado.SelectedIndexChanged += new System.EventHandler(this.cbempleado_SelectedIndexChanged_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtsaldo);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(0, 225);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1152, 140);
            this.groupBox3.TabIndex = 63;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Deuda";
            // 
            // txtsaldo
            // 
            this.txtsaldo.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txtsaldo.Location = new System.Drawing.Point(223, 56);
            this.txtsaldo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsaldo.Name = "txtsaldo";
            this.txtsaldo.Size = new System.Drawing.Size(145, 34);
            this.txtsaldo.TabIndex = 65;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 27);
            this.label4.TabIndex = 64;
            this.label4.Text = "Saldo";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(0, 262);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1152, 199);
            this.groupBox4.TabIndex = 63;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // DeduccionxempleadoVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 650);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgdeduccionxempleado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DeduccionxempleadoVista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Deduccionxempleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdeduccionxempleado)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn codigocredito;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoempleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbempleado;
        private System.Windows.Forms.Button btn1;
        internal System.Windows.Forms.DataGridView dgdeduccionxempleado;
        internal System.Windows.Forms.TextBox txtsaldo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnagregar;
        public System.Windows.Forms.TextBox txttotal;
        public System.Windows.Forms.TextBox txtproducto;
        public System.Windows.Forms.GroupBox groupBox1;
    }
}