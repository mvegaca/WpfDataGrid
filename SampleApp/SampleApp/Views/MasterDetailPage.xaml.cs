using System.Windows.Controls;

using SampleApp.ViewModels;

namespace SampleApp.Views
{
    public partial class MasterDetailPage : Page
    {
        public MasterDetailPage(MasterDetailViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
