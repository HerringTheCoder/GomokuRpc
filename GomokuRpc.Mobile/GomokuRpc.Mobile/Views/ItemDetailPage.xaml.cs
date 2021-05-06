using GomokuRpc.Mobile.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace GomokuRpc.Mobile.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}