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
    public partial class SizeChooser : UserControl
    {
        public SizeChooser()
        {
            InitializeComponent();
            label1.Text = "3x3";
            label2.Text = "4x4";
        }



        #region Events

        public event Action<SizeChooser> ChangePasswordChooseSize;

        #endregion

        #region Properties

        public string FieldSize { get; set; } = "";

        #endregion


        #region Methods

        private void ChooseSize(object sender, MouseEventArgs e)
        {
            Panel p = (Panel)sender;

            if (p.Name == "panel3x3")
                FieldSize = "3x3";
            else
                FieldSize = "4x4";


            ChangePasswordChooseSize?.Invoke(this);
        }

        #endregion
    }
}
