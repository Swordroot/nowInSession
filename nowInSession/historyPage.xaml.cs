using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Xamarin.Forms;

namespace nowInSession
{
    public partial class historyPage : ContentPage
    {
        public ObservableCollection<Invitation> invitations = new ObservableCollection<Invitation>();
        public historyPage()
        {
            InitializeComponent();

            InvitationListView.ItemsSource = invitations;
            invitations.Add(new Invitation { userId = 1, userName = "user1", displayName = "ユーザー１", restaurantName = "レストラン１", restaurantURL = "https://www.restaurant1.com" });
            invitations.Add(new Invitation { userId = 2, userName = "user2", displayName = "ユーザー２", restaurantName = "レストラン２", restaurantURL = "https://www.restaurant2.com" });
            invitations.Add(new Invitation { userId = 3, userName = "user3", displayName = "ユーザー３", restaurantName = "レストラン３", restaurantURL = "https://www.restaurant3.com" });
        }
        void Click_makeInvitation(object sender, EventArgs e)
        {
            DisplayAlert("開発中", "鋭意開発中、しばらくお待ちください", "OK");
        }
        void Click_recievedList(object sender, EventArgs e)
        {
            DisplayAlert("開発中", "鋭意開発中、しばらくお待ちください", "OK");
        }
        void Click_sentList(object sender, EventArgs e)
        {
            DisplayAlert("開発中", "鋭意開発中、しばらくお待ちください", "OK");
        }
    }
}
