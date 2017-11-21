using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace rateApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SubPage : ContentPage
    {

        ObservableCollection<User> users = new ObservableCollection<User>();

        public string labelText { get; set; }

        public class User
        {
            public string DisplayName { get; set; }

            //public string FriendlyName { get; set; }
        }

        public SubPage()
        {
            InitializeComponent();
            UserListView.ItemsSource = users;

            users.Add(new User { DisplayName = "Sato Taro" });
            users.Add(new User { DisplayName = "Suzuki Ichiro" });
            users.Add(new User { DisplayName = "Takahashi Goro" });
            users.Add(new User { DisplayName = "AAAAAAAAAAAAAAA" });

            this.labelText = "Update Text";

            //users.Add(new User{FriendlyName = "aaaaaaa"});
        }

        void OnNewItem(object sender, EventArgs e)
        {
            users.Add(new User { DisplayName = "New Item" });
        }

        /*
        private void btnTest_Clicked(object sender, EventArgs e)
        {
            this.btnTest.Image = "iconmonstr-amazon-3-240.png";
        }

        private void btnTest2_Clicked(object sender, EventArgs e)
        {
            this.btnTest.Image = "iconmonstr-headphones-16-240.png";
        }
        */
    }
}