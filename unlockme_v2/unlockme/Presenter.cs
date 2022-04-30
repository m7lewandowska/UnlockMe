using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unlockme
{
    class Presenter
    {
        IView view;
        Model model;

        public Presenter(IView view, Model model)
        {
            this.view = view;
            this.model = model;

            view.ComparePatterns += View_ComparePatterns;
            view.ChangePasswordCompare += View_ChangePasswordCompare;
            view.ChangePassword += View_ChangePassword;
            view.CheckFieldSize += View_CheckFieldSize;
            view.TestPassword += View_TestPassword;
        }

        private void View_TestPassword(List<Field> obj)
        {
            string pt = view.PatternSize;
            char pt2 = pt[0];
            string passwordinfo = model.CheckStrength(obj, pt2 - '0');

            System.Windows.Forms.MessageBox.Show(passwordinfo);          

        }

        private void View_CheckFieldSize() => view.PatternSize = model.CheckPatternSize();

        private void View_ChangePassword(List<Field> obj, string size) => model.ChangePassword(obj, size);

        private void View_ChangePasswordCompare(List<Field> fieldList1, List<Field> fieldList2) => view.PasswordChangeCorrect = model.ChangePasswordCompare(fieldList1, fieldList2);

        private void View_ComparePatterns(List<Field> fieldList) => view.Correct = model.ComparePatterns(fieldList);
    }
}
