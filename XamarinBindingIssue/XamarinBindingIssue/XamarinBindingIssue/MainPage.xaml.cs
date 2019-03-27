using System;
using Xamarin.Forms;

namespace XamarinBindingIssue
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            ((MainViewModel)BindingContext).ClearErrorForPerson();
        }
    }
}
