using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace courseWpf.DBClasses
{
    public class DbClass
    {
        SqlConnection connection = null;
        SqlCommand command;
        SqlDataAdapter adapter;
        static SqlConnection conn = new SqlConnection(@"Data Source = DBOND; Initial Catalog = volunteerOrganization; Integrated Security = True");
        string connectionString = "Data Source = DBOND; Initial Catalog = volunteerOrganization; Integrated Security = True";
        public void GetAndShowData(string SQLQuery, DataGrid dataGrid)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();

            command = new SqlCommand(SQLQuery, connection);
            adapter = new SqlDataAdapter(command);
            DataTable Table = new DataTable();
            adapter.Fill(Table);
            dataGrid.ItemsSource = Table.DefaultView;

            connection.Close();
        }
        public void RecordsData(string sqlQ, DataGrid dataGrid)
        {
            try
            {
                GetAndShowData(sqlQ, dataGrid);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public String[] GetComboData(string typeOfData, string tableName)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            String[] Items = { "" };
            if (connection.State == System.Data.ConnectionState.Open)
            {
                SqlDataAdapter DataLogins = new SqlDataAdapter($"SELECT {typeOfData} FROM {tableName}", connection);
                DataTable logs = new DataTable();
                DataLogins.Fill(logs);
                Items = new String[logs.Rows.Count];
                for (int i = 0; i < logs.Rows.Count; i++)
                {
                    Items[i] = logs.Rows[i][0].ToString();
                }
            }
            connection.Close();
            return Items;
        }
        public List<String> ReadData(string query, int countOfRows)
        {
            SqlCommand command = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<string> str = new List<string>();
            while (reader.Read())
            {
                for (int i = 0; i < countOfRows; i++)
                {
                    str.Add(reader[i].ToString());
                }
            }
            reader.Close();
            conn.Close();
            return  str;
        }
    }
}
