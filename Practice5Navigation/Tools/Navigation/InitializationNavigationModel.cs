using System;
using KMA.ProgrammingInCSharp2019.Lab03.Navigation.Views.Authentication;
using MainView = KMA.ProgrammingInCSharp2019.Lab03.Navigation.Views.MainView;
using SignUpView = KMA.ProgrammingInCSharp2019.Lab03.Navigation.Views.Authentication.SignUpView;

namespace KMA.ProgrammingInCSharp2019.Lab03.Navigation.Tools.Navigation
{
    internal class InitializationNavigationModel : BaseNavigationModel
    {
        public InitializationNavigationModel(IContentOwner contentOwner) : base(contentOwner)
        {
            
        }
   
        protected override void InitializeView(ViewType viewType)
        {
            switch (viewType)
            {
                case ViewType.SignIn:
                    ViewsDictionary.Add(viewType,new SignInView());
                    break;
                case ViewType.SignUp:
                    ViewsDictionary.Add(viewType, new Views.Authentication.SignUpView());
                    break;
                case ViewType.Main:
                    ViewsDictionary.Add(viewType, new Views.MainView());
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(viewType), viewType, null);
            }
        }
    }
}
