﻿
namespace AppTRchicken.Vista
{
    partial class MetodoPagoVista
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
            this.panelconfiguraciones = new System.Windows.Forms.TableLayoutPanel();
            this.btntarjeta = new System.Windows.Forms.Button();
            this.btnefectivo = new System.Windows.Forms.Button();
            this.panelconfiguraciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelconfiguraciones
            // 
            this.panelconfiguraciones.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelconfiguraciones.ColumnCount = 2;
            this.panelconfiguraciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelconfiguraciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelconfiguraciones.Controls.Add(this.btntarjeta, 0, 0);
            this.panelconfiguraciones.Controls.Add(this.btnefectivo, 0, 0);
            this.panelconfiguraciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelconfiguraciones.Location = new System.Drawing.Point(0, 0);
            this.panelconfiguraciones.Name = "panelconfiguraciones";
            this.panelconfiguraciones.RowCount = 1;
            this.panelconfiguraciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelconfiguraciones.Size = new System.Drawing.Size(1052, 240);
            this.panelconfiguraciones.TabIndex = 7;
            // 
            // btntarjeta
            // 
            this.btntarjeta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btntarjeta.BackColor = System.Drawing.Color.SeaShell;
            this.btntarjeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntarjeta.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold);
            this.btntarjeta.Location = new System.Drawing.Point(529, 3);
            this.btntarjeta.Name = "btntarjeta";
            this.btntarjeta.Size = new System.Drawing.Size(520, 234);
            this.btntarjeta.TabIndex = 4;
            this.btntarjeta.Text = "Tarjeta";
            this.btntarjeta.UseVisualStyleBackColor = false;
            this.btntarjeta.Click += new System.EventHandler(this.btntarjeta_Click);
            // 
            // btnefectivo
            // 
            this.btnefectivo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnefectivo.BackColor = System.Drawing.Color.SeaShell;
            this.btnefectivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnefectivo.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold);
            this.btnefectivo.Location = new System.Drawing.Point(3, 3);
            this.btnefectivo.Name = "btnefectivo";
            this.btnefectivo.Size = new System.Drawing.Size(520, 234);
            this.btnefectivo.TabIndex = 2;
            this.btnefectivo.Text = "Efectivo";
            this.btnefectivo.UseVisualStyleBackColor = false;
            this.btnefectivo.Click += new System.EventHandler(this.btnefectivo_Click);
            // 
            // MetodoPagoVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 240);
            this.Controls.Add(this.panelconfiguraciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MetodoPagoVista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            
            this.panelconfiguraciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panelconfiguraciones;
        private System.Windows.Forms.Button btntarjeta;
        private System.Windows.Forms.Button btnefectivo;
    }
}