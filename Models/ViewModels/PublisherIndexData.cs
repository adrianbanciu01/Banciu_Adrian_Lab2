using System.Collections.Generic;
using Banciu_Adrian_Lab2.Models;

namespace Banciu_Adrian_Lab2.Models.ViewModels
{
    public class PublisherIndexData
    {
        public IEnumerable<Publisher> Publishers { get; set; }
        public IEnumerable<Book> Books { get; set; }
    }
}
