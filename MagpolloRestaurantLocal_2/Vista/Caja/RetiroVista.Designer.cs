
namespace AppTRchicken.Vista
{
    partial class RetiroVista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RetiroVista));
            this.btnretirar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmontoretiro = new System.Windows.Forms.TextBox();
            this.txtmotivoretiro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbldisponible = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnactualizarsaldo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnretirar
            // 
            this.btnretirar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnretirar.BackColor = System.Drawing.Color.Red;
            this.btnretirar.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.btnretirar.Location = new System.Drawing.Point(184, 320);
            this.btnretirar.Name = "btnretirar";
            this.btnretirar.Size = new System.Drawing.Size(278, 87);
            this.btnretirar.TabIndex = 78;
            this.btnretirar.Text = "RETIRAR";
            this.btnretirar.UseVisualStyleBackColor = false;
            this.btnretirar.Click += new System.EventHandler(this.btnretirar_Click);
            this.btnretirar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btndepositar_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(198, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 33);
            this.label3.TabIndex = 77;
            this.label3.Text = "Retiro de Caja";
            // 
            // txtmontoretiro
            // 
            this.txtmontoretiro.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txtmontoretiro.Location = new System.Drawing.Point(243, 245);
            this.txtmontoretiro.Name = "txtmontoretiro";
            this.txtmontoretiro.Size = new System.Drawing.Size(255, 34);
            this.txtmontoretiro.TabIndex = 76;
            // 
            // txtmotivoretiro
            // 
            this.txtmotivoretiro.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txtmotivoretiro.Location = new System.Drawing.Point(243, 161);
            this.txtmotivoretiro.Name = "txtmotivoretiro";
            this.txtmotivoretiro.Size = new System.Drawing.Size(255, 34);
            this.txtmotivoretiro.TabIndex = 75;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 33);
            this.label2.TabIndex = 74;
            this.label2.Text = "Monto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 33);
            this.label1.TabIndex = 73;
            this.label1.Text = "Motivo:";
            // 
            // lbldisponible
            // 
            this.lbldisponible.AutoSize = true;
            this.lbldisponible.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldisponible.Location = new System.Drawing.Point(209, 112);
            this.lbldisponible.Name = "lbldisponible";
            this.lbldisponible.Size = new System.Drawing.Size(28, 23);
            this.lbldisponible.TabIndex = 82;
            this.lbldisponible.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(89, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 23);
            this.label4.TabIndex = 81;
            this.label4.Text = "Disponible: ";
            // 
            // btnactualizarsaldo
            // 
            this.btnactualizarsaldo.Image = ((System.Drawing.Image)(resources.GetObject("btnactualizarsaldo.Image")));
            this.btnactualizarsaldo.Location = new System.Drawing.Point(565, 393);
            this.btnactualizarsaldo.Name = "btnactualizarsaldo";
            this.btnactualizarsaldo.Size = new System.Drawing.Size(46, 44);
            this.btnactualizarsaldo.TabIndex = 83;
            this.btnactualizarsaldo.UseVisualStyleBackColor = true;
            this.btnactualizarsaldo.Click += new System.EventHandler(this.btnactualizarsaldo_Click);
            // 
            // RetiroVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 440);
            this.Controls.Add(this.btnactualizarsaldo);
            this.Controls.Add(this.lbldisponible);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnretirar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmontoretiro);
            this.Controls.Add(this.txtmotivoretiro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RetiroVista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.RetiroVista_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnretirar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmontoretiro;
        private System.Windows.Forms.TextBox txtmotivoretiro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbldisponible;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnactualizarsaldo;
    }
}