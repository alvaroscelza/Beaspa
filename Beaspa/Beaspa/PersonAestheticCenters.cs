using Beaspa.Logic_Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Beaspa
{
    public partial class PersonAestheticCenters : Form
    {
        public Person Person { get; set; }

        public PersonAestheticCenters(List<AestheticCenter> allCenters, Person person)
        {
            InitializeComponent();
            Person = person;
            loadAestheticCenters(allCenters);
        }

        private void loadAestheticCenters(List<AestheticCenter> allCenters)
        {
            checkedListBoxAestheticCenters.DataSource = allCenters;
            checkedListBoxAestheticCenters.DisplayMember = "Name";
            setAlreadyCheckedCenters();
        }

        private void setAlreadyCheckedCenters()
        {
            foreach (var checkedCenter in Person.AestheticCenters)
            {
                if (checkedListBoxAestheticCenters.Items.Contains(checkedCenter))
                {
                    int checkedCenterIndexInListBox = checkedListBoxAestheticCenters.Items.IndexOf(checkedCenter);
                    checkedListBoxAestheticCenters.SetItemChecked(checkedCenterIndexInListBox, true);
                }
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            var checkedItems = checkedListBoxAestheticCenters.CheckedItems;
            Person.AestheticCenters = checkedItems.OfType<AestheticCenter>().ToList();
            Close();
        }
    }
}
