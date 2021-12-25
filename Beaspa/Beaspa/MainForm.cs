using System.Windows.Forms;

namespace Beaspa
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Main mainUserControl = new Main();
            panel.Controls.Add(mainUserControl);
        }
    }
}
