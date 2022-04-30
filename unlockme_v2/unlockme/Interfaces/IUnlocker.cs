using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace unlockme
{
    interface IUnlocker
    {
        List<Field> FieldList { get; set; }
        List<Panel> ClickedPanels { get; set; }
        Graphics G { get; set; }

        void CorrectPassword();
        void InCorrectPassword();
        void NewTry();
 
    }
}
