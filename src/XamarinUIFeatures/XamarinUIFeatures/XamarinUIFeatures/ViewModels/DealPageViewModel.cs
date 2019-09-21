using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using XamarinUIFeatures.Models;

namespace XamarinUIFeatures.ViewModels
{
    public class DealPageViewModel : ViewModelBase
    {
        public ObservableCollection<Deal> Deals { get; }
        public DealPageViewModel()
        {
            Deals = new ObservableCollection<Deal>
            {
                new Deal
                {
                    Title = "Cancún",
                    Details = "Vuelo + hotel + sistema todo incluido",
                    DollarPrice = 559,
                    PenPrice = 1845,
                    Discount = 25,
                    ImageUrl = "https://laverdadnoticias.com/__export/1553211737476/sites/laverdad/img/2019/03/21/playa_cancun_1_tcm49-190704_1.jpg_1790661086.jpg"
                },
                new Deal
                {
                    Title = "Orlando",
                    Details = "Vuelo + hotel",
                    DollarPrice = 609,
                    PenPrice = 2010,
                    Discount = 10,
                    ImageUrl = "https://vacations-deals.com/wp-content/uploads/2017/07/paquete-vacacional-orlando-y-miami-7.jpg"
                },
                new Deal
                {
                    Title = "Cartagena",
                    Details = "Vuelo + hotel + desayunos",
                    DollarPrice = 309,
                    PenPrice = 1020,
                    Discount = 50,
                    ImageUrl = "https://www.absolutviajes.com/wp-content/uploads/2015/12/playa-caribe.jpg"
                },
                new Deal
                {
                    Title = "Punta Cana",
                    Details = "Vuelo + hotel + sistema todo incluido",
                    DollarPrice = 715,
                    PenPrice = 2360,
                    Discount = 30,
                    ImageUrl = "https://www.cataloniahotels.com/es/blog/wp-content/uploads/2015/01/hoteles-en-punta-cana-playa-bavaro.jpg"
                }
            };
        }
    }
}
