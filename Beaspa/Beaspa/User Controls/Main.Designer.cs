namespace Beaspa
{
    partial class Main
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
            this.buttonAestheticCenters = new System.Windows.Forms.Button();
            this.buttonPeople = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.placeHolderTextBoxSearch = new Beaspa.PlaceHolderTextBox();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelMain = new System.Windows.Forms.Panel();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAestheticCenters
            // 
            this.buttonAestheticCenters.BackgroundImage = global::Beaspa.Properties.Resources.House;
            this.buttonAestheticCenters.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAestheticCenters.Location = new System.Drawing.Point(664, 3);
            this.buttonAestheticCenters.Name = "buttonAestheticCenters";
            this.buttonAestheticCenters.Size = new System.Drawing.Size(32, 32);
            this.buttonAestheticCenters.TabIndex = 9;
            this.buttonAestheticCenters.UseVisualStyleBackColor = true;
            this.buttonAestheticCenters.Click += new System.EventHandler(this.buttonAestheticCenters_Click);
            // 
            // buttonPeople
            // 
            this.buttonPeople.BackgroundImage = global::Beaspa.Properties.Resources.Person;
            this.buttonPeople.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPeople.Location = new System.Drawing.Point(626, 3);
            this.buttonPeople.Name = "buttonPeople";
            this.buttonPeople.Size = new System.Drawing.Size(32, 32);
            this.buttonPeople.TabIndex = 8;
            this.buttonPeople.UseVisualStyleBackColor = true;
            this.buttonPeople.Click += new System.EventHandler(this.buttonPeople_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackgroundImage = global::Beaspa.Properties.Resources.SearchPerson;
            this.buttonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSearch.Location = new System.Drawing.Point(570, 3);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(32, 32);
            this.buttonSearch.TabIndex = 7;
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // placeHolderTextBoxSearch
            // 
            this.placeHolderTextBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic);
            this.placeHolderTextBoxSearch.ForeColor = System.Drawing.Color.Gray;
            this.placeHolderTextBoxSearch.Location = new System.Drawing.Point(3, 5);
            this.placeHolderTextBoxSearch.MaxLength = 0;
            this.placeHolderTextBoxSearch.Name = "placeHolderTextBoxSearch";
            this.placeHolderTextBoxSearch.PlaceHolderText = "Buscar...";
            this.placeHolderTextBoxSearch.Size = new System.Drawing.Size(561, 36);
            this.placeHolderTextBoxSearch.TabIndex = 6;
            this.placeHolderTextBoxSearch.Text = "Buscar...";
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(Beaspa.Logic_Files.Person);
            // 
            // panelMain
            // 
            this.panelMain.Location = new System.Drawing.Point(3, 47);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1283, 680);
            this.panelMain.TabIndex = 10;
            // 
            // buttonSave
            // 
            this.buttonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSave.Location = new System.Drawing.Point(716, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(85, 32);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "Guardar";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.buttonAestheticCenters);
            this.Controls.Add(this.buttonPeople);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.placeHolderTextBoxSearch);
            this.Name = "Main";
            this.Size = new System.Drawing.Size(1289, 730);
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAestheticCenters;
        private System.Windows.Forms.Button buttonPeople;
        private System.Windows.Forms.Button buttonSearch;
        private PlaceHolderTextBox placeHolderTextBoxSearch;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button buttonSave;
    }
}
