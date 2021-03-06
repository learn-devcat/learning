﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace DataSetandDataAdapter
{
    public partial class DataViews : Form
    {
        public DataViews()
        {
            InitializeComponent();
        }

        private void DataViews_Load(object sender, EventArgs e)
        {
            // Connection string
            string connString = @"server=.\sql2012;database=AdventureWorks;Integrated Security=true";

            // Query 
            string sql = @"select FirstName, MiddleName
                           from Person.Contact";

            // Create connection
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                // Create Data Adapter
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand(sql, conn);

                // Create and Fill Dataset
                DataSet ds = new DataSet();

                da.Fill(ds, "Person.Contact");

                // Get Data Table reference
                DataTable dt = ds.Tables["Person.Contact"];

                // Create Data View
                DataView dv = new DataView(dt,
                   "MiddleName = 'J.'",
                   "MiddleName",
                   DataViewRowState.CurrentRows);

                // Display data from data view
                gvContact.DataSource = dv;
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
