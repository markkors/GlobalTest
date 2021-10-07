using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace GlobalTest
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        public static Class1 MyClass;
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            MyClass = new Class1("test");

        }


    }
}
