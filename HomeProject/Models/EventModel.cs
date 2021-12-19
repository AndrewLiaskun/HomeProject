using System;

namespace HomeProject.Models
{
    public class EventModel
    {
        public EventModel(DayOfWeek dayOfWeek, string eventName, TimeSpan startTime, TimeSpan endTime)
        {
            DayOfWeek = dayOfWeek;
            EventName = eventName;
            StartTime = startTime;
            EndTime = endTime;
        }

        public DayOfWeek DayOfWeek { get; }
        public string EventName { get; }
        public TimeSpan StartTime { get; }
        public TimeSpan EndTime { get; }
    }
}