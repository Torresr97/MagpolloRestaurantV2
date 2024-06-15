
namespace AppTRchicken.Vista.Menu
{
    partial class MenuVistadeduccionesxempleado
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
            this.tpanelmenu = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // tpanelmenu
            // 
            this.tpanelmenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tpanelmenu.ColumnCount = 1;
            this.tpanelmenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpanelmenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpanelmenu.Location = new System.Drawing.Point(0, 0);
            this.tpanelmenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpanelmenu.Name = "tpanelmenu";
            this.tpanelmenu.RowCount = 1;
            this.tpanelmenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpanelmenu.Size = new System.Drawing.Size(1250, 648);
            this.tpanelmenu.TabIndex = 8;
            // 
            // MenuVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 648);
            this.Controls.Add(this.tpanelmenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MenuVista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MenuVista_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tpanelmenu;
    }
}