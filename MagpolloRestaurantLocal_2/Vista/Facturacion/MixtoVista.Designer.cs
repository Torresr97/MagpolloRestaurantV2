
namespace AppTRchicken.Vista.Facturacion
{
    partial class MixtoVista
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
            this.txtnombrecliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtventatotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtefectivo = new System.Windows.Forms.TextBox();
            this.txttarjeta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btncobrar = new System.Windows.Forms.Button();
            this.cbxsucursal = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtnombrecliente
            // 
            this.txtnombrecliente.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txtnombrecliente.Location = new System.Drawing.Point(291, 42);
            this.txtnombrecliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnombrecliente.Name = "txtnombrecliente";
            this.txtnombrecliente.Size = new System.Drawing.Size(255, 34);
            this.txtnombrecliente.TabIndex = 78;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 33);
            this.label4.TabIndex = 77;
            this.label4.Text = "Nombre Cliente";
            // 
            // txtventatotal
            // 
            this.txtventatotal.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txtventatotal.Location = new System.Drawing.Point(291, 102);
            this.txtventatotal.Name = "txtventatotal";
            this.txtventatotal.ReadOnly = true;
            this.txtventatotal.Size = new System.Drawing.Size(255, 34);
            this.txtventatotal.TabIndex = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 33);
            this.label1.TabIndex = 73;
            this.label1.Text = "Total Venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 33);
            this.label2.TabIndex = 74;
            this.label2.Text = "Efectivo";
            // 
            // txtefectivo
            // 
            this.txtefectivo.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txtefectivo.Location = new System.Drawing.Point(291, 172);
            this.txtefectivo.Name = "txtefectivo";
            this.txtefectivo.Size = new System.Drawing.Size(255, 34);
            this.txtefectivo.TabIndex = 76;
            this.txtefectivo.TextChanged += new System.EventHandler(this.txtefectivo_TextChanged);
            // 
            // txttarjeta
            // 
            this.txttarjeta.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txttarjeta.Location = new System.Drawing.Point(291, 236);
            this.txttarjeta.Name = "txttarjeta";
            this.txttarjeta.Size = new System.Drawing.Size(255, 34);
            this.txttarjeta.TabIndex = 80;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 33);
            this.label3.TabIndex = 79;
            this.label3.Text = "Tarjeta";
            // 
            // btncobrar
            // 
            this.btncobrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncobrar.BackColor = System.Drawing.Color.SeaShell;
            this.btncobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncobrar.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold);
            this.btncobrar.Location = new System.Drawing.Point(671, 73);
            this.btncobrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncobrar.Name = "btncobrar";
            this.btncobrar.Size = new System.Drawing.Size(271, 222);
            this.btncobrar.TabIndex = 81;
            this.btncobrar.Text = "COBRAR";
            this.btncobrar.UseVisualStyleBackColor = false;
            this.btncobrar.Click += new System.EventHandler(this.btncobrar_Click);
            // 
            // cbxsucursal
            // 
            this.cbxsucursal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxsucursal.BackColor = System.Drawing.Color.SeaShell;
            this.cbxsucursal.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.cbxsucursal.FormattingEnabled = true;
            this.cbxsucursal.IntegralHeight = false;
            this.cbxsucursal.Items.AddRange(new object[] {
            "TIENDA",
            "AUTOSERVICIO",
            "PEDIDOS YA"});
            this.cbxsucursal.Location = new System.Drawing.Point(671, 21);
            this.cbxsucursal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxsucursal.Name = "cbxsucursal";
            this.cbxsucursal.Size = new System.Drawing.Size(259, 34);
            this.cbxsucursal.TabIndex = 82;
            // 
            // MixtoVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 342);
            this.Controls.Add(this.cbxsucursal);
            this.Controls.Add(this.btncobrar);
            this.Controls.Add(this.txttarjeta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnombrecliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtefectivo);
            this.Controls.Add(this.txtventatotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MixtoVista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MixtoVista_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnombrecliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtventatotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtefectivo;
        private System.Windows.Forms.TextBox txttarjeta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btncobrar;
        private System.Windows.Forms.ComboBox cbxsucursal;
    }
}