using System;
using System.Collections.ObjectModel;
using SampleApp.Contracts.ViewModels;
using SampleApp.Core.Contracts.Services;
using SampleApp.Core.Models;
using SampleApp.Helpers;

namespace SampleApp.ViewModels
{
    public class DataGridViewModel : Observable, INavigationAware
    {
        private readonly ISampleDataService _sampleDataService;

        public ObservableCollection<SampleOrder> Source { get; } = new ObservableCollection<SampleOrder>();

        public DataGridViewModel(ISampleDataService sampleDataService)
        {
            _sampleDataService = sampleDataService;
        }

        public async void OnNavigatedTo(object parameter)
        {
            Source.Clear();

            // TODO WTS: Replace this with your actual data
            var data = await _sampleDataService.GetGridDataAsync();

            foreach (var item in data)
            {
                Source.Add(item);
            }
        }

        public void OnNavigatedFrom()
        {
        }
    }
}
