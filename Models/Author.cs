﻿using System.Collections.Generic;
using Banciu_Adrian_Lab2.Models;

namespace Nume_Pren_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<Book>? Books { get; set; } // Navigation property
    }
}

