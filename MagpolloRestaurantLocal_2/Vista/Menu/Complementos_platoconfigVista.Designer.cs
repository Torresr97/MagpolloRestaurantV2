
namespace AppTRchicken.Vista
{
    partial class Complementos_platoconfigVista
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
            this.btn3 = new System.Windows.Forms.Button();
            this.dgcomplementosplato = new System.Windows.Forms.DataGridView();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.txtnombrecomplemento = new System.Windows.Forms.TextBox();
            this.txtidcomplementoplato = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbtipocomplemento = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.idcomplementoplaato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrecomplemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipocomplementoplato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgcomplementosplato)).BeginInit();
            this.SuspendLayout();
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn3.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.btn3.Location = new System.Drawing.Point(717, 251);
            this.btn3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(277, 89);
            this.btn3.TabIndex = 50;
            this.btn3.Text = "ELIMINAR";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // dgcomplementosplato
            // 
            this.dgcomplementosplato.AllowUserToAddRows = false;
            this.dgcomplementosplato.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgcomplementosplato.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgcomplementosplato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgcomplementosplato.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcomplementoplaato,
            this.nombrecomplemento,
            this.tipocomplementoplato});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgcomplementosplato.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgcomplementosplato.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgcomplementosplato.Location = new System.Drawing.Point(0, 390);
            this.dgcomplementosplato.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgcomplementosplato.Name = "dgcomplementosplato";
            this.dgcomplementosplato.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgcomplementosplato.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgcomplementosplato.RowHeadersVisible = false;
            this.dgcomplementosplato.RowHeadersWidth = 51;
            this.dgcomplementosplato.RowTemplate.Height = 24;
            this.dgcomplementosplato.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgcomplementosplato.Size = new System.Drawing.Size(1133, 247);
            this.dgcomplementosplato.TabIndex = 49;
            this.dgcomplementosplato.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgcomplementosplato_CellClick);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn2.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.btn2.Location = new System.Drawing.Point(388, 251);
            this.btn2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(277, 89);
            this.btn2.TabIndex = 48;
            this.btn2.Text = "ACTUALIZAR";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn1.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.btn1.Location = new System.Drawing.Point(65, 251);
            this.btn1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(277, 87);
            this.btn1.TabIndex = 47;
            this.btn1.Text = "NUEVO";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // txtnombrecomplemento
            // 
            this.txtnombrecomplemento.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txtnombrecomplemento.Location = new System.Drawing.Point(378, 74);
            this.txtnombrecomplemento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnombrecomplemento.Name = "txtnombrecomplemento";
            this.txtnombrecomplemento.Size = new System.Drawing.Size(441, 34);
            this.txtnombrecomplemento.TabIndex = 46;
            // 
            // txtidcomplementoplato
            // 
            this.txtidcomplementoplato.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txtidcomplementoplato.Location = new System.Drawing.Point(378, 15);
            this.txtidcomplementoplato.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtidcomplementoplato.Name = "txtidcomplementoplato";
            this.txtidcomplementoplato.ReadOnly = true;
            this.txtidcomplementoplato.Size = new System.Drawing.Size(441, 34);
            this.txtidcomplementoplato.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 27);
            this.label2.TabIndex = 44;
            this.label2.Text = "Nombre del Complemento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 27);
            this.label1.TabIndex = 43;
            this.label1.Text = "Codigo de Complemento";
            // 
            // cbtipocomplemento
            // 
            this.cbtipocomplemento.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.cbtipocomplemento.FormattingEnabled = true;
            this.cbtipocomplemento.Location = new System.Drawing.Point(378, 136);
            this.cbtipocomplemento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbtipocomplemento.Name = "cbtipocomplemento";
            this.cbtipocomplemento.Size = new System.Drawing.Size(441, 34);
            this.cbtipocomplemento.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 27);
            this.label5.TabIndex = 56;
            this.label5.Text = "Tipo Complemento";
            // 
            // idcomplementoplaato
            // 
            this.idcomplementoplaato.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idcomplementoplaato.FillWeight = 42.78075F;
            this.idcomplementoplaato.HeaderText = "Codigo de Complemento";
            this.idcomplementoplaato.MinimumWidth = 6;
            this.idcomplementoplaato.Name = "idcomplementoplaato";
            this.idcomplementoplaato.ReadOnly = true;
            // 
            // nombrecomplemento
            // 
            this.nombrecomplemento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombrecomplemento.FillWeight = 157.2193F;
            this.nombrecomplemento.HeaderText = "Nombre Complemento";
            this.nombrecomplemento.MinimumWidth = 6;
            this.nombrecomplemento.Name = "nombrecomplemento";
            this.nombrecomplemento.ReadOnly = true;
            // 
            // tipocomplementoplato
            // 
            this.tipocomplementoplato.HeaderText = "Tipo Complemento Plato";
            this.tipocomplementoplato.MinimumWidth = 6;
            this.tipocomplementoplato.Name = "tipocomplementoplato";
            this.tipocomplementoplato.ReadOnly = true;
            this.tipocomplementoplato.Width = 125;
            // 
            // Complementos_platoconfigVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 637);
            this.Controls.Add(this.cbtipocomplemento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.dgcomplementosplato);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtnombrecomplemento);
            this.Controls.Add(this.txtidcomplementoplato);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Complementos_platoconfigVista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Complementos_platoVista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgcomplementosplato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.DataGridView dgcomplementosplato;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txtnombrecomplemento;
        private System.Windows.Forms.TextBox txtidcomplementoplato;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbtipocomplemento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcomplementoplaato;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrecomplemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipocomplementoplato;
    }
}