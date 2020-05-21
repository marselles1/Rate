using Rate.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rate.ViewModels
{
    public class HomeViewModels
    {
        public IEnumerable<Application> FarApplications { get; set; }
    }
}
