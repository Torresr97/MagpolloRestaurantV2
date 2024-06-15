
namespace AppTRchicken.Vista
{
    partial class Efectivovista
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
            this.txtvuelto = new System.Windows.Forms.TextBox();
            this.txtdinerorecibido = new System.Windows.Forms.TextBox();
            this.txtventatotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncobrar
            // 
            this.btncobrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncobrar.BackColor = System.Drawing.Color.SeaShell;
            this.btncobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncobrar.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold);
            this.btncobrar.Location = new System.Drawing.Point(477, 32);
            this.btncobrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btncobrar.Name = "btncobrar";
            this.btncobrar.Size = new System.Drawing.Size(213, 214);
            this.btncobrar.TabIndex = 61;
            this.btncobrar.Text = "COBRAR";
            this.btncobrar.UseVisualStyleBackColor = false;
            this.btncobrar.Click += new System.EventHandler(this.btncobrar_Click_1);
            // 
            // txtvuelto
            // 
            this.txtvuelto.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txtvuelto.Location = new System.Drawing.Point(194, 160);
            this.txtvuelto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtvuelto.Name = "txtvuelto";
            this.txtvuelto.ReadOnly = true;
            this.txtvuelto.Size = new System.Drawing.Size(192, 34);
            this.txtvuelto.TabIndex = 60;
            this.txtvuelto.TextChanged += new System.EventHandler(this.txtvuelto_TextChanged);
            // 
            // txtdinerorecibido
            // 
            this.txtdinerorecibido.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txtdinerorecibido.Location = new System.Drawing.Point(194, 101);
            this.txtdinerorecibido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtdinerorecibido.Name = "txtdinerorecibido";
            this.txtdinerorecibido.Size = new System.Drawing.Size(192, 34);
            this.txtdinerorecibido.TabIndex = 59;
            this.txtdinerorecibido.TextChanged += new System.EventHandler(this.txtdinerorecibido_TextChanged);
            this.txtdinerorecibido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdinerorecibido_KeyPress);
            // 
            // txtventatotal
            // 
            this.txtventatotal.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txtventatotal.Location = new System.Drawing.Point(194, 32);
            this.txtventatotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtventatotal.Name = "txtventatotal";
            this.txtventatotal.ReadOnly = true;
            this.txtventatotal.Size = new System.Drawing.Size(192, 34);
            this.txtventatotal.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 33);
            this.label3.TabIndex = 57;
            this.label3.Text = "Vuelto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 33);
            this.label2.TabIndex = 56;
            this.label2.Text = "Dinero Recibido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 33);
            this.label1.TabIndex = 55;
            this.label1.Text = "Total Venta";
            // 
            // Efectivovista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 278);
            this.Controls.Add(this.btncobrar);
            this.Controls.Add(this.txtvuelto);
            this.Controls.Add(this.txtdinerorecibido);
            this.Controls.Add(this.txtventatotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Efectivovista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Efectivovista_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncobrar;
        private System.Windows.Forms.TextBox txtvuelto;
        private System.Windows.Forms.TextBox txtdinerorecibido;
        private System.Windows.Forms.TextBox txtventatotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}