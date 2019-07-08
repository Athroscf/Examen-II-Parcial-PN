using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ExamenPNChristopherFiallos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        SqlConnection sqlConnection;

        public MainWindow()
        {
            InitializeComponent();

            //Connection String ERP
            string connectionString = ConfigurationManager.ConnectionStrings["ExamenPNChristopherFiallos.Properties.Settings.ERPConnectionString"].ConnectionString;
            sqlConnection = new SqlConnection(connectionString);
        }

        private void BtnAgregarUsuario_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnModificarUsuario_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnEliminarUsuario_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnVerUsuarios_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AgregarUsuario()
        {

        }

        private void ModificarUsuario()
        {

        }

        private void EliminarUsuario()
        {

        }

        private void VerUsuarios()
        {
            try
            {
                // El query ha realizar en la BD
                string query = "SELECT * FROM Usuarios.Usuario WHERE estado = activo";

                // SqlDataAdapter es una interfaz entre las tablas y los objetos utilizables en C#
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);

                using (sqlDataAdapter)
                {
                    // Objecto en C# que refleja una tabla de una BD
                    DataTable tablaZoologico = new DataTable();

                    // Llenar el objeto de tipo DataTable
                    sqlDataAdapter.Fill(tablaZoologico);

                    // ¿Cuál información de la tabla en el DataTable debería se desplegada en nuestro ListBox?
                    lvMostrarUsuarios.DisplayMemberPath = "ciudad";
                    // ¿Qué valor debe ser entregado cuando un elemento de nuestro ListBox es seleccionado?
                    lvMostrarUsuarios.SelectedValuePath = "id";
                    // ¿Quién es la referencia de los datos para el ListBox (popular)
                    lvMostrarUsuarios.ItemsSource = tablaZoologico.DefaultView;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
