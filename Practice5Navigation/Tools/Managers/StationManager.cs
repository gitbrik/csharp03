using System;
using System.Windows;
using KMA.ProgrammingInCSharp2019.Lab03.Navigation.Tools.Navigation;
using KMA.ProgrammingInCSharp2019.Practice5.Navigation.Models;

namespace KMA.ProgrammingInCSharp2019.Lab03.Navigation.Tools.Managers
{
    internal static class StationManager
    {

        internal static Person CurrentPerson { get; set; }

        
        internal static void CloseApp()
        {
            MessageBox.Show("ShutDown");
            Environment.Exit(1);
        }

        
    }
}
