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
            public IActionResult Index(string search) {
                return View(SearchAction(search));
            }
        }
}
