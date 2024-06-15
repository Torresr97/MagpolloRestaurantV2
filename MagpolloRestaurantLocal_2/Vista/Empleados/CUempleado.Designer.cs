
namespace AppTRchicken.Vista
{
    partial class CUempleado
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CUempleado));
            this.panelconfiguraciones = new System.Windows.Forms.TableLayoutPanel();
            this.btnregresar = new System.Windows.Forms.Button();
            this.btnEmpleadoVistas = new System.Windows.Forms.Button();
            this.btnPagodePlanillaVista = new System.Windows.Forms.Button();
            this.panelconfiguraciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelconfiguraciones
            // 
            this.panelconfiguraciones.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelconfiguraciones.ColumnCount = 3;
            this.panelconfiguraciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelconfiguraciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelconfiguraciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelconfiguraciones.Controls.Add(this.btnregresar, 0, 0);
            this.panelconfiguraciones.Controls.Add(this.btnEmpleadoVistas, 1, 0);
            this.panelconfiguraciones.Controls.Add(this.btnPagodePlanillaVista, 2, 0);
            this.panelconfiguraciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelconfiguraciones.Location = new System.Drawing.Point(0, 0);
            this.panelconfiguraciones.Name = "panelconfiguraciones";
            this.panelconfiguraciones.RowCount = 3;
            this.panelconfiguraciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelconfiguraciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelconfiguraciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelconfiguraciones.Size = new System.Drawing.Size(1389, 876);
            this.panelconfiguraciones.TabIndex = 3;
            this.panelconfiguraciones.Paint += new System.Windows.Forms.PaintEventHandler(this.panelconfiguraciones_Paint);
            // 
            // btnregresar
            // 
            this.btnregresar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnregresar.BackColor = System.Drawing.Color.SeaShell;
            this.btnregresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregresar.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold);
            this.btnregresar.Image = ((System.Drawing.Image)(resources.GetObject("btnregresar.Image")));
            this.btnregresar.Location = new System.Drawing.Point(3, 3);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(457, 286);
            this.btnregresar.TabIndex = 2;
            this.btnregresar.Text = "Regresar";
            this.btnregresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnregresar.UseVisualStyleBackColor = false;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // btnEmpleadoVistas
            // 
            this.btnEmpleadoVistas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEmpleadoVistas.BackColor = System.Drawing.Color.SeaShell;
            this.btnEmpleadoVistas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleadoVistas.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold);
            this.btnEmpleadoVistas.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpleadoVistas.Image")));
            this.btnEmpleadoVistas.Location = new System.Drawing.Point(466, 2);
            this.btnEmpleadoVistas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEmpleadoVistas.Name = "btnEmpleadoVistas";
            this.btnEmpleadoVistas.Size = new System.Drawing.Size(457, 288);
            this.btnEmpleadoVistas.TabIndex = 11;
            this.btnEmpleadoVistas.Text = "Datos de Empleados";
            this.btnEmpleadoVistas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmpleadoVistas.UseVisualStyleBackColor = false;
            this.btnEmpleadoVistas.Click += new System.EventHandler(this.btnEmpleadoVistas_Click);
            // 
            // btnPagodePlanillaVista
            // 
            this.btnPagodePlanillaVista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPagodePlanillaVista.BackColor = System.Drawing.Color.SeaShell;
            this.btnPagodePlanillaVista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagodePlanillaVista.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold);
            this.btnPagodePlanillaVista.Image = ((System.Drawing.Image)(resources.GetObject("btnPagodePlanillaVista.Image")));
            this.btnPagodePlanillaVista.Location = new System.Drawing.Point(929, 2);
            this.btnPagodePlanillaVista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPagodePlanillaVista.Name = "btnPagodePlanillaVista";
            this.btnPagodePlanillaVista.Size = new System.Drawing.Size(457, 288);
            this.btnPagodePlanillaVista.TabIndex = 12;
            this.btnPagodePlanillaVista.Text = "Planilla";
            this.btnPagodePlanillaVista.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPagodePlanillaVista.UseVisualStyleBackColor = false;
            this.btnPagodePlanillaVista.Click += new System.EventHandler(this.btnPagodePlanillaVista_Click);
            // 
            // CUempleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelconfiguraciones);
            this.Name = "CUempleado";
            this.Size = new System.Drawing.Size(1389, 876);
            this.panelconfiguraciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panelconfiguraciones;
        private System.Windows.Forms.Button btnregresar;
        private System.Windows.Forms.Button btnEmpleadoVistas;
        private System.Windows.Forms.Button btnPagodePlanillaVista;
    }
}
