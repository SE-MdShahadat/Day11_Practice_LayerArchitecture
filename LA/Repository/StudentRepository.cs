using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA.Repository
{
    public class StudentRepository
    {
        string connectionString = @"Server=MDSHAHADAT; Database=StudentDB; Integrated Security=true;";
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        string commandString;

        

        public DataTable LoadDepartment()
        {
            sqlConnection = new SqlConnection(connectionString);
            commandString = @"Select * From Departments";
            sqlCommand = new SqlCommand(commandString, sqlConnection);
            
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            //if (dataTable.Rows.Count > 0)
            //{
            //    departmentComboBox.DataSource = dataTable;
            //}
            
            sqlConnection.Close();
            return dataTable;



        }
    }
}
