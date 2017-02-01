using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AmmyAvaloniaSample
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            App.AttachDevTools(this);
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
