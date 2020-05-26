using CoronaApp.Services.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoronaApp.Services
{
    public class LocationRepository : ILocationRepository
    {
        public ICollection<Location> Get(LocationSearch locationSearch)
        {
            
                var listOfSpecificCity = new List<Location>();
                foreach (var item in AddToDB.patients)
                {
                    foreach (var item2 in item.Path)
                    {
                        if (item2.City == locationSearch.City)
                        {
                            listOfSpecificCity.Add(item2);
                        }
                    }
                }
                return listOfSpecificCity;

        }
    }
}
