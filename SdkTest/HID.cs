using Ditas.SDK;
using Ditas.SDK.DataModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ditas.SDKTest
{
    public partial class HID : Form
    {
        private static List<DO_IDENTIFIER> dataSource;
        private readonly Service service;
        public HID()
        {
            service = new Service();
            InitializeComponent();
            dataSource = new List<DO_IDENTIFIER>();

        }
        private void AddToDataGrid(DO_IDENTIFIER result)
        {
            dataSource.Add(result);
            BindingSource binding = new BindingSource();
            binding.DataSource = dataSource;
            dataGridView1.DataSource = binding;
            //dataGridView1.Columns["ErrorMessage"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                var result = service.GetHID("4160262661", 
                    new DO_IDENTIFIER { Assigner = "", ID = "11116", Issuer = "", Type = "" },
                    new DO_CODED_TEXT {Coded_string="1" },
                    new DO_IDENTIFIER { Assigner = "", ID = "3E87DC76-A67A-4A77-B0F6-39D6AEBF2A42", Issuer = "", Type = "" });
                if (result != null)
                    AddToDataGrid(result);
                else
                    errorBox.Text = "Model was null";
            }
            catch (Exception ex)
            {
                errorBox.Text = ex.Message;
            }
        }
    }
}
