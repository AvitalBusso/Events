using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class Program
    {
        static List<Event> events = new List<Event>();
        static void AddEvent(Event ev)
        {
            try
            {
                events.Add(ev);
            } catch (Exception e)
            {
                Console.WriteLine("ERROE!! \n"+e.Message);
            }
            
        }

        static void allEvents()
        {
            foreach (var ev in events)
            {
                Console.WriteLine($"Title: {ev.Title}, Start: {ev.Start}");
            }
        }

        static void chengeTitle(int id, string newTitle)
        {
            try
            {
                var ev = events.FirstOrDefault(e => e.Id == id);
                ev.Title = newTitle;
            }
            catch (Exception e)
            {
                Console.WriteLine("the id is undefind");
            }
            
        }

        static void deliteById(int id)
        {
            try
            {
                var ev = events.FirstOrDefault(e => e.Id == id);
                events.Remove(ev);
            } catch (Exception e)
            {
                Console.WriteLine("the id is undefind");
            }
        }

        static void tryIt()
        {
            Event E1 = new Event("Birthday Party", new DateTime(2024, 5, 10));
            Event E2 = new Event("hw", new DateTime(2024, 3, 9));
            Event E3 = new Event("school", new DateTime(2024, 9, 2));
            Event E4 = new Event("friend", new DateTime(2024, 2, 8));

            AddEvent(E1);
            AddEvent(E2);
            AddEvent(E3);
            AddEvent(E4);

            Console.WriteLine("before all");
            allEvents();

            Console.WriteLine("enter the new title: ");
            chengeTitle(1, Console.ReadLine());

            Console.WriteLine("after chenge title 1");
            allEvents();
            
            deliteById(2);

            Console.WriteLine("before delite 2");
            allEvents();

            Console.ReadLine();
            
        }
        static void Main(string[] args)
        {
            tryIt();
        }
    }
        
        
    
}
