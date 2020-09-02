using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;

namespace july10opa
{
    class Event
    {
        private static int eventId=0;
        private string eventName;
        private string speaker;
        private DateTime date;
        private TimeSpan time;

        public int EventId { get => eventId; set => eventId = value; }
        public string EventName { get => eventName; set => eventName = value; }
        public string Speaker { get => speaker; set => speaker = value; }
        public DateTime Date { get => date; set => date = value; }
        public TimeSpan Time { get => time; set => time = value; }

        public Event(string eventname, string speaker, DateTime date, TimeSpan time)
        {

            this.EventId += 1;
            this.EventName = eventname;
            this.Speaker = speaker;
            this.Date = date;
            this.Time = time;

        }
    }
    class EventManager
    {
        public List<Event> events = new List<Event>();
        public int AddEvent(string eventname, string speaker, DateTime date, TimeSpan time)
        {
            var event1 = new Event(eventname, speaker, date, time);
            events.Add(event1);
            return event1.EventId;
        }
        public Event UpdateEvent(int eventid, string speaker, DateTime date, TimeSpan time)
        {
            for(var i=0;i<events.Count;i++)
            {
                if(events[i].EventId==eventid)
                {
                    events[i].Speaker = speaker;
                    events[i].Date = date;
                    events[i].Time = time;
                    return events[i];
                }
            }
            return events[0];
           
        }
        public Event ViewEvent(string eventname)
        {
            for (var i = 0; i < events.Count; i++)
            {
                if (events[i].EventName == eventname)
                {
                    return events[i];
                }
            }
            return events[0];

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            EventManager manager = new EventManager();

            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string eventName = Console.ReadLine();
                string speaker = Console.ReadLine();
                DateTime date = Convert.ToDateTime(Console.ReadLine());
                TimeSpan time = TimeSpan.Parse(Console.ReadLine());
                manager.AddEvent(eventName, speaker, date, time);
            }

            int choice = Convert.ToInt32(Console.ReadLine());
            if(choice==1)
            {
                string eventName = Console.ReadLine();
                string speaker = Console.ReadLine();
                DateTime date = Convert.ToDateTime(Console.ReadLine());
                TimeSpan time = TimeSpan.Parse(Console.ReadLine());
                foreach(var h in manager.events)
                {
                    if(h.EventName==eventName)
                    {
                        Console.WriteLine("Event already exist, cannot add again");
                        return;
                    }
                }
                if (date < DateTime.Now)
                {
                    Console.WriteLine("Date invalid!");
                    return;
                }
                manager.AddEvent(eventName, speaker, date, time);
                Console.WriteLine("The event "+ eventName + " has been added with event id "+ manager.events[(manager.events.Count)-1].EventId);

            }
            else if(choice==2)
            {
                int eventid = Convert.ToInt32(Console.ReadLine());
                string speaker = Console.ReadLine();
                DateTime date = Convert.ToDateTime(Console.ReadLine());
                TimeSpan time = TimeSpan.Parse(Console.ReadLine());
                var count = 0;
                foreach (var h in manager.events)
                {
                    if (h.EventId == eventid)
                    {
                        var eventname = "";
                        manager.UpdateEvent(eventid, speaker, date, time);
                        foreach(var f in manager.events)
                        {
                            if(f.EventId==eventid)
                            {
                                eventname = f.EventName;
                            }
                        }
                        Console.WriteLine("The event {0} has been updated with talks from {1} on {2} at {3}",eventname,speaker,date.ToShortDateString(), time);
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Event does not exist, cannot modify");
                        return;
                    }
                }

                if (date < DateTime.Now)
                {
                    Console.WriteLine("Date invalid!");
                    return;
                }
            }
            else
            {
                string eventName = Console.ReadLine();
                foreach (var h in manager.events)
                {
                    if (h.EventName == eventName)
                    {
                        Console.WriteLine("{0}, {1}:{2} on {3} at {4}",h.EventId,h.EventName,h.Speaker,h.Date.ToShortDateString(),h.Time);
                        return;
                    }
                }

            }

            // Enter code for handling the 3 operations
            #region solution1



            #endregion
        }
    }
}
