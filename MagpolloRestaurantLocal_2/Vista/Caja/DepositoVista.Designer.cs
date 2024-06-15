
namespace AppTRchicken.Vista
{
    partial class DepositoVista
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtmontodeposito = new System.Windows.Forms.TextBox();
            this.txtmotivodeposito = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btndepositar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(172, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 33);
            this.label3.TabIndex = 71;
            this.label3.Text = "Deposito  a Caja";
            // 
            // txtmontodeposito
            // 
            this.txtmontodeposito.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txtmontodeposito.Location = new System.Drawing.Point(237, 219);
            this.txtmontodeposito.Name = "txtmontodeposito";
            this.txtmontodeposito.Size = new System.Drawing.Size(255, 34);
            this.txtmontodeposito.TabIndex = 70;
            this.txtmontodeposito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdinerorecibido_KeyPress);
            // 
            // txtmotivodeposito
            // 
            this.txtmotivodeposito.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txtmotivodeposito.Location = new System.Drawing.Point(237, 135);
            this.txtmotivodeposito.Name = "txtmotivodeposito";
            this.txtmotivodeposito.Size = new System.Drawing.Size(255, 34);
            this.txtmotivodeposito.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 33);
            this.label2.TabIndex = 68;
            this.label2.Text = "Monto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 33);
            this.label1.TabIndex = 67;
            this.label1.Text = "Motivo:";
            // 
            // btndepositar
            // 
            this.btndepositar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btndepositar.BackColor = System.Drawing.Color.LimeGreen;
            this.btndepositar.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.btndepositar.Location = new System.Drawing.Point(178, 303);
            this.btndepositar.Name = "btndepositar";
            this.btndepositar.Size = new System.Drawing.Size(278, 87);
            this.btndepositar.TabIndex = 72;
            this.btndepositar.Text = "DEPOSITAR";
            this.btndepositar.UseVisualStyleBackColor = false;
            this.btndepositar.Click += new System.EventHandler(this.btndepositar_Click);
            // 
            // DepositoVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 411);
            this.Controls.Add(this.btndepositar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmontodeposito);
            this.Controls.Add(this.txtmotivodeposito);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DepositoVista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.DepositoVista_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmontodeposito;
        private System.Windows.Forms.TextBox txtmotivodeposito;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btndepositar;
    }
}