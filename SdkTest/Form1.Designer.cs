
namespace SdkTest
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPatientBill = new System.Windows.Forms.Button();
            this.btnPathology = new System.Windows.Forms.Button();
            this.btnLaboratoryResult = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "SIYAB Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 316);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(0, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 76);
            this.label1.TabIndex = 2;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPatientBill
            // 
            this.btnPatientBill.Location = new System.Drawing.Point(116, 26);
            this.btnPatientBill.Name = "btnPatientBill";
            this.btnPatientBill.Size = new System.Drawing.Size(98, 23);
            this.btnPatientBill.TabIndex = 3;
            this.btnPatientBill.Text = "Patient Bill";
            this.btnPatientBill.UseVisualStyleBackColor = true;
            this.btnPatientBill.Click += new System.EventHandler(this.btnPatientBill_Click);
            // 
            // btnPathology
            // 
            this.btnPathology.Location = new System.Drawing.Point(220, 26);
            this.btnPathology.Name = "btnPathology";
            this.btnPathology.Size = new System.Drawing.Size(98, 23);
            this.btnPathology.TabIndex = 4;
            this.btnPathology.Text = "Pathology";
            this.btnPathology.UseVisualStyleBackColor = true;
            this.btnPathology.Click += new System.EventHandler(this.btnPathology_Click);
            // 
            // btnLaboratoryResult
            // 
            this.btnLaboratoryResult.Location = new System.Drawing.Point(324, 26);
            this.btnLaboratoryResult.Name = "btnLaboratoryResult";
            this.btnLaboratoryResult.Size = new System.Drawing.Size(98, 23);
            this.btnLaboratoryResult.TabIndex = 5;
            this.btnLaboratoryResult.Text = "LaboratoryResult";
            this.btnLaboratoryResult.UseVisualStyleBackColor = true;
            this.btnLaboratoryResult.Click += new System.EventHandler(this.btnLaboratoryResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLaboratoryResult);
            this.Controls.Add(this.btnPathology);
            this.Controls.Add(this.btnPatientBill);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPatientBill;
        private System.Windows.Forms.Button btnPathology;
        private System.Windows.Forms.Button btnLaboratoryResult;
    }
}

