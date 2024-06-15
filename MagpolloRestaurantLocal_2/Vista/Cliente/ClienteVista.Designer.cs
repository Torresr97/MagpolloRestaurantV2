
namespace AppTRchicken.Vista
{
    partial class ClienteVista
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
            this.dgclientes = new System.Windows.Forms.DataGridView();
            this.idrole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrerole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actualizar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.txtcorreocliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcelularcliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtrtncliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnombrecliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtidcliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgclientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgclientes
            // 
            this.dgclientes.AllowUserToAddRows = false;
            this.dgclientes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgclientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgclientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idrole,
            this.nombrerole,
            this.crear,
            this.actualizar,
            this.eliminar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgclientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgclientes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgclientes.Location = new System.Drawing.Point(0, 496);
            this.dgclientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgclientes.Name = "dgclientes";
            this.dgclientes.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgclientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgclientes.RowHeadersVisible = false;
            this.dgclientes.RowHeadersWidth = 51;
            this.dgclientes.RowTemplate.Height = 24;
            this.dgclientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgclientes.Size = new System.Drawing.Size(1075, 265);
            this.dgclientes.TabIndex = 56;
            this.dgclientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgclientes_CellClick);
            // 
            // idrole
            // 
            this.idrole.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idrole.FillWeight = 42.78075F;
            this.idrole.HeaderText = "Codigo de Cliente";
            this.idrole.MinimumWidth = 6;
            this.idrole.Name = "idrole";
            this.idrole.ReadOnly = true;
            // 
            // nombrerole
            // 
            this.nombrerole.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombrerole.FillWeight = 157.2193F;
            this.nombrerole.HeaderText = "Nombre";
            this.nombrerole.MinimumWidth = 6;
            this.nombrerole.Name = "nombrerole";
            this.nombrerole.ReadOnly = true;
            // 
            // crear
            // 
            this.crear.HeaderText = "RTN";
            this.crear.MinimumWidth = 6;
            this.crear.Name = "crear";
            this.crear.ReadOnly = true;
            this.crear.Width = 125;
            // 
            // actualizar
            // 
            this.actualizar.HeaderText = "Celular";
            this.actualizar.MinimumWidth = 6;
            this.actualizar.Name = "actualizar";
            this.actualizar.ReadOnly = true;
            this.actualizar.Width = 125;
            // 
            // eliminar
            // 
            this.eliminar.HeaderText = "Correo";
            this.eliminar.MinimumWidth = 6;
            this.eliminar.Name = "eliminar";
            this.eliminar.ReadOnly = true;
            this.eliminar.Width = 125;
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn3.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.btn3.Location = new System.Drawing.Point(664, 345);
            this.btn3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(277, 89);
            this.btn3.TabIndex = 55;
            this.btn3.Text = "ELIMINAR";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn2.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.btn2.Location = new System.Drawing.Point(335, 345);
            this.btn2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(277, 89);
            this.btn2.TabIndex = 54;
            this.btn2.Text = "ACTUALIZAR";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn1.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.btn1.Location = new System.Drawing.Point(12, 345);
            this.btn1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(277, 87);
            this.btn1.TabIndex = 53;
            this.btn1.Text = "NUEVO";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // txtcorreocliente
            // 
            this.txtcorreocliente.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txtcorreocliente.Location = new System.Drawing.Point(322, 247);
            this.txtcorreocliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcorreocliente.Name = "txtcorreocliente";
            this.txtcorreocliente.Size = new System.Drawing.Size(441, 34);
            this.txtcorreocliente.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 27);
            this.label5.TabIndex = 51;
            this.label5.Text = "Correo";
            // 
            // txtcelularcliente
            // 
            this.txtcelularcliente.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txtcelularcliente.Location = new System.Drawing.Point(322, 192);
            this.txtcelularcliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcelularcliente.Name = "txtcelularcliente";
            this.txtcelularcliente.Size = new System.Drawing.Size(441, 34);
            this.txtcelularcliente.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 27);
            this.label4.TabIndex = 49;
            this.label4.Text = "Celular";
            // 
            // txtrtncliente
            // 
            this.txtrtncliente.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txtrtncliente.Location = new System.Drawing.Point(322, 134);
            this.txtrtncliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtrtncliente.Name = "txtrtncliente";
            this.txtrtncliente.Size = new System.Drawing.Size(441, 34);
            this.txtrtncliente.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 27);
            this.label3.TabIndex = 47;
            this.label3.Text = "RTN";
            // 
            // txtnombrecliente
            // 
            this.txtnombrecliente.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txtnombrecliente.Location = new System.Drawing.Point(322, 76);
            this.txtnombrecliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnombrecliente.Name = "txtnombrecliente";
            this.txtnombrecliente.Size = new System.Drawing.Size(441, 34);
            this.txtnombrecliente.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 27);
            this.label2.TabIndex = 45;
            this.label2.Text = "Nombre";
            // 
            // txtidcliente
            // 
            this.txtidcliente.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txtidcliente.Location = new System.Drawing.Point(322, 25);
            this.txtidcliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtidcliente.Name = "txtidcliente";
            this.txtidcliente.ReadOnly = true;
            this.txtidcliente.Size = new System.Drawing.Size(441, 34);
            this.txtidcliente.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 27);
            this.label1.TabIndex = 43;
            this.label1.Text = "Codigo de Cliente";
            // 
            // ClienteVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 761);
            this.Controls.Add(this.dgclientes);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtcorreocliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtcelularcliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtrtncliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnombrecliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtidcliente);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ClienteVista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ClienteVista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgclientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgclientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn idrole;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrerole;
        private System.Windows.Forms.DataGridViewTextBoxColumn crear;
        private System.Windows.Forms.DataGridViewTextBoxColumn actualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn eliminar;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txtcorreocliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcelularcliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtrtncliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnombrecliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtidcliente;
        private System.Windows.Forms.Label label1;
    }
}