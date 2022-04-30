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

        /* Odpowiada za wyświetlenie komunikatu o tym, czy
         * udało nam się dokonać odblokowania */

        bool Correct { get; set; }

        /* Przechowuje rozmiar planszy do odblokowania */

        string PatternSize { get; set; }
    }
}
