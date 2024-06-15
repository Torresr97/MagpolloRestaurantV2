
namespace AppTRchicken.Vista
{
    partial class Facturaciosvista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facturaciosvista));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelfacturacion = new System.Windows.Forms.TableLayoutPanel();
            this.lblusuario = new System.Windows.Forms.Label();
            this.btnregresarconfiguraciones = new System.Windows.Forms.Button();
            this.dgfacturacion = new System.Windows.Forms.DataGridView();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comentario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACC = new System.Windows.Forms.DataGridViewImageColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tpanelmenu = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnListaFacturasVista = new System.Windows.Forms.Button();
            this.cmbcliente = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtdescuento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtisv = new System.Windows.Forms.TextBox();
            this.txtsubtotal = new System.Windows.Forms.TextBox();
            this.txtexonerado = new System.Windows.Forms.TextBox();
            this.txtexcento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelfacturacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgfacturacion)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelfacturacion
            // 
            this.panelfacturacion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelfacturacion.ColumnCount = 4;
            this.panelfacturacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelfacturacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelfacturacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelfacturacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelfacturacion.Controls.Add(this.lblusuario, 3, 1);
            this.panelfacturacion.Controls.Add(this.btnregresarconfiguraciones, 0, 0);
            this.panelfacturacion.Controls.Add(this.dgfacturacion, 0, 2);
            this.panelfacturacion.Controls.Add(this.dateTimePicker1, 3, 0);
            this.panelfacturacion.Controls.Add(this.tpanelmenu, 0, 3);
            this.panelfacturacion.Controls.Add(this.button2, 3, 4);
            this.panelfacturacion.Controls.Add(this.button1, 1, 0);
            this.panelfacturacion.Controls.Add(this.btnListaFacturasVista, 2, 0);
            this.panelfacturacion.Controls.Add(this.cmbcliente, 1, 1);
            this.panelfacturacion.Controls.Add(this.label6, 0, 1);
            this.panelfacturacion.Controls.Add(this.groupBox1, 0, 4);
            this.panelfacturacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelfacturacion.Location = new System.Drawing.Point(0, 0);
            this.panelfacturacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelfacturacion.Name = "panelfacturacion";
            this.panelfacturacion.RowCount = 6;
            this.panelfacturacion.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelfacturacion.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelfacturacion.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelfacturacion.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelfacturacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.panelfacturacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelfacturacion.Size = new System.Drawing.Size(1387, 980);
            this.panelfacturacion.TabIndex = 9;
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblusuario.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblusuario.Location = new System.Drawing.Point(1041, 68);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(138, 53);
            this.lblusuario.TabIndex = 18;
            this.lblusuario.Text = "Usuario:";
            this.lblusuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnregresarconfiguraciones
            // 
            this.btnregresarconfiguraciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnregresarconfiguraciones.BackColor = System.Drawing.Color.SeaShell;
            this.btnregresarconfiguraciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregresarconfiguraciones.Font = new System.Drawing.Font("Bookman Old Style", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregresarconfiguraciones.Image = ((System.Drawing.Image)(resources.GetObject("btnregresarconfiguraciones.Image")));
            this.btnregresarconfiguraciones.Location = new System.Drawing.Point(3, 2);
            this.btnregresarconfiguraciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnregresarconfiguraciones.Name = "btnregresarconfiguraciones";
            this.btnregresarconfiguraciones.Size = new System.Drawing.Size(340, 64);
            this.btnregresarconfiguraciones.TabIndex = 3;
            this.btnregresarconfiguraciones.UseVisualStyleBackColor = false;
            this.btnregresarconfiguraciones.Click += new System.EventHandler(this.btnregresarconfiguraciones_Click);
            // 
            // dgfacturacion
            // 
            this.dgfacturacion.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgfacturacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgfacturacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgfacturacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cantidad,
            this.Producto,
            this.comentario,
            this.descuento,
            this.total,
            this.ACC});
            this.panelfacturacion.SetColumnSpan(this.dgfacturacion, 4);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgfacturacion.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgfacturacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgfacturacion.Location = new System.Drawing.Point(3, 123);
            this.dgfacturacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgfacturacion.Name = "dgfacturacion";
            this.dgfacturacion.RowHeadersVisible = false;
            this.dgfacturacion.RowHeadersWidth = 51;
            this.panelfacturacion.SetRowSpan(this.dgfacturacion, 2);
            this.dgfacturacion.RowTemplate.Height = 24;
            this.dgfacturacion.Size = new System.Drawing.Size(1381, 161);
            this.dgfacturacion.TabIndex = 4;
            this.dgfacturacion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgfacturacion_CellClick);
            this.dgfacturacion.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgfacturacion_CellEndEdit);
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cant";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 70;
            // 
            // Producto
            // 
            this.Producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 6;
            this.Producto.Name = "Producto";
            // 
            // comentario
            // 
            this.comentario.HeaderText = "Comentarios";
            this.comentario.MinimumWidth = 6;
            this.comentario.Name = "comentario";
            this.comentario.Width = 160;
            // 
            // descuento
            // 
            this.descuento.HeaderText = "Desc(%)";
            this.descuento.MinimumWidth = 6;
            this.descuento.Name = "descuento";
            this.descuento.Width = 120;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            this.total.Width = 90;
            // 
            // ACC
            // 
            this.ACC.HeaderText = "ACC";
            this.ACC.Image = ((System.Drawing.Image)(resources.GetObject("ACC.Image")));
            this.ACC.MinimumWidth = 6;
            this.ACC.Name = "ACC";
            this.ACC.Width = 90;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker1.Font = new System.Drawing.Font("Bookman Old Style", 19.8F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(1041, 2);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(343, 46);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // tpanelmenu
            // 
            this.tpanelmenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tpanelmenu.ColumnCount = 1;
            this.panelfacturacion.SetColumnSpan(this.tpanelmenu, 4);
            this.tpanelmenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpanelmenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpanelmenu.Location = new System.Drawing.Point(3, 288);
            this.tpanelmenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpanelmenu.Name = "tpanelmenu";
            this.tpanelmenu.RowCount = 1;
            this.tpanelmenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpanelmenu.Size = new System.Drawing.Size(1381, 458);
            this.tpanelmenu.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.button2.Location = new System.Drawing.Point(1041, 750);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(343, 228);
            this.button2.TabIndex = 13;
            this.button2.Text = "Cobrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.SeaShell;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bookman Old Style", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(349, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(340, 64);
            this.button1.TabIndex = 12;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnListaFacturasVista
            // 
            this.btnListaFacturasVista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListaFacturasVista.BackColor = System.Drawing.Color.SeaShell;
            this.btnListaFacturasVista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaFacturasVista.Font = new System.Drawing.Font("Bookman Old Style", 19.8F, System.Drawing.FontStyle.Bold);
            this.btnListaFacturasVista.Location = new System.Drawing.Point(695, 2);
            this.btnListaFacturasVista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnListaFacturasVista.Name = "btnListaFacturasVista";
            this.btnListaFacturasVista.Size = new System.Drawing.Size(340, 64);
            this.btnListaFacturasVista.TabIndex = 15;
            this.btnListaFacturasVista.Text = " Facturas";
            this.btnListaFacturasVista.UseVisualStyleBackColor = false;
            this.btnListaFacturasVista.Click += new System.EventHandler(this.btnListaFacturasVista_Click);
            // 
            // cmbcliente
            // 
            this.cmbcliente.BackColor = System.Drawing.Color.SeaShell;
            this.panelfacturacion.SetColumnSpan(this.cmbcliente, 2);
            this.cmbcliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbcliente.Font = new System.Drawing.Font("Bookman Old Style", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcliente.FormattingEnabled = true;
            this.cmbcliente.IntegralHeight = false;
            this.cmbcliente.Location = new System.Drawing.Point(349, 70);
            this.cmbcliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbcliente.Name = "cmbcliente";
            this.cmbcliente.Size = new System.Drawing.Size(686, 49);
            this.cmbcliente.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Right;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 19.8F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(193, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 53);
            this.label6.TabIndex = 17;
            this.label6.Text = "Cliente:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.panelfacturacion.SetColumnSpan(this.groupBox1, 3);
            this.groupBox1.Controls.Add(this.txtdescuento);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.txttotal);
            this.groupBox1.Controls.Add(this.txtisv);
            this.groupBox1.Controls.Add(this.txtsubtotal);
            this.groupBox1.Controls.Add(this.txtexonerado);
            this.groupBox1.Controls.Add(this.txtexcento);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 750);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1032, 228);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Totales";
            // 
            // txtdescuento
            // 
            this.txtdescuento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdescuento.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txtdescuento.Location = new System.Drawing.Point(188, 120);
            this.txtdescuento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdescuento.Name = "txtdescuento";
            this.txtdescuento.ReadOnly = true;
            this.txtdescuento.Size = new System.Drawing.Size(123, 34);
            this.txtdescuento.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 27);
            this.label7.TabIndex = 11;
            this.label7.Text = "Descuento:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Font = new System.Drawing.Font("Bookman Old Style", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(687, 22);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(345, 166);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // txttotal
            // 
            this.txttotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txttotal.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txttotal.Location = new System.Drawing.Point(469, 120);
            this.txttotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(123, 34);
            this.txttotal.TabIndex = 9;
            // 
            // txtisv
            // 
            this.txtisv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtisv.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txtisv.Location = new System.Drawing.Point(469, 80);
            this.txtisv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtisv.Name = "txtisv";
            this.txtisv.ReadOnly = true;
            this.txtisv.Size = new System.Drawing.Size(123, 34);
            this.txtisv.TabIndex = 8;
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtsubtotal.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txtsubtotal.Location = new System.Drawing.Point(469, 35);
            this.txtsubtotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.ReadOnly = true;
            this.txtsubtotal.Size = new System.Drawing.Size(123, 34);
            this.txtsubtotal.TabIndex = 7;
            // 
            // txtexonerado
            // 
            this.txtexonerado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtexonerado.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txtexonerado.Location = new System.Drawing.Point(188, 80);
            this.txtexonerado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtexonerado.Name = "txtexonerado";
            this.txtexonerado.ReadOnly = true;
            this.txtexonerado.Size = new System.Drawing.Size(123, 34);
            this.txtexonerado.TabIndex = 6;
            // 
            // txtexcento
            // 
            this.txtexcento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtexcento.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txtexcento.Location = new System.Drawing.Point(188, 35);
            this.txtexcento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtexcento.Name = "txtexcento";
            this.txtexcento.ReadOnly = true;
            this.txtexcento.Size = new System.Drawing.Size(123, 34);
            this.txtexcento.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(387, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(401, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "ISV:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(340, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "SubTotal:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Exonerado:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Excento:";
            // 
            // Facturaciosvista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 980);
            this.Controls.Add(this.panelfacturacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Facturaciosvista";
            this.Load += new System.EventHandler(this.Facturaciosvista_Load);
            this.panelfacturacion.ResumeLayout(false);
            this.panelfacturacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgfacturacion)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panelfacturacion;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Button btnregresarconfiguraciones;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.TableLayoutPanel tpanelmenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnListaFacturasVista;
        private System.Windows.Forms.ComboBox cmbcliente;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.DataGridView dgfacturacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn comentario;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewImageColumn ACC;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.RichTextBox richTextBox1;
        public System.Windows.Forms.TextBox txttotal;
        public System.Windows.Forms.TextBox txtisv;
        public System.Windows.Forms.TextBox txtsubtotal;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtdescuento;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtexonerado;
        public System.Windows.Forms.TextBox txtexcento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}