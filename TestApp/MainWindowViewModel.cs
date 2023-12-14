using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public class TestObj
    {
        public string Name { get; set; } = "";
        public string Text { get; set; } = "";
    }
    public partial class MainWindowViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<TestObj> test;

        public MainWindowViewModel()
        {
            Test = new ObservableCollection<TestObj>();
            Populate();
        }

        [RelayCommand]
        private void Populate()
        {
            Test.Clear();
            Test.Add(new TestObj()
            {
                Name = "Test1",
                Text = "Test1",
            });
            Test.Add(new TestObj()
            {
                Name = "Test2",
                Text = "Test2",
            });
            Test.Add(new TestObj()
            {
                Name = "Test3",
                Text = "Test3",
            });
            Test.Add(new TestObj()
            {
                Name = "Test4",
                Text = "Test4",
            });
        }
    }
}
