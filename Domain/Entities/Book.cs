﻿namespace Domain.Entities;

public class Book : BaseEntity
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }
    public string Genre { get; set; }
}