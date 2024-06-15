
namespace AppTRchicken.Vista
{
    partial class panelcontrolVista
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.impresorasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosDeImpresoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.impresorasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1047, 35);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // impresorasToolStripMenuItem
            // 
            this.impresorasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosDeImpresoraToolStripMenuItem});
            this.impresorasToolStripMenuItem.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.impresorasToolStripMenuItem.Name = "impresorasToolStripMenuItem";
            this.impresorasToolStripMenuItem.Size = new System.Drawing.Size(159, 31);
            this.impresorasToolStripMenuItem.Text = "Impresoras";
            // 
            // datosDeImpresoraToolStripMenuItem
            // 
            this.datosDeImpresoraToolStripMenuItem.Name = "datosDeImpresoraToolStripMenuItem";
            this.datosDeImpresoraToolStripMenuItem.Size = new System.Drawing.Size(330, 32);
            this.datosDeImpresoraToolStripMenuItem.Text = "Datos de Impresora";
            this.datosDeImpresoraToolStripMenuItem.Click += new System.EventHandler(this.datosDeImpresoraToolStripMenuItem_Click);
            // 
            // panelcontrolVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 687);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "panelcontrolVista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem impresorasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosDeImpresoraToolStripMenuItem;
    }
}