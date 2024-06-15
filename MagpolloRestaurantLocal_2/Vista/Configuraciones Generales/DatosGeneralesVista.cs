﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppTRchicken.Modelo;
using AppTRchicken.Controlador;
namespace AppTRchicken.Vista
{
    public partial class DatosGeneralesVista : Form
    {
        public DatosGeneralesVista()
        {
            InitializeComponent();
        }

        private void DatosGeneralesVista_Load(object sender, EventArgs e)
        {
            Cargardg();

        }

        private void dgdatosgenerales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtidsucursal.Text = dgdatosgenerales.CurrentRow.Cells[0].Value.ToString();
            txtnombresucursal.Text = dgdatosgenerales.CurrentRow.Cells[1].Value.ToString();
            txtdireccion.Text = dgdatosgenerales.CurrentRow.Cells[2].Value.ToString();
            txtcelular.Text = dgdatosgenerales.CurrentRow.Cells[3].Value.ToString();
            txtcorreo.Text = dgdatosgenerales.CurrentRow.Cells[4].Value.ToString();
            txtrtn.Text = dgdatosgenerales.CurrentRow.Cells[5].Value.ToString();
            txtcai.Text = dgdatosgenerales.CurrentRow.Cells[6].Value.ToString();
            dtpdfechaemision.Value = Convert.ToDateTime(dgdatosgenerales.CurrentRow.Cells[7].Value);
            txtrangodesde.Text = dgdatosgenerales.CurrentRow.Cells[8].Value.ToString();
            txtrangohasta.Text = dgdatosgenerales.CurrentRow.Cells[9].Value.ToString();
        }

        private void btnactualizarsucursal_Click(object sender, EventArgs e)
        {
            sucursales sucursales = new sucursales();
            sucursales.Idsucursal = Convert.ToInt32(txtidsucursal.Text);
            sucursales.Nombresucursal = txtnombresucursal.Text;
            sucursales.Direccion = txtdireccion.Text;
            sucursales.Celular = txtcelular.Text;
            sucursales.Correo = txtcorreo.Text;
            sucursales.Rtn = txtrtn.Text;
            sucursales.Cai = txtcai.Text;
            sucursales.Fecha_emision = dtpdfechaemision.Value;
            sucursales.Rangodesde = txtrangodesde.Text;
            sucursales.Rangohasta = txtrangohasta.Text;


            try
            {
                ControladorSucursal.Instance.update(sucursales);
                MessageBox.Show("Sucursal Actualizada");
                Cargardg();
                MessageBox.Show("Para que los Datos se Actualicen en el sistema porfavor abrir nuevamente la Aplicacion.");
                Application.Exit();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        public void Cargardg()
        {
            dgdatosgenerales.Rows.Clear();
            List<sucursales> usr = new List<sucursales>();
            usr = ControladorSucursal.Instance.findAll();
            foreach (sucursales sucursal in usr)
            {

                dgdatosgenerales.Rows.Add(sucursal.Idsucursal, sucursal.Nombresucursal, sucursal.Direccion, sucursal.Celular, sucursal.Correo, sucursal.Rtn, sucursal.Cai, sucursal.Fecha_emision, sucursal.Rangodesde, sucursal.Rangohasta);
            }

        }

        private static DatosGeneralesVista fmrDatosGeneralesVista = null;
        internal static DatosGeneralesVista Abrir1vez()
        {
            if (((fmrDatosGeneralesVista == null) || (fmrDatosGeneralesVista.IsDisposed == true)))
            {
                fmrDatosGeneralesVista = new DatosGeneralesVista();
            }
            fmrDatosGeneralesVista.BringToFront();
            return fmrDatosGeneralesVista;
        }


    }
}