using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace nowInSession
{
    public partial class FirstTabbedPage : TabbedPage
    {
        public FirstTabbedPage()
        {
            InitializeComponent();
            this.Children.Add(new NavigationPage(new HistoryPage()
            {
                Title = "Recieve"
                //Icon = "nowInSession.Images.recieve_60.png"
            }));
            this.Children.Add(new NavigationPage(new SentHistoryPage()
            {
                Title = "Sent"
                //Icon = "nowInSession.Images.sent_60.png"
            }));
        }
    }
}
