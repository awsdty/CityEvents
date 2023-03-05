using CityEvents.Models;
using DynamicData;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reactive.Linq;
using System.Text;

namespace CityEvents.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private CityEvent cItem;
        private CityEvent[] sourceArray;
        private SourceList<CityEvent> sourceList;
        private readonly ReadOnlyObservableCollection<CityEvent> customItems1;
        private readonly ReadOnlyObservableCollection<CityEvent> customItems2;
        private readonly ReadOnlyObservableCollection<CityEvent> customItems3;
        private readonly ReadOnlyObservableCollection<CityEvent> customItems4;
        private readonly ReadOnlyObservableCollection<CityEvent> customItems5;
        private readonly ReadOnlyObservableCollection<CityEvent> customItems6;
        private readonly ReadOnlyObservableCollection<CityEvent> customItems7;
        private readonly ReadOnlyObservableCollection<CityEvent> customItems8;
        private readonly ReadOnlyObservableCollection<CityEvent> customItems9;

        public MainWindowViewModel()
        {
            sourceList = new SourceList<CityEvent>();
            sourceArray = Serializer<CityEvent[]>.Load("../../../Assets/data.xml");
            sourceList = new SourceList<CityEvent>();
            System.Diagnostics.Debug.WriteLine(sourceArray[0].Header,"\n");

            foreach (CityEvent cityEvent in sourceArray)
            {
                sourceList.Add(cityEvent);
            }

            sourceList.Connect().AutoRefresh(x => x.Category).Filter(x => x.Category == 1).ObserveOn(RxApp.MainThreadScheduler).Bind(out customItems1).Subscribe();
            sourceList.Connect().AutoRefresh(x => x.Category).Filter(x => x.Category == 2).ObserveOn(RxApp.MainThreadScheduler).Bind(out customItems2).Subscribe();
            sourceList.Connect().AutoRefresh(x => x.Category).Filter(x => x.Category == 3).ObserveOn(RxApp.MainThreadScheduler).Bind(out customItems3).Subscribe();
            sourceList.Connect().AutoRefresh(x => x.Category).Filter(x => x.Category == 4).ObserveOn(RxApp.MainThreadScheduler).Bind(out customItems4).Subscribe();
            sourceList.Connect().AutoRefresh(x => x.Category).Filter(x => x.Category == 5).ObserveOn(RxApp.MainThreadScheduler).Bind(out customItems5).Subscribe();
            sourceList.Connect().AutoRefresh(x => x.Category).Filter(x => x.Category == 6).ObserveOn(RxApp.MainThreadScheduler).Bind(out customItems6).Subscribe();
            sourceList.Connect().AutoRefresh(x => x.Category).Filter(x => x.Category == 7).ObserveOn(RxApp.MainThreadScheduler).Bind(out customItems7).Subscribe();
            sourceList.Connect().AutoRefresh(x => x.Category).Filter(x => x.Category == 8).ObserveOn(RxApp.MainThreadScheduler).Bind(out customItems8).Subscribe();
            sourceList.Connect().AutoRefresh(x => x.Category).Filter(x => x.Category == 9).ObserveOn(RxApp.MainThreadScheduler).Bind(out customItems9).Subscribe();
        }

        public CityEvent CItem
        {
            get => cItem;
            set => cItem = value;
        }
        public SourceList<CityEvent> SourceList
        {
            get => sourceList;
            set => this.RaiseAndSetIfChanged(ref sourceList, value);
        }

        public ReadOnlyObservableCollection<CityEvent> CustomItems1 => customItems1;
        public ReadOnlyObservableCollection<CityEvent> CustomItems2 => customItems2;
        public ReadOnlyObservableCollection<CityEvent> CustomItems3 => customItems3;
        public ReadOnlyObservableCollection<CityEvent> CustomItems4 => customItems4;
        public ReadOnlyObservableCollection<CityEvent> CustomItems5 => customItems5;
        public ReadOnlyObservableCollection<CityEvent> CustomItems6 => customItems6;
        public ReadOnlyObservableCollection<CityEvent> CustomItems7 => customItems7;
        public ReadOnlyObservableCollection<CityEvent> CustomItems8 => customItems8;
        public ReadOnlyObservableCollection<CityEvent> CustomItems9 => customItems9;
    }
}
