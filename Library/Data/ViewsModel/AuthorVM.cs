﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Data.ViewsModel
{
    public class AuthorVM
    {
        public string FullName { get; set; }
    }

    public class AuthorWithBooksVM
    {
        public string FullName { get; set; }
        public List<string> BookTitles { get; set; }
    }
}
