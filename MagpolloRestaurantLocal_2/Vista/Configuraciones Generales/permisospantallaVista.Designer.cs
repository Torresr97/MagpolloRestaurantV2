
namespace AppTRchicken.Vista.Configuraciones_Generales
{
    partial class permisospantallaVista
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbroles = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listboxpantallas = new System.Windows.Forms.CheckedListBox();
            this.btnagregarpermisos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 27);
            this.label2.TabIndex = 47;
            this.label2.Text = "Rol";
            // 
            // cbroles
            // 
            this.cbroles.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.cbroles.FormattingEnabled = true;
            this.cbroles.Location = new System.Drawing.Point(96, 11);
            this.cbroles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbroles.Name = "cbroles";
            this.cbroles.Size = new System.Drawing.Size(225, 34);
            this.cbroles.TabIndex = 56;
            this.cbroles.SelectedIndexChanged += new System.EventHandler(this.cbroles_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(487, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 27);
            this.label1.TabIndex = 57;
            this.label1.Text = "Pantallas";
            // 
            // listboxpantallas
            // 
            this.listboxpantallas.Dock = System.Windows.Forms.DockStyle.Right;
            this.listboxpantallas.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.listboxpantallas.FormattingEnabled = true;
            this.listboxpantallas.Location = new System.Drawing.Point(672, 0);
            this.listboxpantallas.Name = "listboxpantallas";
            this.listboxpantallas.Size = new System.Drawing.Size(415, 841);
            this.listboxpantallas.TabIndex = 58;
            // 
            // btnagregarpermisos
            // 
            this.btnagregarpermisos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnagregarpermisos.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.btnagregarpermisos.Location = new System.Drawing.Point(150, 274);
            this.btnagregarpermisos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnagregarpermisos.Name = "btnagregarpermisos";
            this.btnagregarpermisos.Size = new System.Drawing.Size(277, 87);
            this.btnagregarpermisos.TabIndex = 59;
            this.btnagregarpermisos.Text = "Agregar Permisos";
            this.btnagregarpermisos.UseVisualStyleBackColor = false;
            this.btnagregarpermisos.Click += new System.EventHandler(this.btnagregarpermisos_Click);
            // 
            // permisospantallaVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 841);
            this.Controls.Add(this.btnagregarpermisos);
            this.Controls.Add(this.listboxpantallas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbroles);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "permisospantallaVista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.permisospantallaVista_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbroles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox listboxpantallas;
        private System.Windows.Forms.Button btnagregarpermisos;
    }
}