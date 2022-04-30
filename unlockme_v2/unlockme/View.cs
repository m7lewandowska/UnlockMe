using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;

namespace unlockme
{
    public partial class View : Form, IView
    {

        public View()
        {
            InitializeComponent();
            unlocker1.CheckPattern += Unlocker1_CheckPattern;
            unlocker4x41.CheckPattern4x4 += Unlocker1_CheckPattern;
            mainPanel1.DisplayPanel += MainPanel1_DisplayPanel;
            settings1.ChangePassword += Settings1_ChangePassword;
            sizeChooser1.ChangePasswordChooseSize += SizeChooser1_ChangePasswordChooseSize;
            settings1.TestPassword += Settings1_TestPassword;
            settings1.About += Settings1_About;
        }


        #region Events

        public event Action<List<Field>> ComparePatterns;
        public event Action<List<Field>, List<Field>> ChangePasswordCompare;
        public event Action<List<Field>, string> ChangePassword;
        public event Action CheckFieldSize;
        public event Action<List<Field>> TestPassword;
        

        #endregion




        #region Fields

        private Field[] changePasswordList;

        #endregion



        #region Properties

        /* Objaśnienia w IView */
        public bool Correct { get; set; }
        public string PatternSize { get; set; } = "3x3";
        public bool PasswordChangeCorrect { get; set; } = false;

        #endregion




        #region Methods


        private void View_Load(object sender, EventArgs e)
        {
            /* Sprawdza jaki wzór należy wyświetlić przy starcie programu */

            CheckFieldSize();
            DisplayPanel("unlocker");

        }

        private void Settings1_About()
        {
            DisplayPanel("about");
            mainPanel1.State = "about";
            //Text = "O projekcie";

        }


        private void SizeChooser1_ChangePasswordChooseSize(SizeChooser obj)
        {

            /* Wybór wielkości pola */

            switch (mainPanel1.State)
            {
                case "choose-size":

                    mainPanel1.State = "change-password-2";
                    PatternSize = obj.FieldSize;
                    DisplayPanel("unlocker");

                    break;

                case "test":

                    PatternSize = obj.FieldSize;
                    DisplayPanel("unlocker");

                    break;
            }
        }
            

        private void Settings1_ChangePassword()
        {

            /* Uruchamia kreator zmiany hasła */


            mainPanel1.State = "change-password-1";
            DisplayPanel("unlocker");
            mainPanel1.IconDisplay = "none";
        }


        private void Settings1_TestPassword()
        {
            mainPanel1.State = "test";
            DisplayPanel("choose-size");
        }


        private void MainPanel1_DisplayPanel()
        {

            /* Uruchomienie ustawień lub głównego ekranu */

            if (mainPanel1.State == "main")
            {
                mainPanel1.State = "back";
                DisplayPanel("settings");
                mainPanel1.IconDisplay = "back";
            }
            else if (mainPanel1.State == "test")
            {
                mainPanel1.State = "main";
                CheckFieldSize();
                DisplayPanel("unlocker");
                mainPanel1.IconDisplay = "settings";
            }
            else if(mainPanel1.State == "back")
            {
                mainPanel1.State = "main";
                CheckFieldSize();
                DisplayPanel("unlocker");
                mainPanel1.IconDisplay = "settings";
            }
        }


        private void Unlocker1_CheckPattern(IUnlocker obj)
        {

            /* Wyświetlanie wszystkich komunikatów i kreatora ustawiania
             * nowego hasła. Wyświetlenie panelu wyboru wielkości planszy
             * realizuje metoda SizeChooser1_ChangePasswordChooseSize().
             * Tutaj są podpięte wszystkie przyciski "Sprawdź". Proszę
             * zauważyć, że metoda przyjmuje interfejs a nie obiekty.
             * Wynika to z tego, że dzięki temu możemy operować na 
             * obiektach różnego typu - Unlocker i Unlocker4x4. Dopięcie
             * interfejsu pozwala na przyjęcie dowolnego obiektu, który
             * zawiera rzeczy zadelklarowane w interfejsie. Ale sie Michaś
             * rozpisał */

            switch (mainPanel1.State)
            {

                /* Pierwszy etap zmiany hasła - stare hasło */

                case "change-password-1":

                    /* Objaśnienie w IView */

                    ComparePatterns(obj.FieldList);

                    if (Correct == true)
                    {
                        mainPanel1.State = "choose-size";
                        DisplayPanel("choose-size");
                    }
                    else
                    {
                        MessageBox.Show("Złe hasło");
                        mainPanel1.State = "back";
                        DisplayPanel("settings");
                    }

                    break;

                /* Trzeci etap zmiany hasła - nowe hasło. */

                case "change-password-2":

                    if (obj.FieldList.Count == 0)
                    {
                        MessageBox.Show("Wzór nie może być pusty!");
                        obj.NewTry();
                    }
                    else
                    {
                        changePasswordList = obj.FieldList.ToArray();
                        mainPanel1.State = "change-password-3";
                        obj.NewTry();
                    }

                    break;

                /* Potwierdź hasło */

                case "change-password-3":     

                    if (obj.FieldList.Count == 0)
                    {
                        MessageBox.Show("Wzór nie może być pusty!");
                        obj.NewTry();
                    }
                    else
                    {

                        ChangePasswordCompare(changePasswordList.ToList(), obj.FieldList);

                        if (PasswordChangeCorrect == true) 
                        {
                            MessageBox.Show("Zmieniono hasło.");
                            mainPanel1.State = "back";
                            DisplayPanel("settings");
                            ChangePassword(obj.FieldList, PatternSize);
                        }
                        else
                        {
                            MessageBox.Show("Podane wzory nie pasują. Spróbuj ponownie.");
                            obj.NewTry();
                        }

                    }

                    break;

                /* Główny ekran */

                case "main":

                    ComparePatterns(obj.FieldList);


                    if (Correct == true)
                    {
                        obj.CorrectPassword();
                        MessageBox.Show("Kod poprawny");
                        obj.NewTry();
                    }
                    else
                    {
                        obj.InCorrectPassword();
                        MessageBox.Show("Kod niepoprawny");
                        obj.NewTry();
                        
                    }

                    break;


                case "test":
                    {
                        TestPassword(obj.FieldList);
                        obj.NewTry();
                        break;
                    }
            }


            /* Czyszczenie listy przechowującej podany wzór 
             * oraz listy klikniętych przycisków
             * przed ich kolejnym użyciem */

            obj.FieldList.Clear();
            obj.ClickedPanels.Clear();
        }


        private void DisplayPanel(string panel)
        {

            /* W zależności od wyboru funkcja sprawdza
             * co ma wyświetlić. Po wybraniu "unlocker"
             * sprawdza dodatkowo jaki panel wyświetlić,
             * 3x3 lub 4x4. */

            unlocker1.Visible = false;
            unlocker4x41.Visible = false;
            settings1.Visible = false;
            sizeChooser1.Visible = false;
            about1.Visible = false;

            switch (panel)
            {

                case "unlocker":

                    if (PatternSize == "3x3")
                        unlocker1.Visible = true;
                    else
                        unlocker4x41.Visible = true;

                    break;

                case "settings":

                    settings1.Visible = true;

                    break;

                case "choose-size":

                    sizeChooser1.Visible = true;

                    break;

                case "about":
                    about1.Visible = true;
                    break;
            }
        }


        #endregion

    }
}
