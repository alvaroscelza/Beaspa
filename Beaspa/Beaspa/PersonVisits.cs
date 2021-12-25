using Beaspa.Logic_Files;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Beaspa
{
    public partial class PersonVisits : Form
    {
        public PersonVisits(List<Visit> visits)
        {
            InitializeComponent();
            bindVisitsToDataGridView(visits);
        }

        private void bindVisitsToDataGridView(List<Visit> visits)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = visits;
            dataGridView.DataSource = bindingSource;
        }

        private void buttonOk_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
