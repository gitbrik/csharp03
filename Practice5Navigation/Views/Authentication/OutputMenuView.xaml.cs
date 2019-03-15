using System.Windows.Controls;
using KMA.ProgrammingInCSharp2019.Lab03.Navigation.Tools.Navigation;
using KMA.ProgrammingInCSharp2019.Lab03.Navigation.ViewModels.Authentication;

namespace KMA.ProgrammingInCSharp2019.Lab03.Navigation.Views.Authentication
{
    public partial class SignUpView : UserControl, INavigatable
    {
        internal SignUpView()
        {
            InitializeComponent();
            DataContext = new OutputMenuModel();
        }
    }

    
}
