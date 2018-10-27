namespace Sales.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using Views;
    using System.Windows.Input;
    using Xamarin.Forms;

    public class MainViewModel
    {
        public AddProductsViewModel AddProducts { get; set; }
        public ProductsViewModel Products { get; set; }
        public MainViewModel()
        {
            this.Products = new ProductsViewModel();
        }

        public ICommand AddProductCommand => new RelayCommand(GoToAddProduct);
        public async void GoToAddProduct()
        {
            this.AddProducts = new AddProductsViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new AddProductPage());
        }
    }
}
