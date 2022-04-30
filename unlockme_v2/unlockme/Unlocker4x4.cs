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
    public partial class Unlocker4x4 : UserControl
    {

        public event Action<Unlocker4x4> CheckPattern4x4;

        #region Properties

        /* Lista, w której przechowujemy kolejność naszych
         * kliknięć. Przechowuje obiekty z właściwościami
         * X oraz Y */
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Field> FieldList { get; set; }

        #endregion
        public Unlocker4x4()
        {
            InitializeComponent();
            FieldList = new List<Field>();
        }

        private void OnClick(object sender, EventArgs e)
        {

            /* Tworzymy obiekt aktualnie używanego przycisku.
             * za jego pomocą dostaniemy się do wszystkich 
             * parametrów klikniętego przycisku */

            Button b = (Button)sender;

            /* Każdy przycisk nazywa się field_XxY, gdzie
             * X i Y to koordynaty przycisku. Poniższe zmienne
             * to wycięcie X i Y i parsowanie ich na typ int */

            int x = int.Parse(b.Name.Substring(6, 1));
            int y = int.Parse(b.Name.Substring(8, 1));

            /* Sprawdzenie czy w liście nie ma już klikniętego
             * przycisku o podanych współrzędnych, bo każdego
             * przycisku możemy użyć maksymalnie raz. Foreach
             * sprawdza każdy kolejny obiekt, następnie jeśli może
             * to dopisuje kolejny przycisk do listy. Tak uzyskujemy
             * przyciski w odpowiedniej kolejności */

            bool canAddToList = true;

            if (FieldList.Count != 16)
            {
                foreach (var field in FieldList)
                {
                    if (field.X == x && field.Y == y)
                    {
                        canAddToList = false;
                        break;
                    }

                }
            }

            /* Dodanie nowego obiektu współrzędnych Field do listy */

            if (canAddToList == true)
                FieldList.Add(new Field { X = x, Y = y });
        }

        private void Check_Click(object sender, EventArgs e)
        {
            if (CheckPattern4x4 != null)
                CheckPattern4x4(this);
        }
    }
}
