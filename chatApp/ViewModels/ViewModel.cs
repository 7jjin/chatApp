using chatApp.CustomControls;
using chatApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chatApp.ViewModels
{
    public class ViewModel
    {
        public ObservableCollection<StatusDataModel> statusThumbsCollection;

        public ViewModel()
        {
            // Let bind our collection to itemscontrol
            statusThumbsCollection = new ObservableCollection<StatusDataModel>()
            {
                new StatusDataModel()
                {
                    IsMeAddStatus = true,
                },
                new StatusDataModel()
                {
                    ContactName = "Mike",
                    ContactPhoto = new Uri("/assets/1.png", UriKind.RelativeOrAbsolute),
                    IsMeAddStatus = false,
                    StatusImage = new Uri("/assets/5.jpg", UriKind.RelativeOrAbsolute)
                },
                new StatusDataModel()
                {
                    ContactName = "Steve",
                    ContactPhoto = new Uri("/assets/2.jpg", UriKind.RelativeOrAbsolute),
                    IsMeAddStatus = false,
                    StatusImage = new Uri("/assets/8.jpg", UriKind.RelativeOrAbsolute)
                },
                new StatusDataModel()
                {
                    ContactName = "Will",
                    ContactPhoto = new Uri("/assets/3.png", UriKind.RelativeOrAbsolute),
                    IsMeAddStatus = false,
                    StatusImage = new Uri("/assets/5.jpg", UriKind.RelativeOrAbsolute)
                },
            };
        }
    }
}
