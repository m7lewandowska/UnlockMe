using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unlockme
{
    public partial class MainPanel : UserControl
    {
        public MainPanel()
        {
            InitializeComponent();
        }

        public event Action<MainPanel> DisplayPanel;

        private void PNL1_settings_Click(object sender, EventArgs e)
        {
            if (DisplayPanel != null)
                DisplayPanel(this);
            Console.WriteLine("XD");
        }
    }
}
