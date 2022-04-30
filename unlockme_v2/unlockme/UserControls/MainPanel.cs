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



        #region Events

        public event Action DisplayPanel;

        #endregion




        #region Fields

        private string state = "main";

        #endregion




        #region Properties

        /* Zmiana panelu w zalezności od wyświetlonej zawartości */
        public string State
        {
            set
            {
                switch (value)
                {
                    case "main":

                        settings.BackgroundImage = global::unlockme.Properties.Resources.settings;
                        leftarrow.Visible = false;

                        StateCase(false, true, "", "main");

                        break;

                    case "about":
                        StateCase(true, false, "O projekcie", "back");
                        break;

                    case "test":

                        StateCase(true, false, "Testuj hasło", "test");
                        settings.Visible = false;
                        leftarrow.Visible = true;

                        break;

                    case "back":

                        settings.Visible = false;
                        leftarrow.Visible = true;

                        StateCase(true, false, "Ustawienia", "back");

                        break;

                    case "change-password-1":

                        StateCase(true, false, "Wprowadź obecne hasło", "change-password-1");

                        break;

                    case "change-password-2":

                        StateCase(true, false, "Wprowadź nowe hasło", "change-password-2");

                        break;

                    case "change-password-3":

                        StateCase(true, false, "Potwierdź nowe hasło", "change-password-3");

                        break;

                    case "choose-size":

                        StateCase(true, false, "Wybierz rozmiar wzoru", "choose-size");

                        break;

                    default:

                        settings.BackgroundImage = global::unlockme.Properties.Resources.settings;
                        leftarrow.Visible = false;

                        StateCase(false, true, "", "main");

                        break;
                }
            }

            get
            {
                return state;
            }
        }

        public string IconDisplay
        {
            set
            {
                switch (value)
                {
                    case "settings":

                        settings.Visible = true;
                        leftarrow.Visible = false;

                        break;

                    case "back":

                        settings.Visible = false;
                        leftarrow.Visible = true;

                        break;

                    case "none":

                        settings.Visible = false;
                        leftarrow.Visible = false;

                        break;

                    default:

                        settings.Visible = true;
                        leftarrow.Visible = false;

                        break;
                }
            }
        }

        #endregion




        #region Methods

        private void settings_MouseHover(object sender, EventArgs e) => settings.BackColor = Color.FromArgb(15, 79, 140);

        private void settings_MouseLeave(object sender, EventArgs e) => settings.BackColor = Color.FromArgb(16, 85, 150);

        private void leftarrow_MouseHover(object sender, EventArgs e) => leftarrow.BackColor = Color.FromArgb(15, 79, 140);

        private void leftarrow_MouseLeave(object sender, EventArgs e) => leftarrow.BackColor = Color.FromArgb(16, 85, 150);


        private void settings_Click(object sender, EventArgs e)
        {
            DisplayPanel?.Invoke();
        }

        private void leftarrow_Click(object sender, EventArgs e)
        {
            DisplayPanel?.Invoke();
        }

        private void StateCase(bool labelVisible, bool logoVisible, string text, string state)
        {
            label.Visible = labelVisible;
            PB_logo.Visible = logoVisible;
            label.Text = text;
            this.state = state;
        }


        #endregion


    }
}
