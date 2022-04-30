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
    public partial class Unlocker : UserControl
    {

        public event Action<Unlocker> CheckPattern;

        #region Properties

        /* Lista, w której przechowujemy kolejność naszych
         * kliknięć. Przechowuje obiekty z właściwościami
         * X oraz Y */
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Field> FieldList { get; set; }

        #endregion

        private List<Panel> panelList; 
     
        public Unlocker()
        {
            InitializeComponent();
            FieldList = new List<Field>();

            panelList = new List<Panel>(9);
            
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


        private void OnClick(object sender, EventArgs e)
        {

            /* Tworzymy obiekt aktualnie używanego panelu.
             * za jego pomocą dostaniemy się do wszystkich 
             * parametrów klikniętego panelu */

            Panel b = (Panel)sender;

            /* Każdy panel nazywa się field_XxY, gdzie
             * X i Y to koordynaty panelu. Poniższe zmienne
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
                Field currentField = new Field { X = x, Y = y };
                FieldList.Add(currentField);
                int currentInd = FieldList.IndexOf(currentField);
                if(currentInd>0)
                    {
                    Graphics gr = this.CreateGraphics();
                    Pen pe = new Pen(Color.LightGray, 3);
                   // gr.DrawLine(pe, b.Location.X+(b.Width/2), b.Location.Y+(b.Height/2), panelList.ElementAt(currentInd-1).Location.X, panelList.ElementAt(currentInd-1).Location.Y);
                }
                
                }
        }

        public void Draw_OnPanel(object sender, EventArgs e)
        {
       
            
            foreach(Panel panel in panelList)
            {
                Graphics g = panel.CreateGraphics();
                Pen p = new Pen(Color.LightGray);

                SolidBrush sb = new SolidBrush(Color.LightGray);
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                panel.BackColor = Color.FromArgb(29,29,29);
                g.DrawEllipse(p, panel.Width/2, panel.Height / 2, panel.Width / 8, panel.Height / 8);
                g.FillEllipse(sb, panel.Width / 2, panel.Height / 2, panel.Width / 8, panel.Height / 8);
               
                
                
            }


        }

        private void OnMouseEnterPanel(object sender, EventArgs e)
        {
            ((Panel)sender).BackColor = Color.Red;
        }

         private void OnMouseLeavePanel(object sender, EventArgs e)
        {

            ((Panel)sender).BackColor = Color.Transparent;
        }
        
        private void Check_Click(object sender, EventArgs e)
        {
            if (CheckPattern != null) 
                CheckPattern(this);
        }

        private void Unlocker_Load(object sender, EventArgs e)
        {

        }
    }
}
