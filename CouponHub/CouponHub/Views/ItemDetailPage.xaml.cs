using System.ComponentModel;
using Xamarin.Forms;
using CouponHub.ViewModels;

namespace CouponHub.Views
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