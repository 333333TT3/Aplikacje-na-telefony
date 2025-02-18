using System;
using System.Collections.Generic;

namespace PeopleDatabaseClassLibrary.Models;

public partial class Person
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Surname { get; set; }

    public int Age { get; set; }
}
