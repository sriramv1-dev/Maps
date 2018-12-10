using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using Xamarin.Forms.Maps;

namespace Maps.ViewModels
{
    public class MapsPageViewModel: ViewModelBase
    {
        public MapsPageViewModel()
        {
            MapPins = new List<Pin>();
            MapPositions = new List<Position>();
            GetMapData();
        }
        public void GetMapData()
        {
            Position position = new Position(latitude: 27.981484, longitude: -82.488968);
            MapPositions.Add(position);
            MapPins.Add(new Pin
            {
                Type = PinType.Place,
                Position = position,
                Label = "Habana Mill",
                Address = "Tampa, FL"
            });

            position = new Position(latitude: 27.9419666, longitude: -82.4125937);
            MapPositions.Add(position);
            MapPins.Add(new Pin
            {
                Type = PinType.Place,
                Position = position,
                Label = "Palm River",
                Address = "Tampa, FL"
            });

            position = new Position(latitude: 27.9650212, longitude: -82.4350941);
            MapPositions.Add(position);
            MapPins.Add(new Pin
            {
                Type = PinType.Place,
                Position = position,
                Label = "Ybor City",
                Address = "Tampa, FL"
            });

            position = new Position(latitude: 27.9453715, longitude: -82.4659336);
            MapPositions.Add(position);
            MapPins.Add(new Pin
            {
                Type = PinType.Place,
                Position = position,
                Label = "University of Tampa",
                Address = "Tampa, FL"
            });
        }
        private List<Pin> mapPins;
        public List<Pin> MapPins
        {
            get { return mapPins; }
            set
            {
                mapPins = value; RaisePropertyChanged("MapPins");
            }
        }

        private List<Position> mapPositions;
        public List<Position> MapPositions
        {
            get { return mapPositions; }
            set
            {
                mapPositions = value; RaisePropertyChanged("MapPositions");
            }
        }

    }

}
