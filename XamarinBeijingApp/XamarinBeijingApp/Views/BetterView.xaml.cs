using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinBeijingApp.ViewModels;

namespace XamarinBeijingApp.Views
{
    public partial class BetterView
    {
        public BetterView()
        {
            InitializeComponent();

            this.BindingContext = new BetterViewModel();
        }
    }
}
