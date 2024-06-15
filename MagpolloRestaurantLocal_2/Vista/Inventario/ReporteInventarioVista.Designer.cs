
namespace AppTRchicken.Vista.Inventario
{
    partial class ReporteInventarioVista
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
            this.dgreporteinventario = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btntodos = new System.Windows.Forms.Button();
            this.idinventario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.existencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgreporteinventario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgreporteinventario
            // 
            this.dgreporteinventario.AllowUserToAddRows = false;
            this.dgreporteinventario.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgreporteinventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgreporteinventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgreporteinventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idinventario,
            this.producto,
            this.existencia});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgreporteinventario.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgreporteinventario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgreporteinventario.Location = new System.Drawing.Point(0, 90);
            this.dgreporteinventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgreporteinventario.Name = "dgreporteinventario";
            this.dgreporteinventario.ReadOnly = true;
            this.dgreporteinventario.RowHeadersVisible = false;
            this.dgreporteinventario.RowHeadersWidth = 51;
            this.dgreporteinventario.RowTemplate.Height = 24;
            this.dgreporteinventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgreporteinventario.Size = new System.Drawing.Size(1051, 660);
            this.dgreporteinventario.TabIndex = 95;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 27);
            this.label1.TabIndex = 96;
            this.label1.Text = "Inventario Actual";
            // 
            // btntodos
            // 
            this.btntodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btntodos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btntodos.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.btntodos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntodos.Location = new System.Drawing.Point(893, 48);
            this.btntodos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btntodos.Name = "btntodos";
            this.btntodos.Size = new System.Drawing.Size(135, 38);
            this.btntodos.TabIndex = 122;
            this.btntodos.Text = "Imprimir";
            this.btntodos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntodos.UseVisualStyleBackColor = false;
            this.btntodos.Click += new System.EventHandler(this.btntodos_Click);
            // 
            // idinventario
            // 
            this.idinventario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idinventario.FillWeight = 69.64193F;
            this.idinventario.HeaderText = "Cod. Inventario";
            this.idinventario.MinimumWidth = 6;
            this.idinventario.Name = "idinventario";
            this.idinventario.ReadOnly = true;
            // 
            // producto
            // 
            this.producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.producto.FillWeight = 182.2297F;
            this.producto.HeaderText = "Producto";
            this.producto.MinimumWidth = 6;
            this.producto.Name = "producto";
            this.producto.ReadOnly = true;
            // 
            // existencia
            // 
            this.existencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.existencia.FillWeight = 48.12834F;
            this.existencia.HeaderText = "Existencia";
            this.existencia.MinimumWidth = 6;
            this.existencia.Name = "existencia";
            this.existencia.ReadOnly = true;
            // 
            // ReporteInventarioVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 750);
            this.Controls.Add(this.btntodos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgreporteinventario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReporteInventarioVista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ReporteInventarioVista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgreporteinventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgreporteinventario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btntodos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idinventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn existencia;
    }
}