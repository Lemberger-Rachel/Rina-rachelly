
using System;
using System.Collections.Generic;
using System.Text;
using CoronaApp.Dal;
using Microsoft.EntityFrameworkCore;

namespace CoronaApp.Services
{
    public class LocationRepository : ILocationRepository
    {
        private readonly string con;
        public LocationRepository(string _con)
        {
            _con = con;
        }
        public LocationRepository()
        {

        }
        //public CoronaContext MyProperty { get; set; }
        public ICollection<Location> Get(LocationSearch locationSearch)
        {
                var listOfSpecificCity = new List<Location>();
                CoronaContext context = new CoronaContext();
                foreach (var item in context.Patient.Include(x => x.Path))
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

        ICollection<Location> ILocationRepository.GetAllList()
        {
            var listPatient = new List<Location>();
            CoronaContext context = new CoronaContext();

            foreach (var item in context.Patient.Include(x => x.Path))
            {
                foreach (var item2 in item.Path)
                {
                    listPatient.Add(item2);
                }
            }
            return listPatient;
        }

        //public ICollection<Location>GetAllList()
        //{
        //    var listPatient = new List<Location>();
        //    CoronaContext context = new CoronaContext();

        //    foreach (var item in context.Patient.Include(x => x.Path))
        //    {
        //        foreach (var item2 in item.Path)
        //        {
        //            listPatient.Add(item2);
        //        }
        //    }
        //    return listPatient;
        //}
    }
}
