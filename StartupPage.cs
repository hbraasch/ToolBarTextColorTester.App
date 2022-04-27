using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBarTextColorTester
{
    internal class StartupPage: ContentPage
    {
        public StartupPage()
        {
            ToolbarItems.Add(new ToolbarItem("Tap me", "", async () => {
                await Application.Current.MainPage.DisplayAlert("Alert", "Tapped","Cancel");
            }, ToolbarItemOrder.Primary));

            Title = "StartupPage";
            Content = new Label { Text = "StartupPage" };
        }
    }
}
