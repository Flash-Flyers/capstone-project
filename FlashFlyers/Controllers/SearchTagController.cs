using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlashFlyers.Models;
using Microsoft.AspNetCore.Mvc;

namespace FlashFlyers.Controllers
{
        public class SearchTagController : Controller
        {
            private readonly StandardModel _standardDbContext;
            Dictionary<int, EventModel> events = new Dictionary<int, EventModel>();//building dictionary of events
        public SearchTagController(StandardModel standardDbContext)
            {
                _standardDbContext = standardDbContext;
                
            }
            public IActionResult SearchAction(string search)
            {
                string[] broken_string; //will have all search terms in string array
                broken_string = search.Split(' ');
                for (int i = 0; i < broken_string.Count(); i++) { //all terms
                    for (int k = 0; k < _standardDbContext.Find<SearchTagModel>(broken_string[i]).event_id.Count(); k++) {//cycles through the amount of event ids it has
                        if (!events.ContainsKey(_standardDbContext.Find<SearchTagModel>(broken_string[i]).event_id[k])) //the actual event id 
                        {
                            int value = _standardDbContext.Find<SearchTagModel>(broken_string[i]).event_id[k];
                            events.Add(value, _standardDbContext.Find<EventModel>(value)); //the event id is added as well as the model
                        }
                    }
                }
            System.Diagnostics.Debug.WriteLine("ID ==" + events.Count());
            return RedirectToAction("Index");
            }
            public IActionResult Index()
            {
                return View(events);
            }
        }
}
