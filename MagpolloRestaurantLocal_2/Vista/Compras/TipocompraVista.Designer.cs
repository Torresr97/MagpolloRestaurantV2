
namespace AppTRchicken.Vista
{
    partial class TipocompraVista
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
            this.dgtipocompra = new System.Windows.Forms.DataGridView();
            this.Codigotipocompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipocompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtnombretipocompra = new System.Windows.Forms.TextBox();
            this.txtcodigotipocompra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgtipocompra)).BeginInit();
            this.SuspendLayout();
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn3.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.btn3.Location = new System.Drawing.Point(677, 175);
            this.btn3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(277, 89);
            this.btn3.TabIndex = 87;
            this.btn3.Text = "ELIMINAR";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn2.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.btn2.Location = new System.Drawing.Point(355, 175);
            this.btn2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(277, 89);
            this.btn2.TabIndex = 86;
            this.btn2.Text = "ACTUALIZAR";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn1.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.btn1.Location = new System.Drawing.Point(25, 175);
            this.btn1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(277, 87);
            this.btn1.TabIndex = 85;
            this.btn1.Text = "NUEVO";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // dgtipocompra
            // 
            this.dgtipocompra.AllowUserToAddRows = false;
            this.dgtipocompra.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgtipocompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgtipocompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtipocompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigotipocompra,
            this.tipocompra});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgtipocompra.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgtipocompra.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgtipocompra.Location = new System.Drawing.Point(0, 355);
            this.dgtipocompra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgtipocompra.Name = "dgtipocompra";
            this.dgtipocompra.ReadOnly = true;
            this.dgtipocompra.RowHeadersVisible = false;
            this.dgtipocompra.RowHeadersWidth = 51;
            this.dgtipocompra.RowTemplate.Height = 24;
            this.dgtipocompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgtipocompra.Size = new System.Drawing.Size(1030, 299);
            this.dgtipocompra.TabIndex = 84;
            this.dgtipocompra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtipocompra_CellClick_1);
            // 
            // Codigotipocompra
            // 
            this.Codigotipocompra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Codigotipocompra.FillWeight = 74.86631F;
            this.Codigotipocompra.HeaderText = "Codigo Tipo Compra";
            this.Codigotipocompra.MinimumWidth = 6;
            this.Codigotipocompra.Name = "Codigotipocompra";
            this.Codigotipocompra.ReadOnly = true;
            // 
            // tipocompra
            // 
            this.tipocompra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tipocompra.FillWeight = 125.1337F;
            this.tipocompra.HeaderText = "Tipo de Compra";
            this.tipocompra.MinimumWidth = 6;
            this.tipocompra.Name = "tipocompra";
            this.tipocompra.ReadOnly = true;
            // 
            // txtnombretipocompra
            // 
            this.txtnombretipocompra.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txtnombretipocompra.Location = new System.Drawing.Point(306, 73);
            this.txtnombretipocompra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnombretipocompra.Name = "txtnombretipocompra";
            this.txtnombretipocompra.Size = new System.Drawing.Size(441, 34);
            this.txtnombretipocompra.TabIndex = 83;
            // 
            // txtcodigotipocompra
            // 
            this.txtcodigotipocompra.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txtcodigotipocompra.Location = new System.Drawing.Point(306, 7);
            this.txtcodigotipocompra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcodigotipocompra.Name = "txtcodigotipocompra";
            this.txtcodigotipocompra.ReadOnly = true;
            this.txtcodigotipocompra.Size = new System.Drawing.Size(154, 34);
            this.txtcodigotipocompra.TabIndex = 82;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 27);
            this.label2.TabIndex = 81;
            this.label2.Text = "Tipo Compra";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 27);
            this.label1.TabIndex = 80;
            this.label1.Text = "Codigo Tipo Compra";
            // 
            // TipocompraVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 654);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.dgtipocompra);
            this.Controls.Add(this.txtnombretipocompra);
            this.Controls.Add(this.txtcodigotipocompra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TipocompraVista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.TipocompraVista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgtipocompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.DataGridView dgtipocompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigotipocompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipocompra;
        private System.Windows.Forms.TextBox txtnombretipocompra;
        private System.Windows.Forms.TextBox txtcodigotipocompra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}