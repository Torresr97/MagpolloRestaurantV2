
namespace AppTRchicken.Vista.Inventario
{
    partial class EntradainventariomasivoVista
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnagregar = new System.Windows.Forms.Button();
            this.dginventario = new System.Windows.Forms.DataGridView();
            this.codigoinv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreinv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.existencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadingresar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dginventario)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnagregar.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.btnagregar.Location = new System.Drawing.Point(3, 17);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(161, 40);
            this.btnagregar.TabIndex = 107;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // dginventario
            // 
            this.dginventario.AllowUserToAddRows = false;
            this.dginventario.AllowUserToDeleteRows = false;
            this.dginventario.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dginventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dginventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dginventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoinv,
            this.nombreinv,
            this.existencia,
            this.cantidadingresar});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dginventario.DefaultCellStyle = dataGridViewCellStyle6;
            this.dginventario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dginventario.Location = new System.Drawing.Point(0, 0);
            this.dginventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dginventario.Name = "dginventario";
            this.dginventario.RowHeadersVisible = false;
            this.dginventario.RowHeadersWidth = 51;
            this.dginventario.RowTemplate.Height = 24;
            this.dginventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dginventario.Size = new System.Drawing.Size(1284, 676);
            this.dginventario.TabIndex = 106;
            // 
            // codigoinv
            // 
            this.codigoinv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codigoinv.FillWeight = 65.14816F;
            this.codigoinv.HeaderText = "Cod. Inventario";
            this.codigoinv.MinimumWidth = 6;
            this.codigoinv.Name = "codigoinv";
            // 
            // nombreinv
            // 
            this.nombreinv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreinv.FillWeight = 224.2803F;
            this.nombreinv.HeaderText = "Producto";
            this.nombreinv.MinimumWidth = 6;
            this.nombreinv.Name = "nombreinv";
            // 
            // existencia
            // 
            this.existencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.existencia.FillWeight = 63.47713F;
            this.existencia.HeaderText = "Existencia";
            this.existencia.MinimumWidth = 6;
            this.existencia.Name = "existencia";
            // 
            // cantidadingresar
            // 
            this.cantidadingresar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cantidadingresar.FillWeight = 54.46074F;
            this.cantidadingresar.HeaderText = "Cantidad Ingresar";
            this.cantidadingresar.MinimumWidth = 6;
            this.cantidadingresar.Name = "cantidadingresar";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnagregar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1284, 61);
            this.panel1.TabIndex = 108;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dginventario);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1284, 676);
            this.panel2.TabIndex = 109;
            // 
            // EntradainventariomasivoVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 737);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EntradainventariomasivoVista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.EntradainventariomasivoVista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dginventario)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.DataGridView dginventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoinv;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreinv;
        private System.Windows.Forms.DataGridViewTextBoxColumn existencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadingresar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}