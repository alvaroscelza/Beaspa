namespace Beaspa.User_Controls
{
    partial class People
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aestheticCentersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aestheticCentersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aestheticCentersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.aestheticCenterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.AestheticCentersButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.nameAndSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisitsButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicSociety = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MobileEmergency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Occupation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observations = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diabetes = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.HeartProblems = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Hypertension = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MetallicProsthesis = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Pacemaker = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AllergiesCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AllergiesDescriptionTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pregnancies = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Surgeries = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aestheticCentersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aestheticCentersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aestheticCentersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aestheticCenterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imageDataGridViewImageColumn,
            this.AestheticCentersButtonColumn,
            this.nameAndSurnameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.VisitsButtonColumn,
            this.BirthDate,
            this.CI,
            this.Address,
            this.MedicSociety,
            this.MobileEmergency,
            this.Occupation,
            this.Observations,
            this.Diabetes,
            this.HeartProblems,
            this.Hypertension,
            this.MetallicProsthesis,
            this.Pacemaker,
            this.AllergiesCheckBoxColumn,
            this.AllergiesDescriptionTextBoxColumn,
            this.Pregnancies,
            this.Surgeries});
            this.dataGridView.DataSource = this.personBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView.RowTemplate.Height = 100;
            this.dataGridView.Size = new System.Drawing.Size(1283, 680);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView_DataBindingComplete);
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(Beaspa.Logic_Files.Person);
            // 
            // aestheticCentersBindingSource
            // 
            this.aestheticCentersBindingSource.DataMember = "AestheticCenters";
            this.aestheticCentersBindingSource.DataSource = this.personBindingSource;
            // 
            // aestheticCentersBindingSource1
            // 
            this.aestheticCentersBindingSource1.DataMember = "AestheticCenters";
            this.aestheticCentersBindingSource1.DataSource = this.personBindingSource;
            // 
            // aestheticCentersBindingSource2
            // 
            this.aestheticCentersBindingSource2.DataMember = "AestheticCenters";
            this.aestheticCentersBindingSource2.DataSource = this.personBindingSource;
            // 
            // aestheticCenterBindingSource
            // 
            this.aestheticCenterBindingSource.DataSource = typeof(Beaspa.Logic_Files.AestheticCenter);
            // 
            // imageDataGridViewImageColumn
            // 
            this.imageDataGridViewImageColumn.DataPropertyName = "Image";
            this.imageDataGridViewImageColumn.FillWeight = 100.0964F;
            this.imageDataGridViewImageColumn.HeaderText = "Imagen";
            this.imageDataGridViewImageColumn.MinimumWidth = 100;
            this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            // 
            // AestheticCentersButtonColumn
            // 
            this.AestheticCentersButtonColumn.HeaderText = "Centros de Estética";
            this.AestheticCentersButtonColumn.Name = "AestheticCentersButtonColumn";
            this.AestheticCentersButtonColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AestheticCentersButtonColumn.Width = 123;
            // 
            // nameAndSurnameDataGridViewTextBoxColumn
            // 
            this.nameAndSurnameDataGridViewTextBoxColumn.DataPropertyName = "NameAndSurname";
            this.nameAndSurnameDataGridViewTextBoxColumn.FillWeight = 137.4259F;
            this.nameAndSurnameDataGridViewTextBoxColumn.HeaderText = "Nombre y Apellido";
            this.nameAndSurnameDataGridViewTextBoxColumn.MinimumWidth = 140;
            this.nameAndSurnameDataGridViewTextBoxColumn.Name = "nameAndSurnameDataGridViewTextBoxColumn";
            this.nameAndSurnameDataGridViewTextBoxColumn.Width = 140;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.FillWeight = 87.37987F;
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Teléfono";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 70;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 93;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.FillWeight = 74.81558F;
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 140;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 140;
            // 
            // VisitsButtonColumn
            // 
            this.VisitsButtonColumn.HeaderText = "Visitas";
            this.VisitsButtonColumn.MinimumWidth = 100;
            this.VisitsButtonColumn.Name = "VisitsButtonColumn";
            // 
            // BirthDate
            // 
            this.BirthDate.DataPropertyName = "BirthDate";
            this.BirthDate.HeaderText = "Fecha de Nacimiento";
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Width = 155;
            // 
            // CI
            // 
            this.CI.DataPropertyName = "CI";
            this.CI.HeaderText = "CI";
            this.CI.Name = "CI";
            this.CI.Width = 49;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Dirección";
            this.Address.Name = "Address";
            this.Address.Width = 96;
            // 
            // MedicSociety
            // 
            this.MedicSociety.DataPropertyName = "MedicSociety";
            this.MedicSociety.HeaderText = "Sociedad Médica";
            this.MedicSociety.Name = "MedicSociety";
            this.MedicSociety.Width = 133;
            // 
            // MobileEmergency
            // 
            this.MobileEmergency.DataPropertyName = "MobileEmergency";
            this.MobileEmergency.HeaderText = "Emergencia Móvil";
            this.MobileEmergency.Name = "MobileEmergency";
            this.MobileEmergency.Width = 136;
            // 
            // Occupation
            // 
            this.Occupation.DataPropertyName = "Occupation";
            this.Occupation.HeaderText = "Ocupación";
            this.Occupation.Name = "Occupation";
            this.Occupation.Width = 105;
            // 
            // Observations
            // 
            this.Observations.DataPropertyName = "Observations";
            this.Observations.HeaderText = "Observaciones";
            this.Observations.Name = "Observations";
            this.Observations.Width = 132;
            // 
            // Diabetes
            // 
            this.Diabetes.DataPropertyName = "Diabetes";
            this.Diabetes.HeaderText = "Diabetes";
            this.Diabetes.Name = "Diabetes";
            this.Diabetes.Width = 70;
            // 
            // HeartProblems
            // 
            this.HeartProblems.DataPropertyName = "HeartProblems";
            this.HeartProblems.HeaderText = "Problemas Cardíacos";
            this.HeartProblems.Name = "HeartProblems";
            this.HeartProblems.Width = 133;
            // 
            // Hypertension
            // 
            this.Hypertension.DataPropertyName = "Hypertension";
            this.Hypertension.HeaderText = "Hipertensión";
            this.Hypertension.Name = "Hypertension";
            this.Hypertension.Width = 94;
            // 
            // MetallicProsthesis
            // 
            this.MetallicProsthesis.DataPropertyName = "MetallicProsthesis";
            this.MetallicProsthesis.HeaderText = "Protesis Metálicas";
            this.MetallicProsthesis.Name = "MetallicProsthesis";
            this.MetallicProsthesis.Width = 115;
            // 
            // Pacemaker
            // 
            this.Pacemaker.DataPropertyName = "Pacemaker";
            this.Pacemaker.HeaderText = "Marcapasos";
            this.Pacemaker.Name = "Pacemaker";
            this.Pacemaker.Width = 91;
            // 
            // AllergiesCheckBoxColumn
            // 
            this.AllergiesCheckBoxColumn.DataPropertyName = "Allergies";
            this.AllergiesCheckBoxColumn.HeaderText = "Alergias";
            this.AllergiesCheckBoxColumn.Name = "AllergiesCheckBoxColumn";
            this.AllergiesCheckBoxColumn.Width = 65;
            // 
            // AllergiesDescriptionTextBoxColumn
            // 
            this.AllergiesDescriptionTextBoxColumn.DataPropertyName = "AllergiesDescription";
            this.AllergiesDescriptionTextBoxColumn.HeaderText = "Descripción de Alergias";
            this.AllergiesDescriptionTextBoxColumn.Name = "AllergiesDescriptionTextBoxColumn";
            this.AllergiesDescriptionTextBoxColumn.Width = 124;
            // 
            // Pregnancies
            // 
            this.Pregnancies.DataPropertyName = "Pregnancies";
            this.Pregnancies.HeaderText = "Embarazos";
            this.Pregnancies.Name = "Pregnancies";
            this.Pregnancies.Width = 85;
            // 
            // Surgeries
            // 
            this.Surgeries.DataPropertyName = "Surgeries";
            this.Surgeries.HeaderText = "Cirugías";
            this.Surgeries.Name = "Surgeries";
            this.Surgeries.Width = 65;
            // 
            // People
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.dataGridView);
            this.Name = "People";
            this.Size = new System.Drawing.Size(1283, 680);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aestheticCentersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aestheticCentersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aestheticCentersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aestheticCenterBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource aestheticCentersBindingSource;
        private System.Windows.Forms.BindingSource aestheticCentersBindingSource1;
        private System.Windows.Forms.BindingSource aestheticCenterBindingSource;
        private System.Windows.Forms.BindingSource aestheticCentersBindingSource2;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewButtonColumn AestheticCentersButtonColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameAndSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn VisitsButtonColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicSociety;
        private System.Windows.Forms.DataGridViewTextBoxColumn MobileEmergency;
        private System.Windows.Forms.DataGridViewTextBoxColumn Occupation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observations;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Diabetes;
        private System.Windows.Forms.DataGridViewCheckBoxColumn HeartProblems;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Hypertension;
        private System.Windows.Forms.DataGridViewCheckBoxColumn MetallicProsthesis;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Pacemaker;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AllergiesCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AllergiesDescriptionTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Pregnancies;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Surgeries;
    }
}
