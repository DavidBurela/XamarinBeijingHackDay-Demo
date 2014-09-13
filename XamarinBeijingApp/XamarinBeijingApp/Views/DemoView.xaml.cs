using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinBeijingApp.Views
{
    public partial class DemoView
    {
        public DemoView()
        {
            InitializeComponent();
        }

        public int Count { get; set; }
        void OnCountButtonClicked(object sender, EventArgs e)
        {
            Count++;
            ((Label) HelloLabel).Text = "You have clicked " + Count + " times.";
        }

        void OnNameButtonClicked(object sender, EventArgs e)
        {
            var name = NameEntry.Text;
            NameLabel.Text = "Hello " + name;
            NameLabel2.Text = "Hello " + name;
        }
    }
}
