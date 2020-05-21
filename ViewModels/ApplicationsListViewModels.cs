using Rate.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rate.ViewModels
{
    public class ApplicationsListViewModels
    {
        public IEnumerable<Application> allApplications { get; set; }
        public string ApplicationCategory { get; set; }
    }
}
