using KMA.ProgrammingInCSharp2019.Lab03.Navigation.Tools.Managers;

namespace KMA.ProgrammingInCSharp2019.Lab03.Navigation.ViewModels.Authentication
{
    internal class OutputMenuModel
    {
        #region Properties
        public string LName
        {
            get { return StationManager.CurrentPerson.LName; }

        }
        public string FName
        {
            get { return StationManager.CurrentPerson.FName; }

        }
        public string EMAIL
        {
            get { return StationManager.CurrentPerson.EMAIL; }
        }

        public string DATE
        {
            get { return StationManager.CurrentPerson.DATE.ToShortDateString(); }
        }

        public string IsAdult
        {
            get
            {
                if (StationManager.CurrentPerson.IsAdult) return "Yes";
                return "No";
            }
        }
        public string SunSign
        {
            get { return StationManager.CurrentPerson.SunSign; }
        }
        public string ChineseSign
        {
            get { return StationManager.CurrentPerson.ChineseSign; }
        }
        public string IsBirthday
        {
            get
            {
                if (StationManager.CurrentPerson.IsBirthdayGet) return "Yes";
                return "No";
            }
        }

        #endregion
    }
}