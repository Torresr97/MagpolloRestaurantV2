using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTRchicken.Vista
{
    public partial class panelcontrolVista : Form
    {
        public panelcontrolVista()
        {
            InitializeComponent();
        }

        private void datosDeImpresoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            impresoraVista impresoraVista = new impresoraVista();
            impresoraVista.Show();
        }

        private static panelcontrolVista fmrpanelcontrolVista = null;
        internal static panelcontrolVista Abrir1vez()
        {
            if (((fmrpanelcontrolVista == null) || (fmrpanelcontrolVista.IsDisposed == true)))
            {
                fmrpanelcontrolVista = new panelcontrolVista();
            }
            fmrpanelcontrolVista.BringToFront();
            return fmrpanelcontrolVista;
        }


    }
}
