
namespace Ditas.SDKTest
{
    partial class Form2
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
            this.btnLaboratoryResult = new System.Windows.Forms.Button();
            this.btnPathology = new System.Windows.Forms.Button();
            this.btnPatientBill = new System.Windows.Forms.Button();
            this.errorBox = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.btnPersonInfo = new System.Windows.Forms.Button();
            this.HIDButton = new System.Windows.Forms.Button();
            this.SalamatButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLaboratoryResult
            // 
            this.btnLaboratoryResult.Enabled = false;
            this.btnLaboratoryResult.Location = new System.Drawing.Point(324, 144);
            this.btnLaboratoryResult.Name = "btnLaboratoryResult";
            this.btnLaboratoryResult.Size = new System.Drawing.Size(98, 23);
            this.btnLaboratoryResult.TabIndex = 11;
            this.btnLaboratoryResult.Text = "LaboratoryResult";
            this.btnLaboratoryResult.UseVisualStyleBackColor = true;
            // 
            // btnPathology
            // 
            this.btnPathology.Enabled = false;
            this.btnPathology.Location = new System.Drawing.Point(220, 144);
            this.btnPathology.Name = "btnPathology";
            this.btnPathology.Size = new System.Drawing.Size(98, 23);
            this.btnPathology.TabIndex = 10;
            this.btnPathology.Text = "Pathology";
            this.btnPathology.UseVisualStyleBackColor = true;
            // 
            // btnPatientBill
            // 
            this.btnPatientBill.Enabled = false;
            this.btnPatientBill.Location = new System.Drawing.Point(116, 144);
            this.btnPatientBill.Name = "btnPatientBill";
            this.btnPatientBill.Size = new System.Drawing.Size(98, 23);
            this.btnPatientBill.TabIndex = 9;
            this.btnPatientBill.Text = "Patient Bill";
            this.btnPatientBill.UseVisualStyleBackColor = true;
            this.btnPatientBill.Click += new System.EventHandler(this.btnPatientBill_Click);
            // 
            // errorBox
            // 
            this.errorBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.errorBox.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorBox.ForeColor = System.Drawing.Color.Red;
            this.errorBox.Location = new System.Drawing.Point(0, 535);
            this.errorBox.Name = "errorBox";
            this.errorBox.Size = new System.Drawing.Size(800, 76);
            this.errorBox.TabIndex = 8;
            this.errorBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 359);
            this.dataGridView1.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(12, 144);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "SIYAB Report";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnPersonInfo
            // 
            this.btnPersonInfo.Location = new System.Drawing.Point(690, 144);
            this.btnPersonInfo.Name = "btnPersonInfo";
            this.btnPersonInfo.Size = new System.Drawing.Size(98, 23);
            this.btnPersonInfo.TabIndex = 12;
            this.btnPersonInfo.Text = "PersonInfo";
            this.btnPersonInfo.UseVisualStyleBackColor = true;
            this.btnPersonInfo.Click += new System.EventHandler(this.btnPersonInfo_Click);
            // 
            // HIDButton
            // 
            this.HIDButton.Location = new System.Drawing.Point(690, 115);
            this.HIDButton.Name = "HIDButton";
            this.HIDButton.Size = new System.Drawing.Size(98, 23);
            this.HIDButton.TabIndex = 13;
            this.HIDButton.Text = "HID";
            this.HIDButton.UseVisualStyleBackColor = true;
            this.HIDButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // SalamatButton
            // 
            this.SalamatButton.Location = new System.Drawing.Point(586, 144);
            this.SalamatButton.Name = "SalamatButton";
            this.SalamatButton.Size = new System.Drawing.Size(98, 23);
            this.SalamatButton.TabIndex = 14;
            this.SalamatButton.Text = "Drug Salamat";
            this.SalamatButton.UseVisualStyleBackColor = true;
            this.SalamatButton.Click += new System.EventHandler(this.SalamatButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 611);
            this.Controls.Add(this.SalamatButton);
            this.Controls.Add(this.HIDButton);
            this.Controls.Add(this.btnPersonInfo);
            this.Controls.Add(this.btnLaboratoryResult);
            this.Controls.Add(this.btnPathology);
            this.Controls.Add(this.btnPatientBill);
            this.Controls.Add(this.errorBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLaboratoryResult;
        private System.Windows.Forms.Button btnPathology;
        private System.Windows.Forms.Button btnPatientBill;
        private System.Windows.Forms.Label errorBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnPersonInfo;
        private System.Windows.Forms.Button HIDButton;
        private System.Windows.Forms.Button SalamatButton;
    }
}