using HomeProject.Models;
using System.Collections;
using System.Collections.Generic;

namespace HomeProject.Services
{
    public interface IHomeControllerProductService
    {
        IList<EventModel> GetAllEvents();
    }
}