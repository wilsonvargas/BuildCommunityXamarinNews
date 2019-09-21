using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using XamarinUIFeatures.Models;

namespace XamarinUIFeatures.ViewModels
{
    public class TripPageViewModel : ViewModelBase
    {
        public ObservableCollection<Trip> NationalTrips { get; }
        public ObservableCollection<Trip> InternationalTrips { get; set; }

        public TripPageViewModel()
        {
            NationalTrips = new ObservableCollection<Trip>
            {
                new Trip
                {
                    From = "Trujillo",
                    To = "Lima",
                    Date = new DateTime(2019, 03, 23),
                    Departure = new TimeSpan(08, 30,0),
                    Arrival = new TimeSpan(09, 20, 0),
                    ImageUrl = "https://www.perubus.com.pe/wp-content/uploads/2016/01/Banner_Lima.jpg"
                },
                new Trip
                {
                    From = "Lima",
                    To = "Trujillo",
                    Date = new DateTime(2019, 03, 30),
                    Departure = new TimeSpan(19, 0,0),
                    Arrival = new TimeSpan(19, 45, 0),
                    ImageUrl = "https://i2.wp.com/losviajesdemary.com/wp-content/uploads/2015/02/portada-trujillo.jpg"
                },
                
                new Trip
                {
                    From = "Trujillo",
                    To = "Lima",
                    Date = new DateTime(2019, 02, 12),
                    Departure = new TimeSpan(15, 0, 0),
                    Arrival = new TimeSpan(15, 50, 0),
                    ImageUrl = "https://www.perubus.com.pe/wp-content/uploads/2016/01/Banner_Lima.jpg"
                },
                new Trip
                {
                    From = "Lima",
                    To = "Tarapoto",
                    Date = new DateTime(2019, 02, 14),
                    Departure = new TimeSpan(20, 30,0),
                    Arrival = new TimeSpan(22, 00, 0),
                    ImageUrl = "https://www.mituwasiecohospedaje.com/wp-content/uploads/2018/04/TarapotoSemanaSanta.jpg"
                },
                new Trip
                {
                    From = "Tarapoto",
                    To = "Lima",
                    Date = new DateTime(2019, 02, 17),
                    Departure = new TimeSpan(18, 0, 0),
                    Arrival = new TimeSpan(20, 0, 0),
                    ImageUrl = "https://www.perubus.com.pe/wp-content/uploads/2016/01/Banner_Lima.jpg"
                },
                new Trip
                {
                    From = "Lima",
                    To = "Trujillo",
                    Date = new DateTime(2019, 02, 21),
                    Departure = new TimeSpan(09, 0, 0),
                    Arrival = new TimeSpan(09, 50, 0),
                    ImageUrl = "https://i2.wp.com/losviajesdemary.com/wp-content/uploads/2015/02/portada-trujillo.jpg"
                }
            };
            InternationalTrips = new ObservableCollection<Trip>
            {
                new Trip
                {
                    From = "Lima",
                    To = "Bogota",
                    Date = new DateTime(2019, 06, 12),
                    Departure = new TimeSpan(7, 0, 0),
                    Arrival = new TimeSpan(9, 0 , 0),
                    ImageUrl = "https://ciudadesiberoamericanas.org/wp-content/uploads/2016/01/Bogota.jpg"
                },
                new Trip
                {
                    From = "Bogota",
                    To = "Medellin",
                    Date = new DateTime(2019, 06, 12),
                    Departure = new TimeSpan(20, 30,0),
                    Arrival = new TimeSpan(21, 0, 0),
                    ImageUrl = "https://media.nomadicmatt.com/2019/thingstodoinmedmain1.jpg"
                },
                new Trip
                {
                    From = "Lima",
                    To = "Buenos Aires",
                    Date = new DateTime(2019, 04, 12),
                    Departure = new TimeSpan(20, 0, 0),
                    Arrival = new TimeSpan(22, 30, 0),
                    ImageUrl = "https://www.inoutviajes.com/fotos/20/3446_ObeliscoyAv.9dejulio.jpg"
                },
                new Trip
                {
                    From = "Lima",
                    To = "Bogota",
                    Date = new DateTime(2019, 08, 02),
                    Departure = new TimeSpan(11, 0, 0),
                    Arrival = new TimeSpan(13, 30, 0),
                    ImageUrl = "https://ciudadesiberoamericanas.org/wp-content/uploads/2016/01/Bogota.jpg"
                },
                new Trip
                {
                    From = "Bogota",
                    To = "Los Angeles",
                    Date = new DateTime(2019, 08, 02),
                    Departure = new TimeSpan(19, 0, 0),
                    Arrival = new TimeSpan(21, 0, 0),
                    ImageUrl = "https://images2.minutemediacdn.com/image/upload/c_fill,g_auto,h_1248,w_2220/f_auto,q_auto,w_1100/v1555348563/shape/mentalfloss/la.jpg"
                }
            };
        }

    }
}
