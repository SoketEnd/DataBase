using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17;

internal class User
{
    public Guid ID { get; private set; } = new Guid();
    public string Name { get; set; }
    public int Age { get; set; }

    public User(string Name, int Age)
    {
        this.Name = Name;
        this.Age = Age;
    }

}
