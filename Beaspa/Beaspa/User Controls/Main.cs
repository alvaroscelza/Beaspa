using Beaspa.Logic_Files;
using Beaspa.User_Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Beaspa
{
    public partial class Main : UserControl
    {
        private PersistenceManager PersistenceManager { get; set; }
        private People PeopleUserControl { get; set; }

        public Main()
        {
            InitializeComponent();
            SetStyle(ControlStyles.Selectable, false);
            PersistenceManager = new PersistenceManager();
            PersistenceManager.Load();
            buttonSearch.Enabled = false;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string filter = placeHolderTextBoxSearch.Text;
            string lowerCaseFilter = filter.ToLower();
            List<Person> filteredPeople = PersistenceManager.People.FindAll(p => p.NameAndSurname.ToLower().Contains(lowerCaseFilter) || p.AestheticCenters.Any(ac => ac.Name.ToLower().Contains(lowerCaseFilter)));
            PeopleUserControl.showOnlyThisPeople(filteredPeople);
        }

        private void buttonPeople_Click(object sender, EventArgs e)
        {
            EmptyPanel();
            PeopleUserControl = new People(PersistenceManager);
            panelMain.Controls.Add(PeopleUserControl);
            buttonSearch.Enabled = true;
        }

        public void EmptyPanel()
        {
            if (!panelIsEmpty())
                panelMain.Controls.RemoveAt(0);
        }

        private bool panelIsEmpty()
        {
            return panelMain.Controls.Count == 0;
        }

        private void buttonAestheticCenters_Click(object sender, EventArgs e)
        {
            AestheticCenters aestheticCenter = new AestheticCenters(PersistenceManager.AestheticCenters);
            aestheticCenter.ShowDialog();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            PersistenceManager.Save();
        }
    }
}
