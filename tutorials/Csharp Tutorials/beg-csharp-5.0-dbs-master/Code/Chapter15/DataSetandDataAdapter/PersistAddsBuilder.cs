﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace DataSetandDataAdapter
{
    public partial class PersistAddsBuilder : Form
    {
        public PersistAddsBuilder()
        {
            InitializeComponent();
        }

        private void PersistAddsBuilder_Load(object sender, EventArgs e)
        {
            // Connection string
            string connString = @"server=.\sql2012;database=AdventureWorks;Integrated Security=true";
            
            // Query
            string qry = @" select *
                          from HumanResources.Department
                           where GroupName = 'Research and Development' ";

            // Create connection
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                // Create Data Adapter
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand(qry, conn);

                // Create command builder
                SqlCommandBuilder cb = new SqlCommandBuilder(da);

                // Create and Fill Dataset
                DataSet ds = new DataSet();
                da.Fill(ds, "HumanResources.Department");

                // Get Data Table reference
                DataTable dt = ds.Tables["HumanResources.Department"];

                // Add a row
                DataRow newRow = dt.NewRow();
                newRow["Name"] = "Language Design";
                newRow["GroupName"] = "Research and Development";
                newRow["ModifiedDate"] = "2012-04-29";
                
                dt.Rows.Add(newRow);

                // Display rows
                foreach (DataRow row in dt.Rows)
                {
                    txtDepartment.AppendText(row["Name"].ToString());
                    txtDepartment.AppendText("\t\t");
                    txtDepartment.AppendText(row["GroupName"].ToString());
                    txtDepartment.AppendText("\t");
                    txtDepartment.AppendText(row["ModifiedDate"].ToString());
                    txtDepartment.AppendText("\n");                  
                }

                // Insert department
                da.Update(ds, "HumanResources.Department");
              }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

            finally
            {
                //Connection close
                conn.Close();
            } 
        }
    }
}
