
namespace AppTRchicken.Vista.Pruebas
{
    partial class Prueba_de_Tickets
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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncobrar
            // 
            this.btncobrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncobrar.BackColor = System.Drawing.Color.SeaShell;
            this.btncobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncobrar.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold);
            this.btncobrar.Location = new System.Drawing.Point(12, 59);
            this.btncobrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncobrar.Name = "btncobrar";
            this.btncobrar.Size = new System.Drawing.Size(284, 263);
            this.btncobrar.TabIndex = 62;
            this.btncobrar.Text = "COBRAR ticket";
            this.btncobrar.UseVisualStyleBackColor = false;
            this.btncobrar.Click += new System.EventHandler(this.btncobrar_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.SeaShell;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(420, 59);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(284, 263);
            this.button1.TabIndex = 63;
            this.button1.Text = "COBRAR con Ticket2";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Prueba_de_Tickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 534);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btncobrar);
            this.Name = "Prueba_de_Tickets";
            this.Text = "Prueba_de_Tickets";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncobrar;
        private System.Windows.Forms.Button button1;
    }
}