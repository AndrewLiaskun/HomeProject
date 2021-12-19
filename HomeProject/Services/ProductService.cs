using HomeProject.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace HomeProject.Services
{
    public class ProductService : IHomeControllerProductService
    {
        private IList<EventModel> _events;

        public ProductService()
        {
            _events = new List<EventModel>()
            {
                new EventModel(DayOfWeek.Monday,"Cardio",new TimeSpan(7,0,0),new TimeSpan(9,0,0)),
                new EventModel(DayOfWeek.Tuesday,"Power Fitness",new TimeSpan(7,0,0),new TimeSpan(9,0,0)),
                new EventModel(DayOfWeek.Friday,"Yoga Section",new TimeSpan(7,0,0),new TimeSpan(9,0,0)),
                new EventModel(DayOfWeek.Wednesday,"Boxing",new TimeSpan(8,0,0),new TimeSpan(9,0,0)),
                new EventModel(DayOfWeek.Thursday,"Areobic",new TimeSpan(8,0,0),new TimeSpan(9,0,0)),
                new EventModel(DayOfWeek.Saturday,"Cardio",new TimeSpan(8,0,0),new TimeSpan(9,0,0)),
                new EventModel(DayOfWeek.Tuesday,"Boxing",new TimeSpan(11,0,0),new TimeSpan(14,0,0)),
                new EventModel(DayOfWeek.Wednesday,"Areobic",new TimeSpan(11,30,0),new TimeSpan(15,30,0)),
                new EventModel(DayOfWeek.Friday,"Body work",new TimeSpan(11,50,0),new TimeSpan(17,20,0)),
                new EventModel(DayOfWeek.Monday,"Boxing",new TimeSpan(14,0,0),new TimeSpan(16,0,0)),
                new EventModel(DayOfWeek.Tuesday,"Power lifting",new TimeSpan(15,0,0),new TimeSpan(18,0,0)),
                new EventModel(DayOfWeek.Thursday,"Cardio",new TimeSpan(18,0,0),new TimeSpan(21,0,0)),
                new EventModel(DayOfWeek.Saturday,"Crossfit",new TimeSpan(17,0,0),new TimeSpan(19,0,0))
            };
        }

        public IList<EventModel> GetAllEvents()
        {
            return _events;
        }
    }
}