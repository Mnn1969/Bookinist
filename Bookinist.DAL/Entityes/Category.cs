﻿using Bookinist.DAL.Entityes.Base;

namespace Bookinist.DAL.Entityes
{
    public class Category : NamedEntity
    {
        public ICollection<Book>? Books { get; set; }
    }
}