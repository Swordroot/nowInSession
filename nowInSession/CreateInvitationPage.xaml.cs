using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace nowInSession
{
    public partial class createInvitationPage : ContentPage
    {
        public createInvitationPage()
        {
            InitializeComponent();
        }
        void Click_SendButton(object sender,EventArgs e)
        {
            Navigation.PopAsync(true);
        }
    }
}
