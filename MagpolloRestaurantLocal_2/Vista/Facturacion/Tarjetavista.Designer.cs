
namespace AppTRchicken.Vista
{
    partial class Tarjetavista
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
            this.btncobrar = new System.Windows.Forms.Button();
            this.txt4digistos = new System.Windows.Forms.TextBox();
            this.txtdinerorecibidotarjeta = new System.Windows.Forms.TextBox();
            this.txtventatotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnombrecliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxsucursal = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btncobrar
            // 
            this.btncobrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncobrar.BackColor = System.Drawing.Color.SeaShell;
            this.btncobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncobrar.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold);
            this.btncobrar.Location = new System.Drawing.Point(659, 78);
            this.btncobrar.Name = "btncobrar";
            this.btncobrar.Size = new System.Drawing.Size(257, 215);
            this.btncobrar.TabIndex = 68;
            this.btncobrar.Text = "COBRAR";
            this.btncobrar.UseVisualStyleBackColor = false;
            this.btncobrar.Click += new System.EventHandler(this.btncobrar_Click);
            // 
            // txt4digistos
            // 
            this.txt4digistos.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txt4digistos.Location = new System.Drawing.Point(278, 236);
            this.txt4digistos.Name = "txt4digistos";
            this.txt4digistos.Size = new System.Drawing.Size(255, 34);
            this.txt4digistos.TabIndex = 67;
            this.txt4digistos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt4digistos_KeyPress);
            // 
            // txtdinerorecibidotarjeta
            // 
            this.txtdinerorecibidotarjeta.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txtdinerorecibidotarjeta.Location = new System.Drawing.Point(278, 166);
            this.txtdinerorecibidotarjeta.Name = "txtdinerorecibidotarjeta";
            this.txtdinerorecibidotarjeta.Size = new System.Drawing.Size(255, 34);
            this.txtdinerorecibidotarjeta.TabIndex = 66;
            this.txtdinerorecibidotarjeta.TextChanged += new System.EventHandler(this.txtdinerorecibidotarjeta_TextChanged);
            this.txtdinerorecibidotarjeta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdinerorecibidotarjeta_KeyPress);
            // 
            // txtventatotal
            // 
            this.txtventatotal.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txtventatotal.Location = new System.Drawing.Point(278, 100);
            this.txtventatotal.Name = "txtventatotal";
            this.txtventatotal.ReadOnly = true;
            this.txtventatotal.Size = new System.Drawing.Size(255, 34);
            this.txtventatotal.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 33);
            this.label3.TabIndex = 64;
            this.label3.Text = "Ultimos 4 Digitos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 33);
            this.label2.TabIndex = 63;
            this.label2.Text = "Dinero Recibido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 33);
            this.label1.TabIndex = 62;
            this.label1.Text = "Total Venta";
            // 
            // txtnombrecliente
            // 
            this.txtnombrecliente.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txtnombrecliente.Location = new System.Drawing.Point(278, 35);
            this.txtnombrecliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnombrecliente.Name = "txtnombrecliente";
            this.txtnombrecliente.Size = new System.Drawing.Size(255, 34);
            this.txtnombrecliente.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 33);
            this.label4.TabIndex = 69;
            this.label4.Text = "Nombre Cliente";
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
            this.cbxsucursal.Location = new System.Drawing.Point(657, 20);
            this.cbxsucursal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxsucursal.Name = "cbxsucursal";
            this.cbxsucursal.Size = new System.Drawing.Size(259, 34);
            this.cbxsucursal.TabIndex = 71;
            // 
            // Tarjetavista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 342);
            this.Controls.Add(this.cbxsucursal);
            this.Controls.Add(this.txtnombrecliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btncobrar);
            this.Controls.Add(this.txt4digistos);
            this.Controls.Add(this.txtdinerorecibidotarjeta);
            this.Controls.Add(this.txtventatotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Tarjetavista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Tarjetavista_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncobrar;
        private System.Windows.Forms.TextBox txt4digistos;
        private System.Windows.Forms.TextBox txtdinerorecibidotarjeta;
        private System.Windows.Forms.TextBox txtventatotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnombrecliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxsucursal;
    }
}