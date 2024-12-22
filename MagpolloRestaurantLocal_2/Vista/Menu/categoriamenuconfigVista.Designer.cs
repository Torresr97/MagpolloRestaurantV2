
namespace AppTRchicken.Vista
{
    partial class categoriamenuconfigVista
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
            this.txtnombrecategoria = new System.Windows.Forms.TextBox();
            this.txtcodigocategoria = new System.Windows.Forms.TextBox();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgcategoriamenu = new System.Windows.Forms.DataGridView();
            this.idcategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgcategoriamenu)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtnombrecategoria
            // 
            this.txtnombrecategoria.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txtnombrecategoria.Location = new System.Drawing.Point(379, 74);
            this.txtnombrecategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnombrecategoria.Name = "txtnombrecategoria";
            this.txtnombrecategoria.Size = new System.Drawing.Size(441, 34);
            this.txtnombrecategoria.TabIndex = 65;
            // 
            // txtcodigocategoria
            // 
            this.txtcodigocategoria.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txtcodigocategoria.Location = new System.Drawing.Point(379, 14);
            this.txtcodigocategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcodigocategoria.Name = "txtcodigocategoria";
            this.txtcodigocategoria.ReadOnly = true;
            this.txtcodigocategoria.Size = new System.Drawing.Size(441, 34);
            this.txtcodigocategoria.TabIndex = 64;
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn3.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.btn3.Location = new System.Drawing.Point(718, 142);
            this.btn3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(243, 79);
            this.btn3.TabIndex = 63;
            this.btn3.Text = "ELIMINAR";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn2.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.btn2.Location = new System.Drawing.Point(434, 142);
            this.btn2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(243, 79);
            this.btn2.TabIndex = 62;
            this.btn2.Text = "ACTUALIZAR";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn1.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.btn1.Location = new System.Drawing.Point(143, 142);
            this.btn1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(243, 78);
            this.btn1.TabIndex = 61;
            this.btn1.Text = "NUEVO";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(261, 27);
            this.label6.TabIndex = 59;
            this.label6.Text = "Nombre de Categoria";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 27);
            this.label1.TabIndex = 58;
            this.label1.Text = "Codigo de Categoria";
            // 
            // dgcategoriamenu
            // 
            this.dgcategoriamenu.AllowUserToAddRows = false;
            this.dgcategoriamenu.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgcategoriamenu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgcategoriamenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgcategoriamenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcategoria,
            this.categoria});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgcategoriamenu.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgcategoriamenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgcategoriamenu.Location = new System.Drawing.Point(0, 0);
            this.dgcategoriamenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgcategoriamenu.Name = "dgcategoriamenu";
            this.dgcategoriamenu.ReadOnly = true;
            this.dgcategoriamenu.RowHeadersVisible = false;
            this.dgcategoriamenu.RowHeadersWidth = 51;
            this.dgcategoriamenu.RowTemplate.Height = 24;
            this.dgcategoriamenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgcategoriamenu.Size = new System.Drawing.Size(1028, 263);
            this.dgcategoriamenu.TabIndex = 57;
            this.dgcategoriamenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgcategoriamenu_CellContentClick);
            // 
            // idcategoria
            // 
            this.idcategoria.HeaderText = "Codigo de Categoria";
            this.idcategoria.MinimumWidth = 6;
            this.idcategoria.Name = "idcategoria";
            this.idcategoria.ReadOnly = true;
            this.idcategoria.Width = 180;
            // 
            // categoria
            // 
            this.categoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.categoria.HeaderText = "Nombre de Categoria";
            this.categoria.MinimumWidth = 6;
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtnombrecategoria);
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Controls.Add(this.txtcodigocategoria);
            this.panel1.Controls.Add(this.btn2);
            this.panel1.Controls.Add(this.btn3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 267);
            this.panel1.TabIndex = 66;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgcategoriamenu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 267);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1028, 263);
            this.panel2.TabIndex = 67;
            // 
            // categoriamenuconfigVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 530);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "categoriamenuconfigVista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.categoriamenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgcategoriamenu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtnombrecategoria;
        private System.Windows.Forms.TextBox txtcodigocategoria;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgcategoriamenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}