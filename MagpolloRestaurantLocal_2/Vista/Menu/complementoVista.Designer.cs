
namespace AppTRchicken.Vista
{
    partial class complementoVista
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
            this.tpanelcomplentosplato = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // tpanelcomplentosplato
            // 
            this.tpanelcomplentosplato.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tpanelcomplentosplato.ColumnCount = 1;
            this.tpanelcomplentosplato.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpanelcomplentosplato.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpanelcomplentosplato.Location = new System.Drawing.Point(0, 0);
            this.tpanelcomplentosplato.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpanelcomplentosplato.Name = "tpanelcomplentosplato";
            this.tpanelcomplentosplato.RowCount = 1;
            this.tpanelcomplentosplato.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpanelcomplentosplato.Size = new System.Drawing.Size(1313, 817);
            this.tpanelcomplentosplato.TabIndex = 7;
            
            // complementoVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 817);
            this.Controls.Add(this.tpanelcomplentosplato);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "complementoVista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.complementoVista_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tpanelcomplentosplato;
    }
}