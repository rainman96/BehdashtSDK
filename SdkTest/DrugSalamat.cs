using Ditas.SDK;
using Ditas.SDK.DataModel;
using Ditas.SDK.DataModel.Response;
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
    public partial class DrugSalamat : Form
    {
        private static List<ResultVO> dataSource;
        private readonly Service service;
        public DrugSalamat()
        {
            service = new Service();
            InitializeComponent();
            dataSource = new List<ResultVO>();

        }
        private void AddToDataGrid(ResultVO result)
        {
            dataSource.Add(result);
            BindingSource binding = new BindingSource();
            binding.DataSource = dataSource;
            dataGridView1.DataSource = binding;
            //dataGridView1.Columns["ErrorMessage"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var model = GetModelFromFile<MedicationPrescriptionsMessageVO>();
                var result = service.SaveMedicationPrescription(model);
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
