using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using XamarinBeijingApp.Views;

namespace XamarinBeijingApp
{
    public class App
    {
        public static Page GetMainPage()
        {
            return new HomeView();
        }
    }
}
