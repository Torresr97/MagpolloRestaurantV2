using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppTRchicken.Modelo;
using AppTRchicken.Controlador;
using AppTRchicken.Utilidades;

namespace AppTRchicken.Vista
{
    public partial class CocinaVista : Form
    {
        private Queue<facturas> facturasQueue = new Queue<facturas>(); // Cola para las facturas pendientes
        private Dictionary<Panel, Timer> panelTimers = new Dictionary<Panel, Timer>(); // Diccionario para mapear el temporizador al panel correspondiente
        private string fechaActualString = "";
        private Timer updateTimer = new Timer();
        private bool isUpdating = false; // Nueva variable para evitar actualizaciones concurrentes
        private int ultimoFacturaID; // esta me obtiene la ultima factura en la cola siempre guardarla

        public CocinaVista()
        {
            InitializeComponent();

            updateTimer.Interval = 60000; // Intervalo de 60 segundos
            updateTimer.Tick += UpdateTimer_Tick; // Asignar el evento Tick
            updateTimer.Start(); // Iniciar el temporizador
        }

        private async void CocinaVista_Load(object sender, EventArgs e)
        {
            // Configuración inicial del TableLayoutPanel
            tableLayoutPanel1.Dock = DockStyle.Fill;

            // Agregar estilos proporcionales de filas y columnas
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.ColumnStyles.Clear();
            for (int row = 0; row < tableLayoutPanel1.RowCount; row++)
            {
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F)); // Cada fila ocupa el 50% del alto
            }
            for (int col = 0; col < tableLayoutPanel1.ColumnCount; col++)
            {
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F / tableLayoutPanel1.ColumnCount)); // Cada columna ocupa un 1/5 del ancho
            }

            // Cargar facturas en la cola
            // Obtener la lista de facturas usando FincfacturaFecha
            // Obtener la fecha actual
            try
            {
                DateTime fechaActual = DateTime.Now;

                // Convertir la fecha actual a un formato de cadena si es necesario
                fechaActualString = fechaActual.ToString("yyyy-MM-dd");
                List<facturas> facturasList = await Task.Run(() => ControladorFacturas.Instance.FincfacturaFechacocina(fechaActualString));

                // Encolar las facturas obtenidas
                foreach (var factura in facturasList)
                {
                    facturasQueue.Enqueue(factura);
                    ultimoFacturaID = (int)factura.Idfactura; // Actualizar el ID de la última factura
                }

                // Llenar inicialmente los cuadros
                UpdateTableLayoutPanel();
            }
            catch (Exception ex)
            {
                // Manejar la excepción
                MessageBox.Show($"Error al cargar datos desde la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void UpdateTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (isUpdating == false)
                {
                    // Verificar si hay espacio disponible en el TableLayoutPanel
                    if (tableLayoutPanel1.Controls.Count < tableLayoutPanel1.RowCount * tableLayoutPanel1.ColumnCount)
                    {
                        // Si hay espacio disponible, intentar agregar la siguiente factura en cola
                        await AddNextOrderToTableLayoutPanelAsync();
                    }
                    else
                    {
                        // Si no hay espacio disponible, agregar la nueva factura a la cola
                        await EnqueueNextFacturaAsync();
                    } 
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción adecuadamente
                MessageBox.Show($"Error en el manejador del temporizador: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task AddNextOrderToTableLayoutPanelAsync()
        {
            // Verificar si hay facturas en la cola
            if (facturasQueue.Count > 0)
            {
                // Obtener el siguiente elemento de la cola de facturas
                facturas nextFactura = facturasQueue.Dequeue(); // Sacar la siguiente factura de la cola

                // Crear y configurar los controles para mostrar la nueva factura
                Label comboLabel = new Label
                {
                    Text = await Task.Run(() => ObtenerTextoFactura(nextFactura)), // Obtener el texto de la factura
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.TopLeft,
                    BackColor = Color.LightCyan, // Color aleatorio para el fondo
                    BorderStyle = BorderStyle.FixedSingle,
                    Font = new Font("Arial", 14)
                };

                // Crear el Label para el tiempo transcurrido
                Label timeLabel = new Label
                {
                    Text = "Tiempo: 0:00",
                    Dock = DockStyle.Top,
                    TextAlign = ContentAlignment.TopLeft,
                    AutoSize = true,
                    Font = new Font("Arial", 10)
                };

                Button orderButton = new Button
                {
                    Text = "Finalizado",
                    Dock = DockStyle.Bottom,
                    TextAlign = ContentAlignment.MiddleCenter,
                    BackColor = Color.LightGray,
                    Height = 30,
                    Font = new Font("Arial", 16), // Tamaño de letra del botón
                    Tag = nextFactura.Orden // Asignar el ID de la orden al Tag del botón
                };

                // Crear el panel para la nueva factura
                Panel orderPanel = new Panel
                {
                    Dock = DockStyle.Fill
                };
                orderPanel.Controls.Add(comboLabel);
                orderPanel.Controls.Add(timeLabel);
                orderPanel.Controls.Add(orderButton);

                // Crear un temporizador para este panel
                Timer timer = new Timer();
                timer.Interval = 1000; // Intervalo de 1 segundo
                timer.Tick += (s, e) => Timer_Tick(s, e, orderPanel, timeLabel); // Manejar el evento Tick
                panelTimers.Add(orderPanel, timer);

                // Iniciar el temporizador
                timer.Start();

                // Asignar evento al botón
                orderButton.Click += async (s, e) => await RemovePanelAndRefreshAsync(orderPanel);

                // Agregar el panel al TableLayoutPanel
                tableLayoutPanel1.Controls.Add(orderPanel);
            }
            else
            {
                // Si no hay facturas en la cola, intentar obtener nuevas facturas
                await EnqueueNextFacturaAsync();
            }
        }

        private async Task EnqueueNextFacturaAsync()
        {
            // Obtener la última factura procesada solo si la cola está vacía
            if (facturasQueue.Count == 0)
            {
                //int ultimaFacturaID = await Task.Run(() => ObtenerUltimaFacturaID());
                // Obtener las nuevas facturas solo si hay facturas disponibles
                //if (ultimaFacturaID != 0)
                //{
                    string fechaActual = DateTime.Now.ToString("yyyy-MM-dd");
                    List<facturas> nuevasFacturas = await Task.Run(() => ControladorFacturas.Instance.ObtenernuevasFacturas(ultimoFacturaID, fechaActual));
                // Agregar las nuevas facturas a la cola
                if (nuevasFacturas != null && nuevasFacturas.Count > 0)
                    {
                    foreach (var factura in nuevasFacturas)
                    {

                        facturasQueue.Enqueue(factura);
                        ultimoFacturaID = (int)factura.Idfactura; // Actualizar el ID de la última factura
                    }
                    await AddNextOrderToTableLayoutPanelAsync();
                }
            }
            isUpdating = false;

        }

        //private int ObtenerUltimaFacturaID()
        //{
        //    if (facturasQueue.Count == 0)
        //    {
        //        // Si no hay facturas en la cola, consultar la base de datos para obtener el ID de la última factura procesada
        //        string fechaActualString = DateTime.Now.ToString("yyyy-MM-dd");
        //        facturas ultimaFactura = ControladorFacturas.Instance.ObtenerUltimaFacturaPorFecha(fechaActualString);
        //        if (ultimaFactura.Idfactura != null)
        //        {
        //            return (int)ultimaFactura.Idfactura;
        //        }
        //    }
        //    return 0; // Devolver 0 si no se encontró ninguna factura procesada o si la cola ya contiene facturas
        //}

        private async Task RemovePanelAndRefreshAsync(Panel panel)
        {
            // Detener el temporizador para evitar conflictos
            updateTimer.Stop();

            // Asegurarte de que no hay ninguna actualización en progreso
            if (isUpdating)
            {
                updateTimer.Start();
                return;
            }

            isUpdating = true;

            try
            {
                // Eliminar el panel del TableLayoutPanel
                tableLayoutPanel1.Controls.Remove(panel);

                // Verificar si hay espacio disponible en el TableLayoutPanel
                if (tableLayoutPanel1.Controls.Count < tableLayoutPanel1.RowCount * tableLayoutPanel1.ColumnCount)
                {
                    // Agregar la siguiente factura en cola al TableLayoutPanel
                    await AddNextOrderToTableLayoutPanelAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar la interfaz: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Reiniciar el temporizador
                updateTimer.Start();
                isUpdating = false;

                //MessageBox.Show("Temporizador reiniciado", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Método para obtener el texto de la factura y detalles
        private string ObtenerTextoFactura(facturas factura)
        {
            string textoFactura = $"Orden: {factura.Orden}\n";
            List<detalle_factura> detallesFactura = ControladorDetalle_Factura.Instance.findbyid((int)factura.Idfactura);
            if (detallesFactura != null && detallesFactura.Count > 0)
            {
                foreach (detalle_factura detalle in detallesFactura)
                {
                    menu menuItem = ControladorMenu.Instance.findnombre(detalle.Idmenu);
                    if (menuItem != null)
                    {
                        textoFactura += $"{detalle.Cantidad} - {menuItem.Nombrecombo}\n";
                    }
                    else
                    {
                        textoFactura += $"Detalle no encontrado para Idmenu: {detalle.Idmenu}\n";
                    }
                }
            }
            else
            {
                textoFactura += "No hay detalles disponibles.";
            }
            return textoFactura;
        }

        // Método para obtener un color aleatorio
        private Random random = new Random();
        private Color GetRandomColor()
        {
            return Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }

        // Manejador del evento Tick del temporizador
        private void Timer_Tick(object sender, EventArgs e, Panel panel, Label timeLabel)
        {
            // Obtener el temporizador correspondiente al panel
            Timer timer = sender as Timer;

            // Incrementar el tiempo transcurrido en el tag del panel
            int elapsedSeconds = Convert.ToInt32(panel.Tag) + 1;
            panel.Tag = elapsedSeconds;

            // Actualizar el Label del tiempo transcurrido
            TimeSpan timeSpan = TimeSpan.FromSeconds(elapsedSeconds);
            timeLabel.Text = $"Tiempo: {timeSpan.ToString(@"m\:ss")}"; // Formato de minutos y segundos

            // Cambiar el color del texto del Label según el tiempo transcurrido
            if (elapsedSeconds <= 5 * 60) // Menos de 5 minutos
            {
                timeLabel.ForeColor = Color.Green;
            }
            else if (elapsedSeconds <= 15 * 60) // Menos de 15 minutos
            {
                timeLabel.ForeColor = Color.Orange;
            }
            else // Más de 15 minutos
            {
                timeLabel.ForeColor = Color.Red;
            }

            // Ajustar el tamaño de la fuente del Label
            timeLabel.Font = new Font("Arial", 14, FontStyle.Bold); // Cambia "Arial" por la fuente que prefieras y 16 por el tamaño deseado
        }

        private void UpdateTableLayoutPanel()
        {
            tableLayoutPanel1.Controls.Clear(); // Limpiar el TableLayoutPanel

            for (int row = 0; row < tableLayoutPanel1.RowCount; row++)
            {
                for (int col = 0; col < tableLayoutPanel1.ColumnCount; col++)
                {
                    if (facturasQueue.Count > 0)
                    {
                        // Obtener la factura actual de la cola
                        facturas factura = facturasQueue.Dequeue();

                        // Crear una lista para almacenar el texto de los combos
                        List<string> comboTexts = new List<string>
                        {
                            $"Orden: {factura.Orden}\n"
                        };

                        // Obtener los detalles de la factura para la orden actual
                        List<detalle_factura> detallesFactura = ControladorDetalle_Factura.Instance.findbyid((int)factura.Idfactura);

                        // Asegurarse de que los detalles de la factura no están vacíos
                        if (detallesFactura != null && detallesFactura.Count > 0)
                        {
                            foreach (detalle_factura detalle in detallesFactura)
                            {
                                menu menuItem = ControladorMenu.Instance.findnombre(detalle.Idmenu);
                                // Construir el texto para el combo y agregarlo a la lista
                                string comboText = $"{detalle.Cantidad} - {menuItem.Nombrecombo}\n";
                                comboTexts.Add(comboText);
                            }
                        }
                        else
                        {
                            comboTexts.Add("No hay detalles disponibles.");
                        }

                        // Unir todos los textos de los combos en una sola cadena separada por saltos de línea
                        string allCombosText = string.Join("\n", comboTexts);

                        // Crear la etiqueta para mostrar todos los combos
                        Label comboLabel = new Label
                        {
                            Text = allCombosText,
                            Dock = DockStyle.Fill,
                            TextAlign = ContentAlignment.TopLeft,
                            BackColor = Color.LightCyan, // Color aleatorio para el fondo
                            Font = new Font("Arial", 14) // Cambia "Arial" por la fuente que prefieras y 14 por el tamaño deseado
                        };

                        // Crear un Label para mostrar el tiempo transcurrido
                        Label timeLabel = new Label
                        {
                            Text = "Tiempo: 0:00",
                            Dock = DockStyle.Top,
                            TextAlign = ContentAlignment.TopLeft,
                            AutoSize = true,
                            Font = new Font("Arial", 10) // Tamaño de la fuente
                        };

                        // Crear un botón para cada orden
                        Button orderButton = new Button
                        {
                            Text = "Finalizado",
                            Dock = DockStyle.Bottom,
                            TextAlign = ContentAlignment.MiddleCenter,
                            BackColor = Color.LightGray,
                            Height = 30,
                            Font = new Font("Arial", 16), // Tamaño de letra del botón
                            Tag = factura.Orden // Asignar el ID de la orden al Tag del botón
                        };

                        // Crear un panel para contener tanto el Label como el Button
                        Panel orderPanel = new Panel
                        {
                            Dock = DockStyle.Fill
                        };
                        orderPanel.Controls.Add(comboLabel);
                        orderPanel.Controls.Add(timeLabel); // Agregar el Label del tiempo
                        orderPanel.Controls.Add(orderButton);

                        // Crear un temporizador para este panel
                        Timer timer = new Timer();
                        timer.Interval = 1000; // Intervalo de 1 segundo
                        timer.Tick += (s, e) => Timer_Tick(s, e, orderPanel, timeLabel); // Manejar el evento Tick
                        panelTimers.Add(orderPanel, timer);

                        // Iniciar el temporizador
                        timer.Start();

                        // Asignar evento al botón
                        orderButton.Click += async (s, e) => await RemovePanelAndRefreshAsync(orderPanel);

                        // Agregar el panel al TableLayoutPanel
                        tableLayoutPanel1.Controls.Add(orderPanel, col, row);
                    }
                }
            }
        }
    }
}

