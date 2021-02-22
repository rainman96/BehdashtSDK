using Ditas.SDK;
using Ditas.SDK.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Ditas.SDKTest
{
    public partial class Form2 : Form
    {
        private static List<ResultVO> dataSource;
        private readonly Service service;
        public Form2()
        {
            service = new Service();
            InitializeComponent();
            dataSource = new List<ResultVO>();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //var response = service.Login(new LoginRequest {Password= txtPassword.Text, Username = txtUsername.Text});

            //btnPatientBill.Enabled = false;
            //if (response.HttpCode== (int)System.Net.HttpStatusCode.OK)
            //{
            //    EnableButtons();
            //}
            //errorBox.Text = response.Message;

        }

        private void EnableButtons()
        {
            btnPatientBill.Enabled = true;
            btnPersonInfo.Enabled = true;
            HIDButton.Enabled = true;
            SalamatButton.Enabled = true;
        }

        private void btnPatientBill_Click(object sender, EventArgs e)
        {
            //var model = GetModelFromFile<PatientBillMessageVO>();
            //if (model != null)
            //{
            //    var result = service.SavePatientBill(model);
            //    AddToDataGrid(result);
            //}
        }
        private void AddToDataGrid(ResultVO result)
        {
            dataSource.Add(result);
            BindingSource binding = new BindingSource();
            binding.DataSource = dataSource;
            dataGridView1.DataSource = binding;
            dataGridView1.Columns["ErrorMessage"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private T GetModelFromFile<T>()
        {
            errorBox.Text = "";
            OpenFileDialog open = new OpenFileDialog();

            if (open.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

                try
                {
                    using (Stream file = System.IO.File.OpenRead(open.FileName))
                    {
                        return (T)xmlSerializer.Deserialize(file);
                    }
                }
                catch (Exception ex)
                {
                    errorBox.Text = ex.Message;
                }
            }
            return default;
        }

        private void btnPersonInfo_Click(object sender, EventArgs e)
        {
            new PersonInfo().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new HID().ShowDialog();

        }

        private void SalamatButton_Click(object sender, EventArgs e)
        {
            new DrugSalamat().ShowDialog();

        }
    }
}
