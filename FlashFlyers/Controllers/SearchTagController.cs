using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlashFlyers.Models;
using FlashFlyers.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FlashFlyers.Controllers
{
        // this controller class handles the search functionality for the website
        public class SearchTagController : Controller
        {
            private readonly StandardModel _standardDbContext;
            public SearchTagController(StandardModel standardDbContext) {
                _standardDbContext = standardDbContext;
                
            }
            public List<EventModel> SearchAction(string search) {
                System.Diagnostics.Debug.WriteLine("ID ==" + search);
                string[] broken_string; //will have all search terms in string array
                broken_string = search.Split(' ');
                
                if (broken_string == null)
                    return new List<EventModel>();

                for (int i = 0; i < broken_string.Length; ++i)
                    broken_string[i] = broken_string[i].ToLower();

            Dictionary<int, EventModel> events = new Dictionary<int, EventModel>();//building dictionary of events
                
                for (int i = 0; i < broken_string.Count(); i++)//all terms
                    if (_standardDbContext.Find<SearchTagModel>(broken_string[i]) != null)
                        for (int k = 0; k < _standardDbContext.Find<SearchTagModel>(broken_string[i]).event_id.Count(); k++)//cycles through the amount of event ids it has
                            if (!events.ContainsKey(_standardDbContext.Find<SearchTagModel>(broken_string[i]).event_id[k])) {//the actual event id
                                int value = _standardDbContext.Find<SearchTagModel>(broken_string[i]).event_id[k];
                                events.Add(value, _standardDbContext.Find<EventModel>(value)); //the event id is added as well as the model
                            }
                return new List<EventModel>(events.Values);
            }
            public IActionResult Index(string search, int page_number) {
     
                List<EventModel> events = SearchAction(search);
                List<EventModel> page_events = new List<EventModel>();
                int page_length = 10;
                for (int i = 0; i < page_length; ++i) 
                {
                    int index = i + (page_number * page_length);
                    if (index < events.Count())
                        page_events.Add(events[index]);
                }

                System.Diagnostics.Debug.WriteLine("Page: " + page_number + " page events count : " + page_events.Count());

                int total_pages = (int)MathF.Ceiling(events.Count / 10.0f);
                return View(new SearchResultsViewModel { PageNumber = page_number, Search = search, Pages = total_pages, Events = page_events });
            }
        }
}
