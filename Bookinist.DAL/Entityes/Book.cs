﻿using Bookinist.DAL.Entityes.Base;

namespace Bookinist.DAL.Entityes
{
    public class Book : NamedEntity
    {
        public Category? Category { get; set; }
    }
}
