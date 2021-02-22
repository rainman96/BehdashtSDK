using Ditas.SDK;
using Ditas.SDK.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Ditas.SDKTest
{
    public partial class PersonInfo : Form
    {
        private static List<PersonVO> dataSource;
        private readonly Service service;
        public PersonInfo()
        {
            service = new Service();
            InitializeComponent();
            dataSource = new List<PersonVO>();

        }
        private void AddToDataGrid(PersonVO result)
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
                var result = service.GetPersonByBirth(txtUsername.Text, int.Parse(txtPassword.Text));
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
