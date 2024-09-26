using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Start { get; set; }

        private static int nextId = 1;
        public Event(string title, DateTime start)
        {
            Id = nextId++;
            Title = title;
            Start = start;
        }
    }
}
