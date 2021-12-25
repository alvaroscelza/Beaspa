using Beaspa.Logic_Files;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Beaspa.User_Controls
{
    public partial class AestheticCenters : Form
    {
        private int IMAGE_DEFAULT_WIDHT { get; } = 150;
        private int IMAGE_DEFAULT_HEIGHT { get; } = 150;

        public AestheticCenters(List<AestheticCenter> aestheticCenters)
        {
            InitializeComponent();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = aestheticCenters;
            dataGridView.DataSource = bindingSource;
        }

        //private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs cellEvent)
        //{
        //    if (cellEvent.ColumnIndex == imageDataGridViewImageColumn.Index)
        //        changeCurrentCellImage(cellEvent.RowIndex);
        //}

        //private void changeCurrentCellImage(int rowIndex)
        //{
        //    AestheticCenter center = (AestheticCenter)dataGridView.CurrentRow.DataBoundItem;
        //    if (center != null)
        //    {
        //        ImageAsker imageAsker = new ImageAsker();
        //        imageAsker.changeDataGridViewCurrentCellImageByAskingUser(dataGridView,
        //            "Foto Centro de Estética", IMAGE_DEFAULT_WIDHT, IMAGE_DEFAULT_HEIGHT);
        //    }
        //}

        private void buttonOk_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
