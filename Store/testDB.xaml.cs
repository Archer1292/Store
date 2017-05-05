using System;
using System.Windows;
using System.Windows.Controls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace Store
{
    /// <summary>
    /// Interaction logic for testDB.xaml
    /// </summary>
    public partial class testDB : Window
    {
        string connectionString;
        SqlDataAdapter adapter;
        DataTable usersTable;
        public testDB()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["StoreDBConnection"].ConnectionString;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string sql = "SELECT * FROM Users";
            usersTable = new DataTable();
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(sql, connection);
                adapter = new SqlDataAdapter(command);

                // установка команды на добавление для вызова хранимой процедуры
                adapter.InsertCommand = new SqlCommand("sp_InsertUser", connection);
                adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@id", SqlDbType.Int, 0, "User_id"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@login", SqlDbType.NVarChar,0, "Login"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@password", SqlDbType.NVarChar, 0, "Password"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@employee", SqlDbType.Int, 0, "Employee"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@access_rights", SqlDbType.NVarChar, 0, "Access_rights"));
                //SqlParameter parameter = adapter.InsertCommand.Parameters.Add("@Id", SqlDbType.Int, 0, "User_id");
               // parameter.Direction = ParameterDirection.Output;

                connection.Open();
                adapter.Fill(usersTable);
                phonesGrid.ItemsSource = usersTable.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }

        }
        private void UpdateDB()
        {
            SqlCommandBuilder comandbuilder = new SqlCommandBuilder(adapter);
            adapter.Update(usersTable);
        }
        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            UpdateDB();
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (phonesGrid.SelectedItems != null)
            {
                for (int i = 0; i < phonesGrid.SelectedItems.Count; i++)
                {
                    DataRowView datarowView = phonesGrid.SelectedItems[i] as DataRowView;
                    if (datarowView != null)
                    {
                        DataRow dataRow = (DataRow)datarowView.Row;
                        dataRow.Delete();
                    }
                }
            }
            UpdateDB();
        }
    }
}
