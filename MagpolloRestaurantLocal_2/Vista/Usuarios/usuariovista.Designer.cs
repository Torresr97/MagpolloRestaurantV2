
namespace AppTRchicken.Vista
{
    partial class usuariovista
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
            this.dgusuarios = new System.Windows.Forms.DataGridView();
            this.idusuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contrasena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechacreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.txtcodigousuario = new System.Windows.Forms.TextBox();
            this.txtnombreusuario = new System.Windows.Forms.TextBox();
            this.txtapellidousuario = new System.Windows.Forms.TextBox();
            this.txtcontrausuario = new System.Windows.Forms.TextBox();
            this.cbroleusuario = new System.Windows.Forms.ComboBox();
            this.dtfechacreacionusuario = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgusuarios)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgusuarios
            // 
            this.dgusuarios.AllowUserToAddRows = false;
            this.dgusuarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgusuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgusuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgusuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idusuario,
            this.nombre,
            this.apellido,
            this.contrasena,
            this.role,
            this.fechacreacion});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgusuarios.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgusuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgusuarios.Location = new System.Drawing.Point(0, 0);
            this.dgusuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgusuarios.Name = "dgusuarios";
            this.dgusuarios.ReadOnly = true;
            this.dgusuarios.RowHeadersVisible = false;
            this.dgusuarios.RowHeadersWidth = 51;
            this.dgusuarios.RowTemplate.Height = 24;
            this.dgusuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgusuarios.Size = new System.Drawing.Size(1261, 329);
            this.dgusuarios.TabIndex = 0;
            this.dgusuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgusuarios_CellClick);
            // 
            // idusuario
            // 
            this.idusuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idusuario.FillWeight = 76.51117F;
            this.idusuario.HeaderText = "Codigo de Usuario";
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
            this.apellido.HeaderText = "Apellido";
            this.apellido.MinimumWidth = 6;
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            // 
            // contrasena
            // 
            this.contrasena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.contrasena.FillWeight = 127.7737F;
            this.contrasena.HeaderText = "Contrasena";
            this.contrasena.MinimumWidth = 6;
            this.contrasena.Name = "contrasena";
            this.contrasena.ReadOnly = true;
            // 
            // role
            // 
            this.role.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.role.FillWeight = 70.37195F;
            this.role.HeaderText = "Role";
            this.role.MinimumWidth = 6;
            this.role.Name = "role";
            this.role.ReadOnly = true;
            // 
            // fechacreacion
            // 
            this.fechacreacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fechacreacion.FillWeight = 127.7737F;
            this.fechacreacion.HeaderText = "Fecha de Creacion";
            this.fechacreacion.MinimumWidth = 6;
            this.fechacreacion.Name = "fechacreacion";
            this.fechacreacion.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(123, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 27);
            this.label3.TabIndex = 42;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 27);
            this.label2.TabIndex = 41;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 27);
            this.label1.TabIndex = 40;
            this.label1.Text = "Codigo de Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(123, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 27);
            this.label4.TabIndex = 45;
            this.label4.Text = "Fecha de Creacion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(123, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 27);
            this.label5.TabIndex = 44;
            this.label5.Text = "Role";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(123, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 27);
            this.label6.TabIndex = 43;
            this.label6.Text = "Contrasena";
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn3.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.btn3.Location = new System.Drawing.Point(780, 422);
            this.btn3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(277, 89);
            this.btn3.TabIndex = 48;
            this.btn3.Text = "ELIMINAR";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn2.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.btn2.Location = new System.Drawing.Point(458, 422);
            this.btn2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(277, 89);
            this.btn2.TabIndex = 47;
            this.btn2.Text = "ACTUALIZAR";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn1.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.btn1.Location = new System.Drawing.Point(128, 422);
            this.btn1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(277, 87);
            this.btn1.TabIndex = 46;
            this.btn1.Text = "NUEVO";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // txtcodigousuario
            // 
            this.txtcodigousuario.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txtcodigousuario.Location = new System.Drawing.Point(467, 15);
            this.txtcodigousuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcodigousuario.Name = "txtcodigousuario";
            this.txtcodigousuario.ReadOnly = true;
            this.txtcodigousuario.Size = new System.Drawing.Size(441, 34);
            this.txtcodigousuario.TabIndex = 49;
            // 
            // txtnombreusuario
            // 
            this.txtnombreusuario.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txtnombreusuario.Location = new System.Drawing.Point(467, 75);
            this.txtnombreusuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnombreusuario.Name = "txtnombreusuario";
            this.txtnombreusuario.Size = new System.Drawing.Size(441, 34);
            this.txtnombreusuario.TabIndex = 50;
            // 
            // txtapellidousuario
            // 
            this.txtapellidousuario.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txtapellidousuario.Location = new System.Drawing.Point(467, 137);
            this.txtapellidousuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtapellidousuario.Name = "txtapellidousuario";
            this.txtapellidousuario.Size = new System.Drawing.Size(441, 34);
            this.txtapellidousuario.TabIndex = 51;
            // 
            // txtcontrausuario
            // 
            this.txtcontrausuario.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txtcontrausuario.Location = new System.Drawing.Point(467, 209);
            this.txtcontrausuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcontrausuario.Name = "txtcontrausuario";
            this.txtcontrausuario.Size = new System.Drawing.Size(441, 34);
            this.txtcontrausuario.TabIndex = 52;
            // 
            // cbroleusuario
            // 
            this.cbroleusuario.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.cbroleusuario.FormattingEnabled = true;
            this.cbroleusuario.Location = new System.Drawing.Point(467, 272);
            this.cbroleusuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbroleusuario.Name = "cbroleusuario";
            this.cbroleusuario.Size = new System.Drawing.Size(441, 34);
            this.cbroleusuario.TabIndex = 55;
            // 
            // dtfechacreacionusuario
            // 
            this.dtfechacreacionusuario.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtfechacreacionusuario.Location = new System.Drawing.Point(467, 338);
            this.dtfechacreacionusuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtfechacreacionusuario.Name = "dtfechacreacionusuario";
            this.dtfechacreacionusuario.Size = new System.Drawing.Size(441, 31);
            this.dtfechacreacionusuario.TabIndex = 56;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtfechacreacionusuario);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbroleusuario);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtcontrausuario);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtapellidousuario);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtnombreusuario);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtcodigousuario);
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Controls.Add(this.btn3);
            this.panel1.Controls.Add(this.btn2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1261, 529);
            this.panel1.TabIndex = 57;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgusuarios);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 529);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1261, 329);
            this.panel2.TabIndex = 58;
            // 
            // usuariovista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 858);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "usuariovista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.usuariovista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgusuarios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgusuarios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txtcodigousuario;
        private System.Windows.Forms.TextBox txtnombreusuario;
        private System.Windows.Forms.TextBox txtapellidousuario;
        private System.Windows.Forms.TextBox txtcontrausuario;
        private System.Windows.Forms.ComboBox cbroleusuario;
        private System.Windows.Forms.DateTimePicker dtfechacreacionusuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn idusuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn contrasena;
        private System.Windows.Forms.DataGridViewTextBoxColumn role;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechacreacion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}