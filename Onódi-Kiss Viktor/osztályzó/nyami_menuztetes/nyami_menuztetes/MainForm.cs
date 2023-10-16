using System.Windows.Forms;

namespace nyami_menuztetes
{
    public partial class MainForm : Form
    {
        //A View osztály inicializálása
        private View view = new View();

        //A Fő form konstruktőre
        public MainForm()
        {
            InitializeComponent();
            view.SetUp(this);
        }
    }
}
