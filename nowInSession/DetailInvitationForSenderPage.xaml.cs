using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Xamarin.Forms;

namespace nowInSession
{
    public partial class DetailInvitationForSenderPage : ContentPage
    {
        public ObservableCollection<User> invitedUserList = new ObservableCollection<User>();
        public DetailInvitationForSenderPage()
        {
            InitializeComponent();
        }
        public DetailInvitationForSenderPage(Invitation invitation)
        {
            InitializeComponent();
            labelDisplayName.Text = invitation.displayName;
            labelRestaurantName.Text = invitation.restaurantName;
            labelRestaurantURL.Text = invitation.restaurantURL;

            invitedPersonListView.ItemsSource = invitedUserList;
            showInvitedUserList();
        }
        public void showInvitedUserList()
        {
            invitedUserList.Clear();
            invitedUserList.Add(new User
            {
                userId = 5,
                userName = "user5",
                displayName = "ユーザー5"
            });
            invitedUserList.Add(new User
            {
                userId = 6,
                userName = "user6",
                displayName = "ユーザー6"
            });
            invitedUserList.Add(new User
            {
                userId = 7,
                userName = "user7",
                displayName = "ユーザー7"
            });
        }
    }
}
