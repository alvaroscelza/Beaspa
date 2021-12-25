namespace Beaspa
{
    partial class PersonAestheticCenters
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
            this.checkedListBoxAestheticCenters = new System.Windows.Forms.CheckedListBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBoxAestheticCenters
            // 
            this.checkedListBoxAestheticCenters.CheckOnClick = true;
            this.checkedListBoxAestheticCenters.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkedListBoxAestheticCenters.FormattingEnabled = true;
            this.checkedListBoxAestheticCenters.Location = new System.Drawing.Point(12, 12);
            this.checkedListBoxAestheticCenters.Name = "checkedListBoxAestheticCenters";
            this.checkedListBoxAestheticCenters.Size = new System.Drawing.Size(307, 235);
            this.checkedListBoxAestheticCenters.TabIndex = 34;
            // 
            // buttonOk
            // 
            this.buttonOk.BackgroundImage = global::Beaspa.Properties.Resources.Tick;
            this.buttonOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonOk.Location = new System.Drawing.Point(269, 253);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(50, 50);
            this.buttonOk.TabIndex = 36;
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // AddAestheticCentersToPerson
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(337, 313);
            this.ControlBox = false;
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.checkedListBoxAestheticCenters);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddAestheticCentersToPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar Centros de Estética a Paciente";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckedListBox checkedListBoxAestheticCenters;
        private System.Windows.Forms.Button buttonOk;
    }
}