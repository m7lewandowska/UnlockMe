using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unlockme
{
    interface IView
    {

        /* W modelu sprawdzamy, czy podany przez nas wzór
        * pokrywa się z wzorem zapisanym do pliku dzięki
        * serializacji obiektu. Zwraca true lub false */

        event Action<List<Field>> ComparePatterns;

        /* Sprawdza, czy nowe wprowadzone hasło i jego
         * powtórzenie są takie same */

        event Action<List<Field>,List<Field>> ChangePasswordCompare;

        /* Zmiana hasła */

        event Action<List<Field>, string> ChangePassword;

        /* Sprawdzenie w serializowanym obiekcie wielkości
         * pola, które mamy wyświetlić */

        event Action CheckFieldSize;

        /* Odpowiada za wyświetlenie komunikatu o tym, czy
         * udało nam się dokonać odblokowania */


        event Action<List<Field>> TestPassword;

        bool Correct { get; set; }

        /* Przechowuje rozmiar planszy do odblokowania */

        string PatternSize { get; set; }

        /* Tutaj zapisujemy, czy hasła się zgadzają */

        bool PasswordChangeCorrect { get; set; }
    }
}
