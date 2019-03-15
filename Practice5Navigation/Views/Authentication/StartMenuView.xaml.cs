using System.Windows.Controls;
using KMA.ProgrammingInCSharp2019.Lab03.Navigation.Tools.Navigation;
using KMA.ProgrammingInCSharp2019.Lab03.Navigation.ViewModels.Authentication;

namespace KMA.ProgrammingInCSharp2019.Lab03.Navigation.Views.Authentication
{
    public partial class SignInView : UserControl,INavigatable
    {
        internal SignInView()
        {
            InitializeComponent();
            DataContext = new StartMenuModel();
        }
    }
}
