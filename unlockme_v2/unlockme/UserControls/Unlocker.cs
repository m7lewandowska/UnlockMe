using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.VisualBasic;

namespace unlockme
{
    public partial class Unlocker : UserControl, IUnlocker
    {

        private List<Panel> panelList = new List<Panel>();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)] 
        public List<Panel> ClickedPanels { get; set; }

        public Unlocker()
        {
            InitializeComponent();
            FieldList = new List<Field>();
            G = CreateGraphics();

            ClickedPanels = new List<Panel>();

            panelList.Add(field_0x0);
            panelList.Add(field_0x1);
            panelList.Add(field_0x2);
            panelList.Add(field_1x0);
            panelList.Add(field_1x1);
            panelList.Add(field_1x2);
            panelList.Add(field_2x0);
            panelList.Add(field_2x1);
            panelList.Add(field_2x2);
        }




        #region Properties

        /* Lista, w której przechowujemy kolejność naszych
         * kliknięć. Przechowuje obiekty z właściwościami
         * X oraz Y */
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Field> FieldList { get; set; }
        public Graphics G { get; set; }



        #endregion




        #region Events

        public event Action<Unlocker> CheckPattern;


        #endregion




        #region Fields

        #endregion




        #region Methods

        private void OnClick(object sender, EventArgs e)
        {


            /* Tworzymy obiekt aktualnie używanego przycisku.
             * za jego pomocą dostaniemy się do wszystkich 
             * parametrów klikniętego przycisku */

            Panel b = (Panel)sender;

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

            if (FieldList.Count != 9)
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
            {
                FieldList.Add(new Field { X = x, Y = y });

                string panelName = "field_" + x + "x" + y;

                foreach (var panelTemp in panelList)
                {

                    if (panelTemp.Name == panelName)
                    {
                        ClickedPanels.Add(panelTemp);
                    }
                }


                if (FieldList.Count >= 2)
                {
                    int currentInd = FieldList.Count - 1;

                    Pen pen = new Pen(Color.FromArgb(80, Color.White), 6);
                    G.SmoothingMode = SmoothingMode.AntiAlias;
                    G.DrawLine(pen, ClickedPanels.ElementAt(currentInd - 1).Location.X + b.Width / 2, ClickedPanels.ElementAt(currentInd - 1).Location.Y + b.Height / 2,
                         b.Location.X + b.Width / 2, b.Location.Y + b.Height / 2);


                }
            }
        }

        private void Check_Click(object sender, EventArgs e) => CheckPattern?.Invoke(this);

        private void MouseOnPanel(object sender, EventArgs e) => ((Panel)sender).BackColor = Color.FromArgb(255,255,255);

        private void MouseOutPanel(object sender, EventArgs e) => ((Panel)sender).BackColor = Color.LightGray;

        public void CorrectPassword() => ClickedPanels.ForEach(delegate (Panel x) { x.BackColor = Color.Green; });

        public void InCorrectPassword() => ClickedPanels.ForEach(delegate (Panel x) { x.BackColor = Color.Red; });
     
        public void NewTry()
        {
            foreach(Panel x in ClickedPanels)
                x.BackColor = Color.LightGray;
            G.Clear(Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29))))));
        }
        
        #endregion

    }
}
