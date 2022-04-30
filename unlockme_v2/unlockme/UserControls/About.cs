using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unlockme.UserControls
{
    public partial class About : UserControl
    {
        public About()
        {
            InitializeComponent();
            about_text.Text = "Aplikacja jest testerem wzorca odblokowania." +
                "\n\nPosiada następujące funkcjonalności:" +
                "\n* symulator odblokowania urządzenia mobilnego za pomocą wzorca punktowego(3x3, 4x4)" +
                "\n* tester siły wzoru\n* zmianę w konfiguracji(3x3, 4x4)" +
                "\n* zapis do zdalnego repozytorium wyników" +
                "" +
                "\n\nW projekcie zostały zastosowane następujące technologie i narzędzia:" +
                "\n* Język programowania: C# " +
                "\n* Technologia: .NET" +
                "\n* Model: MVP" +
                "\n* Środowisko programistyczne: Visual Studio 2017" +
                "\n* Przechowywanie danych: zdalna baza danych MySQL";
            
        }

        
    }
}
