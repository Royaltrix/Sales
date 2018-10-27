namespace Sales.Infraestructure
{
    using Sales.ViewModels;
    using System;
    public class InstanceLocator
    {
        public MainViewModel Main { get; set; }
        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
    }
}
