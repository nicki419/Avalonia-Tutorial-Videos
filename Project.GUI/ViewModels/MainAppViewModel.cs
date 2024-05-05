using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Project.GUI.Models;
using System.Collections.ObjectModel;

namespace Project.GUI.ViewModels
{
    public class MainAppViewModel : ViewModelBase
    {
        private CSVHelperModel csvHelperModel;
        public MainAppViewModel() {
            csvHelperModel = new CSVHelperModel("Assets/data.csv");
            ItemsData = new ObservableCollection<CSVHelperModel.Data>();
        }
        public ObservableCollection<CSVHelperModel.Data> ItemsData { get; set; }

        public void LoadData() {
            //csvHelperModel.GetData().ForEach(ItemsData.Add);
            foreach(var _ in csvHelperModel.GetData()) ItemsData.Add(_);
        }
    }
}