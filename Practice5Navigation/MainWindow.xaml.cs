using System.Windows;
using System.Windows.Controls;
using KMA.ProgrammingInCSharp2019.Lab03.Navigation.Tools.Managers;
using KMA.ProgrammingInCSharp2019.Lab03.Navigation.Tools.Navigation;
using KMA.ProgrammingInCSharp2019.Lab03.Navigation.ViewModels;

namespace KMA.ProgrammingInCSharp2019.Lab03.Navigation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window,IContentOwner
    {
        public ContentControl ContentControl {
            get { return _contentControl; }
        }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
            NavigationManager.Instance.Initialize(new InitializationNavigationModel(this));
            NavigationManager.Instance.Navigate(ViewType.SignIn);
        }
    }
}
