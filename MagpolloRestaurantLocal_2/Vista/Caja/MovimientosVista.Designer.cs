
namespace AppTRchicken.Vista
{
    partial class MovimientosVista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovimientosVista));
            this.dgmovimientos = new System.Windows.Forms.DataGridView();
            this.cbtipomovimiento = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.idcaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acc = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgmovimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgmovimientos
            // 
            this.dgmovimientos.AllowUserToAddRows = false;
            this.dgmovimientos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgmovimientos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgmovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgmovimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcaja,
            this.tipo,
            this.motivo,
            this.total,
            this.fecha,
            this.acc});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgmovimientos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgmovimientos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgmovimientos.Location = new System.Drawing.Point(0, 173);
            this.dgmovimientos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgmovimientos.Name = "dgmovimientos";
            this.dgmovimientos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgmovimientos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgmovimientos.RowHeadersVisible = false;
            this.dgmovimientos.RowHeadersWidth = 51;
            this.dgmovimientos.RowTemplate.Height = 24;
            this.dgmovimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgmovimientos.Size = new System.Drawing.Size(1050, 386);
            this.dgmovimientos.TabIndex = 38;
            this.dgmovimientos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgmovimientos_CellContentClick);
            // 
            // cbtipomovimiento
            // 
            this.cbtipomovimiento.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.cbtipomovimiento.FormattingEnabled = true;
            this.cbtipomovimiento.Location = new System.Drawing.Point(264, 64);
            this.cbtipomovimiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbtipomovimiento.Name = "cbtipomovimiento";
            this.cbtipomovimiento.Size = new System.Drawing.Size(445, 34);
            this.cbtipomovimiento.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 27);
            this.label1.TabIndex = 58;
            this.label1.Text = "Tipo Movimiento";
            // 
            // btnbuscar
            // 
            this.btnbuscar.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.Location = new System.Drawing.Point(723, 64);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(134, 39);
            this.btnbuscar.TabIndex = 60;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(144, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 27);
            this.label2.TabIndex = 61;
            this.label2.Text = "Total";
            // 
            // txttotal
            // 
            this.txttotal.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txttotal.Location = new System.Drawing.Point(264, 121);
            this.txttotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(114, 34);
            this.txttotal.TabIndex = 62;
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
            this.tipo.HeaderText = "Tipo";
            this.tipo.MinimumWidth = 6;
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            this.tipo.Width = 125;
            // 
            // motivo
            // 
            this.motivo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.motivo.HeaderText = "Motivo";
            this.motivo.MinimumWidth = 6;
            this.motivo.Name = "motivo";
            this.motivo.ReadOnly = true;
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
            // 
            // MovimientosVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 559);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbtipomovimiento);
            this.Controls.Add(this.dgmovimientos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MovimientosVista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Movimientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgmovimientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgmovimientos;
        private System.Windows.Forms.ComboBox cbtipomovimiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn motivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewImageColumn acc;
    }
}