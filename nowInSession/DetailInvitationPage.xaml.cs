using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace nowInSession
{
    public partial class DetailInvitationPage : ContentPage
    {
        public DetailInvitationPage()
        {
            InitializeComponent();
        }
        public DetailInvitationPage(Invitation invitation)
        {
            InitializeComponent();
            labelDisplayName.Text = invitation.displayName;
            labelRestaurantName.Text = invitation.restaurantName;
            labelRestaurantURL.Text = invitation.restaurantURL;
        }

        void Click_AcceptButton(object sender, System.EventArgs e)
        {
            Navigation.PopAsync(true);
        }

        void Click_DenyButton(object sender, System.EventArgs e)
        {
            Navigation.PopAsync(true);
        }
    }
}
