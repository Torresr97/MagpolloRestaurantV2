﻿
namespace AppTRchicken.Vista
{
    partial class rolesvista
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.txtnombrerole = new System.Windows.Forms.TextBox();
            this.txtidrole = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgroles = new System.Windows.Forms.DataGridView();
            this.idrole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrerole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actualizar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbcrear = new System.Windows.Forms.CheckBox();
            this.cbactualizar = new System.Windows.Forms.CheckBox();
            this.cbeliminar = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgroles)).BeginInit();
            this.SuspendLayout();
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn2.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.btn2.Location = new System.Drawing.Point(411, 238);
            this.btn2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(277, 89);
            this.btn2.TabIndex = 36;
            this.btn2.Text = "ACTUALIZAR";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn1.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.btn1.Location = new System.Drawing.Point(88, 238);
            this.btn1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(277, 87);
            this.btn1.TabIndex = 35;
            this.btn1.Text = "NUEVO";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btnbotonguardarrole_Click);
            // 
            // txtnombrerole
            // 
            this.txtnombrerole.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txtnombrerole.Location = new System.Drawing.Point(301, 106);
            this.txtnombrerole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnombrerole.Name = "txtnombrerole";
            this.txtnombrerole.Size = new System.Drawing.Size(441, 34);
            this.txtnombrerole.TabIndex = 29;
            // 
            // txtidrole
            // 
            this.txtidrole.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.txtidrole.Location = new System.Drawing.Point(301, 43);
            this.txtidrole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtidrole.Name = "txtidrole";
            this.txtidrole.ReadOnly = true;
            this.txtidrole.Size = new System.Drawing.Size(441, 34);
            this.txtidrole.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 27);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 27);
            this.label1.TabIndex = 25;
            this.label1.Text = "Codigo de Role";
            // 
            // dgroles
            // 
            this.dgroles.AllowUserToAddRows = false;
            this.dgroles.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgroles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgroles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgroles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idrole,
            this.nombrerole,
            this.crear,
            this.actualizar,
            this.eliminar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgroles.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgroles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgroles.Location = new System.Drawing.Point(0, 370);
            this.dgroles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgroles.Name = "dgroles";
            this.dgroles.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgroles.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgroles.RowHeadersVisible = false;
            this.dgroles.RowHeadersWidth = 51;
            this.dgroles.RowTemplate.Height = 24;
            this.dgroles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgroles.Size = new System.Drawing.Size(1132, 247);
            this.dgroles.TabIndex = 37;
            this.dgroles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgroles_CellClick);
            // 
            // idrole
            // 
            this.idrole.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idrole.FillWeight = 42.78075F;
            this.idrole.HeaderText = "Codigo de Role";
            this.idrole.MinimumWidth = 6;
            this.idrole.Name = "idrole";
            this.idrole.ReadOnly = true;
            // 
            // nombrerole
            // 
            this.nombrerole.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombrerole.FillWeight = 157.2193F;
            this.nombrerole.HeaderText = "Nombre";
            this.nombrerole.MinimumWidth = 6;
            this.nombrerole.Name = "nombrerole";
            this.nombrerole.ReadOnly = true;
            // 
            // crear
            // 
            this.crear.HeaderText = "Crear";
            this.crear.MinimumWidth = 6;
            this.crear.Name = "crear";
            this.crear.ReadOnly = true;
            this.crear.Width = 125;
            // 
            // actualizar
            // 
            this.actualizar.HeaderText = "Actualizar";
            this.actualizar.MinimumWidth = 6;
            this.actualizar.Name = "actualizar";
            this.actualizar.ReadOnly = true;
            this.actualizar.Width = 125;
            // 
            // eliminar
            // 
            this.eliminar.HeaderText = "Eliminar";
            this.eliminar.MinimumWidth = 6;
            this.eliminar.Name = "eliminar";
            this.eliminar.ReadOnly = true;
            this.eliminar.Width = 125;
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn3.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.btn3.Location = new System.Drawing.Point(740, 238);
            this.btn3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(277, 89);
            this.btn3.TabIndex = 38;
            this.btn3.Text = "ELIMINAR";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 27);
            this.label3.TabIndex = 39;
            this.label3.Text = "Permisos";
            // 
            // cbcrear
            // 
            this.cbcrear.AutoSize = true;
            this.cbcrear.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.cbcrear.Location = new System.Drawing.Point(301, 164);
            this.cbcrear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbcrear.Name = "cbcrear";
            this.cbcrear.Size = new System.Drawing.Size(101, 31);
            this.cbcrear.TabIndex = 43;
            this.cbcrear.Text = "Crear";
            this.cbcrear.UseVisualStyleBackColor = true;
            // 
            // cbactualizar
            // 
            this.cbactualizar.AutoSize = true;
            this.cbactualizar.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.cbactualizar.Location = new System.Drawing.Point(448, 164);
            this.cbactualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbactualizar.Name = "cbactualizar";
            this.cbactualizar.Size = new System.Drawing.Size(152, 31);
            this.cbactualizar.TabIndex = 44;
            this.cbactualizar.Text = "Actualizar";
            this.cbactualizar.UseVisualStyleBackColor = true;
            // 
            // cbeliminar
            // 
            this.cbeliminar.AutoSize = true;
            this.cbeliminar.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.cbeliminar.Location = new System.Drawing.Point(629, 164);
            this.cbeliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbeliminar.Name = "cbeliminar";
            this.cbeliminar.Size = new System.Drawing.Size(135, 31);
            this.cbeliminar.TabIndex = 45;
            this.cbeliminar.Text = "Eliminar";
            this.cbeliminar.UseVisualStyleBackColor = true;
            // 
            // rolesvista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 617);
            this.Controls.Add(this.cbeliminar);
            this.Controls.Add(this.cbactualizar);
            this.Controls.Add(this.cbcrear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.dgroles);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtnombrerole);
            this.Controls.Add(this.txtidrole);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "rolesvista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.rolesvista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgroles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txtnombrerole;
        private System.Windows.Forms.TextBox txtidrole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgroles;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idrole;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrerole;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbcrear;
        private System.Windows.Forms.CheckBox cbactualizar;
        private System.Windows.Forms.CheckBox cbeliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn crear;
        private System.Windows.Forms.DataGridViewTextBoxColumn actualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn eliminar;
    }
}