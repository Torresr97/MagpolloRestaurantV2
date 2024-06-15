using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Threading;

namespace AppTRchicken.Vista.Configuraciones_Generales
{
    public partial class CargandoVista : Form
    {

        private BackgroundWorker worker = new BackgroundWorker();


        public CargandoVista()
        {
            InitializeComponent();

            // Configurar el control BackgroundWorker
            worker.DoWork += Worker_DoWork;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;


        }
        private int tiempoEspera;
        public void SetTiempoDeEspera(int tiempo)
        {
            tiempoEspera = tiempo;
        }
        // Método que se ejecuta en segundo plano
        private async void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            // Simula una carga de datos prolongada utilizando el tiempo establecido en CargandoVista
            Thread.Sleep(tiempoEspera);

            // Aquí puedes realizar la carga de datos real si lo deseas
            // Solo asegúrate de no bloquear el hilo de la interfaz de usuario (UI thread) durante mucho tiempo
        }

        // Método que se ejecuta después de que se completa el trabajo en segundo plano
        public void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Cerrar el formulario de carga
            this.Close();
        }
        private void CargandoVista_Load(object sender, EventArgs e)

        {
            
            worker.RunWorkerAsync();
        }

        public void CerrarFormularioSeguro()
        {
            if (this.InvokeRequired)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    this.Close();
                });
            }
            else
            {
                this.Close();
            }
        }


        private void CargandoVista_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Evitar el cierre del formulario de carga
            e.Cancel = true;
            this.Hide(); // Ocultar en lugar de cerrar
        }
    }






    
}
