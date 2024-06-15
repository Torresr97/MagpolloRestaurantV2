
namespace AppTRchicken.Vista
{
    partial class impresoraVista
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
            this.txtcantidadtickets = new System.Windows.Forms.TextBox();
            this.txtnombreimpresora = new System.Windows.Forms.TextBox();
            this.txtcodigoimpresora = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgimpresora = new System.Windows.Forms.DataGridView();
            this.idusuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgimpresora)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcantidadtickets
            // 
            this.txtcantidadtickets.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txtcantidadtickets.Location = new System.Drawing.Point(271, 96);
            this.txtcantidadtickets.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtcantidadtickets.Name = "txtcantidadtickets";
            this.txtcantidadtickets.Size = new System.Drawing.Size(56, 29);
            this.txtcantidadtickets.TabIndex = 76;
            // 
            // txtnombreimpresora
            // 
            this.txtnombreimpresora.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txtnombreimpresora.Location = new System.Drawing.Point(272, 50);
            this.txtnombreimpresora.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtnombreimpresora.Name = "txtnombreimpresora";
            this.txtnombreimpresora.Size = new System.Drawing.Size(332, 29);
            this.txtnombreimpresora.TabIndex = 75;
            // 
            // txtcodigoimpresora
            // 
            this.txtcodigoimpresora.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txtcodigoimpresora.Location = new System.Drawing.Point(271, 3);
            this.txtcodigoimpresora.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtcodigoimpresora.Name = "txtcodigoimpresora";
            this.txtcodigoimpresora.ReadOnly = true;
            this.txtcodigoimpresora.Size = new System.Drawing.Size(332, 29);
            this.txtcodigoimpresora.TabIndex = 74;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 21);
            this.label3.TabIndex = 73;
            this.label3.Text = "# Tickets";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 72;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 21);
            this.label1.TabIndex = 71;
            this.label1.Text = "Codigo de Impresora";
            // 
            // dgimpresora
            // 
            this.dgimpresora.AllowUserToAddRows = false;
            this.dgimpresora.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgimpresora.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgimpresora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgimpresora.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idusuario,
            this.nombre,
            this.apellido});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgimpresora.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgimpresora.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgimpresora.Location = new System.Drawing.Point(0, 181);
            this.dgimpresora.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgimpresora.Name = "dgimpresora";
            this.dgimpresora.ReadOnly = true;
            this.dgimpresora.RowHeadersVisible = false;
            this.dgimpresora.RowHeadersWidth = 51;
            this.dgimpresora.RowTemplate.Height = 24;
            this.dgimpresora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgimpresora.Size = new System.Drawing.Size(844, 243);
            this.dgimpresora.TabIndex = 70;
            this.dgimpresora.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgimpresora_CellClick);
            // 
            // idusuario
            // 
            this.idusuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idusuario.FillWeight = 76.51117F;
            this.idusuario.HeaderText = "Codigo de Impresora";
            this.idusuario.MinimumWidth = 6;
            this.idusuario.Name = "idusuario";
            this.idusuario.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombre.FillWeight = 101.3129F;
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // apellido
            // 
            this.apellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.apellido.FillWeight = 96.25668F;
            this.apellido.HeaderText = "# Tickets";
            this.apellido.MinimumWidth = 6;
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn2.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.btn2.Location = new System.Drawing.Point(628, 11);
            this.btn2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(208, 159);
            this.btn2.TabIndex = 77;
            this.btn2.Text = "ACTUALIZAR";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // impresoraVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 424);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.txtcantidadtickets);
            this.Controls.Add(this.txtnombreimpresora);
            this.Controls.Add(this.txtcodigoimpresora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgimpresora);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "impresoraVista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.impresoraVista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgimpresora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcantidadtickets;
        private System.Windows.Forms.TextBox txtnombreimpresora;
        private System.Windows.Forms.TextBox txtcodigoimpresora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgimpresora;
        private System.Windows.Forms.DataGridViewTextBoxColumn idusuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.Button btn2;
    }
}