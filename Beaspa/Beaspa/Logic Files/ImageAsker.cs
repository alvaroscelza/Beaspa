using System;
using System.Drawing;
using System.Windows.Forms;

namespace Beaspa.Logic_Files
{
    public class ImageAsker
    {
        internal void changeDataGridViewCurrentCellImageByAskingUser(DataGridView dataGridView, string askerTitle, int widht, int height)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = askerTitle;
                dlg.Filter = "Imágenes (*.bmp, *.jpg, *.png, *.jpeg)|*.bmp;*.jpg;*.png;*.jpeg";
                if (dlg.ShowDialog() == DialogResult.OK)
                    changeDataGridViewCurrentCellImage(dlg, dataGridView, widht, height);
            }
        }

        private void changeDataGridViewCurrentCellImage(OpenFileDialog dlg, DataGridView dataGridView, int widht, int height)
        {
            Bitmap selectedImage = new Bitmap(dlg.FileName);
            DataGridViewImageCell currentCell = (DataGridViewImageCell)dataGridView.CurrentCell;
            currentCell.ImageLayout = DataGridViewImageCellLayout.Stretch;
            currentCell.Value = new Bitmap(selectedImage, new Size(widht, height));
        }
    }
}
