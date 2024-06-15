
namespace AppTRchicken.Vista
{
    partial class metodos
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
            this.btnadomicilio = new System.Windows.Forms.Button();
            this.btnparallevar = new System.Windows.Forms.Button();
            this.btncomersqui = new System.Windows.Forms.Button();
            this.panelconfiguraciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelconfiguraciones
            // 
            this.panelconfiguraciones.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelconfiguraciones.ColumnCount = 3;
            this.panelconfiguraciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelconfiguraciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelconfiguraciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelconfiguraciones.Controls.Add(this.btnadomicilio, 0, 0);
            this.panelconfiguraciones.Controls.Add(this.btnparallevar, 0, 0);
            this.panelconfiguraciones.Controls.Add(this.btncomersqui, 0, 0);
            this.panelconfiguraciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelconfiguraciones.Location = new System.Drawing.Point(0, 0);
            this.panelconfiguraciones.Name = "panelconfiguraciones";
            this.panelconfiguraciones.RowCount = 1;
            this.panelconfiguraciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelconfiguraciones.Size = new System.Drawing.Size(1033, 239);
            this.panelconfiguraciones.TabIndex = 6;
            // 
            // btnadomicilio
            // 
            this.btnadomicilio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnadomicilio.BackColor = System.Drawing.Color.SeaShell;
            this.btnadomicilio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadomicilio.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold);
            this.btnadomicilio.Location = new System.Drawing.Point(691, 3);
            this.btnadomicilio.Name = "btnadomicilio";
            this.btnadomicilio.Size = new System.Drawing.Size(339, 233);
            this.btnadomicilio.TabIndex = 5;
            this.btnadomicilio.Text = "Adomicilio";
            this.btnadomicilio.UseVisualStyleBackColor = false;
            this.btnadomicilio.Click += new System.EventHandler(this.btnadomicilio_Click);
            // 
            // btnparallevar
            // 
            this.btnparallevar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnparallevar.BackColor = System.Drawing.Color.SeaShell;
            this.btnparallevar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnparallevar.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold);
            this.btnparallevar.Location = new System.Drawing.Point(347, 3);
            this.btnparallevar.Name = "btnparallevar";
            this.btnparallevar.Size = new System.Drawing.Size(338, 233);
            this.btnparallevar.TabIndex = 4;
            this.btnparallevar.Text = "Para Llevar";
            this.btnparallevar.UseVisualStyleBackColor = false;
            this.btnparallevar.Click += new System.EventHandler(this.btnparallevar_Click);
            // 
            // btncomersqui
            // 
            this.btncomersqui.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btncomersqui.BackColor = System.Drawing.Color.SeaShell;
            this.btncomersqui.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncomersqui.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold);
            this.btncomersqui.Location = new System.Drawing.Point(3, 3);
            this.btncomersqui.Name = "btncomersqui";
            this.btncomersqui.Size = new System.Drawing.Size(338, 233);
            this.btncomersqui.TabIndex = 2;
            this.btncomersqui.Text = "Comer Aqui";
            this.btncomersqui.UseVisualStyleBackColor = false;
            this.btncomersqui.Click += new System.EventHandler(this.btncomersqui_Click);
            // 
            // metodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 239);
            this.Controls.Add(this.panelconfiguraciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "metodos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelconfiguraciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panelconfiguraciones;
        private System.Windows.Forms.Button btnadomicilio;
        private System.Windows.Forms.Button btnparallevar;
        private System.Windows.Forms.Button btncomersqui;
    }
}