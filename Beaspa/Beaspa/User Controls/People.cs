using Beaspa.Logic_Files;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Beaspa.User_Controls
{
    public partial class People : UserControl
    {
        public PersistenceManager PersistenceManager { get; set; }

        private int IMAGE_DEFAULT_WIDHT { get; } = 100;
        private int IMAGE_DEFAULT_HEIGHT { get; } = 100;

        public People(PersistenceManager persistenceManager)
        {
            InitializeComponent();
            PersistenceManager = persistenceManager;
            bindPeopleToDataGridView();
        }

        private void bindPeopleToDataGridView()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = PersistenceManager.People;
            dataGridView.DataSource = bindingSource;
        }

        private void dataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            disableNotCheckedAllergiesDescription();
        }

        private void disableNotCheckedAllergiesDescription()
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                Person person = (Person)row.DataBoundItem;
                if (person != null && !person.Allergies)
                    disableNotCheckedAllergiesDescription(row);
            }
        }

        private void disableNotCheckedAllergiesDescription(DataGridViewRow row)
        {
            int columnIndex = AllergiesDescriptionTextBoxColumn.Index;
            var allergiesDescriptionCell = (DataGridViewTextBoxCell)row.Cells[columnIndex];
            disableCell(allergiesDescriptionCell);
        }

        private void disableCell(DataGridViewTextBoxCell cell)
        {
            cell.ReadOnly = true;
            cell.Style.BackColor = Color.LightGray;
            cell.Style.ForeColor = Color.DarkGray;
            cell.Style.SelectionBackColor = Color.LightGray;
            cell.Style.SelectionForeColor = Color.DarkGray;
        }

        private void dataGridView_CellContentClick(object sender,
            DataGridViewCellEventArgs cellEvent)
        {
            if (cellEvent.ColumnIndex == AllergiesCheckBoxColumn.Index)
                toggleAllergiesDescriptionHabilitation(cellEvent.RowIndex);
        }

        private void toggleAllergiesDescriptionHabilitation(int rowIndex)
        {
            int columnIndex = AllergiesDescriptionTextBoxColumn.Index;
            DataGridViewRow row = dataGridView.Rows[rowIndex];
            var allergiesDescriptionCell = (DataGridViewTextBoxCell)row.Cells[columnIndex];
            var currentCell = (DataGridViewCheckBoxCell)dataGridView.CurrentCell;
            if ((bool)currentCell.EditedFormattedValue)
                enableCell(allergiesDescriptionCell);
            else
                disableCell(allergiesDescriptionCell);
        }

        private void enableCell(DataGridViewTextBoxCell cell)
        {
            cell.ReadOnly = false;
            cell.Style.BackColor = Color.White;
            cell.Style.ForeColor = Color.Black;
            cell.Style.SelectionBackColor = Color.Blue;
            cell.Style.SelectionForeColor = Color.White;
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs cellEvent)
        {
            if (cellEvent.ColumnIndex == imageDataGridViewImageColumn.Index)
                changeCurrentCellImage();
            if (cellEvent.ColumnIndex == AestheticCentersButtonColumn.Index)
                showPersonAestheticCentersIfRowPersonNotNull();
            if (cellEvent.ColumnIndex == VisitsButtonColumn.Index)
                showPersonVisitsIfRowPersonNotNull();
        }

        private void changeCurrentCellImage()
        {
            Person person = (Person)dataGridView.CurrentRow.DataBoundItem;
            if (person != null)
            {
                ImageAsker imageAsker = new ImageAsker();
                imageAsker.changeDataGridViewCurrentCellImageByAskingUser(dataGridView,
                    "Foto Paciente", IMAGE_DEFAULT_WIDHT, IMAGE_DEFAULT_HEIGHT);
            }
        }

        private void showPersonAestheticCentersIfRowPersonNotNull()
        {
            Person person = (Person)dataGridView.CurrentRow.DataBoundItem;
            if (person != null)
            {
                List<AestheticCenter> centers = PersistenceManager.AestheticCenters;
                var personAestheticCenters = new PersonAestheticCenters(centers, person);
                personAestheticCenters.ShowDialog();
            }
        }

        private void showPersonVisitsIfRowPersonNotNull()
        {
            Person person = (Person)dataGridView.CurrentRow.DataBoundItem;
            if (person != null)
            {
                PersonVisits personVisits = new PersonVisits(person.Visits);
                personVisits.ShowDialog();
            }
        }

        public void showOnlyThisPeople(List<Person> peopleToShow)
        {
            bindPeopleToDataGridView();
            object currentDataSource = dataGridView.DataSource;
            var currencyManager = (CurrencyManager)BindingContext[currentDataSource];
            currencyManager.SuspendBinding();
            hideNotWantedPeople(peopleToShow);
            currencyManager.ResumeBinding();
        }

        private void hideNotWantedPeople(List<Person> peopleToShow)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                Person person = (Person)row.DataBoundItem;
                if (person != null && !peopleToShow.Contains(person))
                    row.Visible = false;
            }
        }
    }
}
