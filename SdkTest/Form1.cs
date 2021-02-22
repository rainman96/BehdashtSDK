using SDK;
using SDK.DataModel;
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

namespace SdkTest
{
    public partial class Form1 : Form
    {
        private static List<ResultVO> dataSource;
        private readonly Service service;
        public Form1()
        {
            service = new Service();
            InitializeComponent();
            dataSource = new List<ResultVO>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var model = GetModelFromFile<SOAPMessageVO>();
            if (model != null)
            {
               var result = service.SaveSIYABReport(model);
                AddToDataGrid(result);
            }
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
            label1.Text = "";
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
                    label1.Text = ex.Message;
                }
            }
            return default;
        }

        private void btnPatientBill_Click(object sender, EventArgs e)
        {
            var model = GetModelFromFile<PatientBillMessageVO>();
            if (model != null)
            {
                var result = service.SavePatientBill(model);
                AddToDataGrid(result);
            }
        }

        private void btnPathology_Click(object sender, EventArgs e)
        {
            var model = GetModelFromFile<LaboratoryResultMessageVO>();
            if (model != null)
            {
                var result = service.SavePathologyReport(model);
                AddToDataGrid(result);
            }
        }

        private void btnLaboratoryResult_Click(object sender, EventArgs e)
        {
            var model = GetModelFromFile<LaboratoryResultMessageVO>();
            if (model != null)
            {
                var result = service.SaveLaboratoryResult(model);
                AddToDataGrid(result);
            }
        }
    }
}
