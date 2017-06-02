using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarRent.MVC.Models
{
    public class SearchVM : SearchCretiria
    {
        public string SearchGear { get; set; }
        public string SearchModel { get; set; }
        public string SearchText { get; set; }
        public SearchVM()
        {

        }
        public SearchVM(SearchCretiria cretiria)
        {
            SearchGear = cretiria.SearchGear;
            SearchModel = cretiria.SearchModel;
            SearchText = cretiria.SearchText;
        }
    }

    public class SearchCretiria
    {
        public string SearchGear;
        public string SearchModel;
        public string SearchText;

    }
}