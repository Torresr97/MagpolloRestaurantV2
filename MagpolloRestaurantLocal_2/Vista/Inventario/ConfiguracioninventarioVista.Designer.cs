
namespace AppTRchicken.Vista.Inventario
{
    partial class ConfiguracioninventarioVista
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
            this.cbproductoinventario = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbmenu = new System.Windows.Forms.ComboBox();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgentradainventario = new System.Windows.Forms.DataGridView();
            this.btnagregar = new System.Windows.Forms.Button();
            this.idconfiginventario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acc = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgentradainventario)).BeginInit();
            this.SuspendLayout();
            // 
            // cbproductoinventario
            // 
            this.cbproductoinventario.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.cbproductoinventario.FormattingEnabled = true;
            this.cbproductoinventario.Location = new System.Drawing.Point(302, 79);
            this.cbproductoinventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbproductoinventario.Name = "cbproductoinventario";
            this.cbproductoinventario.Size = new System.Drawing.Size(528, 34);
            this.cbproductoinventario.TabIndex = 93;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 27);
            this.label1.TabIndex = 92;
            this.label1.Text = "Producto Inventario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 27);
            this.label2.TabIndex = 94;
            this.label2.Text = "Menu";
            // 
            // cbmenu
            // 
            this.cbmenu.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.cbmenu.FormattingEnabled = true;
            this.cbmenu.Location = new System.Drawing.Point(302, 21);
            this.cbmenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbmenu.Name = "cbmenu";
            this.cbmenu.Size = new System.Drawing.Size(528, 34);
            this.cbmenu.TabIndex = 95;
            this.cbmenu.SelectedIndexChanged += new System.EventHandler(this.cbmenu_SelectedIndexChanged);
            // 
            // txtcantidad
            // 
            this.txtcantidad.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txtcantidad.Location = new System.Drawing.Point(302, 141);
            this.txtcantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(153, 34);
            this.txtcantidad.TabIndex = 104;
            this.txtcantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcantidad_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 27);
            this.label3.TabIndex = 103;
            this.label3.Text = "Cantidad (-)";
            // 
            // dgentradainventario
            // 
            this.dgentradainventario.AllowUserToAddRows = false;
            this.dgentradainventario.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgentradainventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgentradainventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgentradainventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idconfiginventario,
            this.menu,
            this.inventario,
            this.cantidad,
            this.acc});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgentradainventario.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgentradainventario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgentradainventario.Location = new System.Drawing.Point(0, 344);
            this.dgentradainventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgentradainventario.Name = "dgentradainventario";
            this.dgentradainventario.ReadOnly = true;
            this.dgentradainventario.RowHeadersVisible = false;
            this.dgentradainventario.RowHeadersWidth = 51;
            this.dgentradainventario.RowTemplate.Height = 24;
            this.dgentradainventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgentradainventario.Size = new System.Drawing.Size(1000, 299);
            this.dgentradainventario.TabIndex = 105;
            this.dgentradainventario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgentradainventario_CellContentClick);
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnagregar.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.btnagregar.Location = new System.Drawing.Point(302, 211);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(221, 87);
            this.btnagregar.TabIndex = 106;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // idconfiginventario
            // 
            this.idconfiginventario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idconfiginventario.HeaderText = "Cod.ConfigInv";
            this.idconfiginventario.MinimumWidth = 6;
            this.idconfiginventario.Name = "idconfiginventario";
            this.idconfiginventario.ReadOnly = true;
            // 
            // menu
            // 
            this.menu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.menu.HeaderText = "Menu";
            this.menu.MinimumWidth = 6;
            this.menu.Name = "menu";
            this.menu.ReadOnly = true;
            // 
            // inventario
            // 
            this.inventario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.inventario.HeaderText = "Inventario";
            this.inventario.MinimumWidth = 6;
            this.inventario.Name = "inventario";
            this.inventario.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.MinimumWidth = 6;
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // acc
            // 
            this.acc.HeaderText = "ACC";
            this.acc.Image = global::AppTRchicken.Properties.Resources.cerca__2_;
            this.acc.MinimumWidth = 6;
            this.acc.Name = "acc";
            this.acc.ReadOnly = true;
            this.acc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ConfiguracioninventarioVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 643);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.dgentradainventario);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbmenu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbproductoinventario);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ConfiguracioninventarioVista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ConfiguracioninventarioViata_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgentradainventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbproductoinventario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbmenu;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgentradainventario;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idconfiginventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn menu;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewImageColumn acc;
    }
}