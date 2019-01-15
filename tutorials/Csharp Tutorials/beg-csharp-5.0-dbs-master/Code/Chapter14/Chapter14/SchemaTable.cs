﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace DataReaderForms
{
    public partial class SchemaTable : Form
    {
        public SchemaTable()
        {
            InitializeComponent();
        }

        private void SchemaTable_Load(object sender, EventArgs e)
        {
            // Connection string
            string connString = @"server=.\sql2012; database=AdventureWorks;Integrated Security=SSPI";
            
            // Query 
            string sql = @"select * from  Person.Address";

            // Create connection
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader rdr = cmd.ExecuteReader();

                // Store Employees schema in a data table
                DataTable schema = rdr.GetSchemaTable();

                // Display info from each row in the data table.
                // Each row describes a column in the database table.
                foreach (DataRow row in schema.Rows)
                {
                    foreach (DataColumn col in schema.Columns)
                    {
                        txtSchema.AppendText(col.ColumnName + " = " + row[col]);
                        txtSchema.AppendText("\n");
                    }
                    txtSchema.AppendText("-----------------");
                }

                //Close reader
                rdr.Close();
                
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString() );
            }
            finally
            {
                //connection close
                conn.Close();
            } 
        }
    }
}
