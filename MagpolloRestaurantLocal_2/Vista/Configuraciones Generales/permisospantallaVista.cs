using AppTRchicken.Controlador;
using AppTRchicken.Modelo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace AppTRchicken.Vista.Configuraciones_Generales
{
    public partial class permisospantallaVista : Form
    {
        public permisospantallaVista()
        {
            InitializeComponent();
        }

        private static permisospantallaVista fmrpermisospantallaVista = null;

        internal static permisospantallaVista Abrir1vez()
        {
            if (((fmrpermisospantallaVista == null) || (fmrpermisospantallaVista.IsDisposed == true)))
            {
                fmrpermisospantallaVista = new permisospantallaVista();
            }
            fmrpermisospantallaVista.BringToFront();
            return fmrpermisospantallaVista;
        }
        private void permisospantallaVista_Load(object sender, EventArgs e)
        {

          // Desactivar el evento SelectedIndexChanged del ComboBox temporalmente
    cbroles.SelectedIndexChanged -= cbroles_SelectedIndexChanged;

            // Cargar los roles en el ComboBox
            refrescar();

            // Volver a activar el evento SelectedIndexChanged del ComboBox
            cbroles.SelectedIndexChanged += cbroles_SelectedIndexChanged;

        }

        private void btnagregarpermisos_Click(object sender, EventArgs e)
        {
            roles roles = new roles();
            roles = ControladorRoles.Instance.findIdbyname(cbroles.Text);

            // Suponiendo que tienes un CheckedListBox llamado checkedListBox1 en tu formulario
            List<string> elementosSeleccionados = new List<string>();




            // Iterar sobre los elementos del checklistboxpantallas
            for (int i = 0; i < listboxpantallas.Items.Count; i++)
            {
                // Obtener el nombre de la pantalla del checklistbox
                string nombrePantalla = listboxpantallas.Items[i].ToString();

                // Agregar el nombre de la pantalla a la lista elementosSeleccionados
                elementosSeleccionados.Add(nombrePantalla);

                // Buscar la pantalla en la base de datos
                pantallas pantallas = new pantallas();

                pantallas = ControladorPantallas.Instance.findIdbyname(nombrePantalla);

                // Crear un nuevo objeto permisospantalla
                permisospantalla permisospantalla = new permisospantalla();
                permisospantalla.Idrole = roles.Idrole;
                permisospantalla.Idpantalla = pantallas.Idpantalla;

                // Verificar si el elemento está seleccionado en el checklistbox
                bool seleccionada = listboxpantallas.GetItemChecked(i);

                // Establecer el valor de acceso
                permisospantalla.Acceso = seleccionada;

                // Verificar si el permiso ya existe antes de insertarlo o actualizarlo
                if (ControladorPermisosPantalla.Instance.existsPantallaParaRol((int)roles.Idrole, (int)pantallas.Idpantalla))
                {
                    // El permiso existe, así que lo actualizamos
                    ControladorPermisosPantalla.Instance.update(permisospantalla);
                }
                else
                {
                    // El permiso no existe, así que lo agregamos
                    ControladorPermisosPantalla.Instance.save(permisospantalla);
                }
            }

            MessageBox.Show("Permisos Actualizados ");
            refrescar();


        }



        void refrescar()
        {

            // Obtener el rol seleccionado en el ComboBox
            roles selectedRole = ControladorRoles.Instance.findIdbyname(cbroles.Text);

            // Verificar si se seleccionó un rol válido
            if (selectedRole != null)
            {
                // Obtener los permisos de pantalla asociados al rol seleccionado
                List<permisospantalla> permisosPantalla = ControladorPermisosPantalla.Instance.findAllpermisos((int)selectedRole.Idrole);

                // Limpiar el CheckedListBox
                listboxpantallas.Items.Clear();

                // Obtener todas las pantallas disponibles en el sistema
                List<pantallas> todasLasPantallas = ControladorPantallas.Instance.findAll();

                // Iterar sobre todas las pantallas y agregarlas al CheckedListBox
                foreach (pantallas pantalla in todasLasPantallas)
                {
                    // Verificar si el rol tiene acceso a esta pantalla
                    permisospantalla permiso = permisosPantalla.FirstOrDefault(p => p.Idpantalla == pantalla.Idpantalla);
                    bool tieneAcceso = permiso != null && permiso.Acceso;

                    // Agregar la pantalla al CheckedListBox, marcándola como seleccionada si tiene acceso
                    listboxpantallas.Items.Add(pantalla.Nombrepantalla, tieneAcceso);
                }
            }

            cbroles.DataSource = ControladorRoles.Instance.Cargarcomboxroles();
            cbroles.DisplayMember = "role";
            cbroles.ValueMember = "idrole";


        }

        private void cbroles_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificar si hay algún elemento seleccionado en el ComboBox
            if (cbroles.SelectedIndex != -1)
            {
                // Obtener el rol seleccionado en el ComboBox
                roles selectedRole = ControladorRoles.Instance.findIdbyname(cbroles.Text);

                // Verificar si se seleccionó un rol válido
                if (selectedRole != null)
                {


                    // Limpiar el CheckedListBox
                    listboxpantallas.Items.Clear();
                    // Obtener los permisos de pantalla asociados al rol seleccionado
                    List<permisospantalla> permisosPantalla = ControladorPermisosPantalla.Instance.findAllpermisos((int)selectedRole.Idrole);

                   

                    // Obtener todas las pantallas disponibles en el sistema
                    List<pantallas> todasLasPantallas = ControladorPantallas.Instance.findAll();

                    // Iterar sobre todas las pantallas y agregarlas al CheckedListBox
                    foreach (pantallas pantalla in todasLasPantallas)
                    {
                            // Verificar si el rol tiene acceso a esta pantalla
                            permisospantalla permiso = permisosPantalla.FirstOrDefault(p => p.Idpantalla == pantalla.Idpantalla);

                            // Determinar si la pantalla tiene acceso y marcarla como seleccionada en el CheckedListBox
                            bool tieneAcceso = permiso != null && permiso.Acceso;
                            listboxpantallas.Items.Add(pantalla.Nombrepantalla, tieneAcceso);
                        
                    }
                }
            }

        }
    }
}



    









//esta funcion es para obtener todas las pantallas del proyecto y se agregan a la base de datos con un boton 
//private string[] ObtenerNombresPantallas()
//{
//    // Obtener el ensamblado de la aplicación
//    Assembly assembly = Assembly.GetExecutingAssembly();

//    // Obtener todos los tipos definidos en el ensamblado
//    var types = assembly.GetTypes();

//    // Filtrar los tipos que son subclases de Form
//    var formTypes = types.Where(type => type.IsSubclassOf(typeof(Form)));

//    // Obtener los nombres de las clases encontradas
//    var formNames = formTypes.Select(type => type.Name).ToArray();

//    return formNames;
//}

//private void btn1_Click(object sender, EventArgs e)
//{
//    // Obtener los nombres de las pantallas
//    string[] nombresPantallas = ObtenerNombresPantallas();

//    // Crear un objeto pantallas para cada nombre de pantalla y guardarlos
//    foreach (var nombrePantalla in nombresPantallas)
//    {
//        pantallas pantalla = new pantallas();
//        pantalla.Nombrepantalla = nombrePantalla;

//        try
//        {
//            // Intentar guardar la pantalla en la base de datos
//            ControladorPantallas.Instance.save(pantalla);
//            MessageBox.Show($"Pantalla '{nombrePantalla}' agregada correctamente");
//        }
//        catch (Exception ex)
//        {
//            // Capturar cualquier excepción que ocurra al intentar guardar la pantalla
//            MessageBox.Show($"Error al agregar pantalla '{nombrePantalla}': {ex.Message}");
//        }
//    }
//}