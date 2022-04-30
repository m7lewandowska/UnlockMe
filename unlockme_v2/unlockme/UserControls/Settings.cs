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
    public partial class Settings : UserControl
    {
        public Settings()
        {
            InitializeComponent();
        }

        #region Events

        public event Action ChangePassword;

        public event Action TestPassword;

        public event Action About;

        #endregion




        #region Methods

        private void logs_Click(object sender, EventArgs e) => System.Diagnostics.Process.Start("http://ervingrafika.1free.eu");

        private void changePattern_Click(object sender, EventArgs e) => ChangePassword?.Invoke();

        private void test_Click(object sender, EventArgs e) => TestPassword?.Invoke();

        private void about_Click(object sender, EventArgs e) => About?.Invoke();

        #endregion

    }
}
