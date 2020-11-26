using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FlashFlyers.Models;
using System.Collections.Generic;

namespace FlashFlyers.ViewModels
{
    public class SearchResultsViewModel
    {
        public int PageNumber { get; set; } //Current page.
        public string Search { get; set; } //Searched string.
        public int Pages { get; set; } //Pages of events found from search.
        public IEnumerable<EventModel> Events { get; set; } //Section of found events from search.
    }
}
