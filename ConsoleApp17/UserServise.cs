using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17;

internal class UserServise
{
    public async Task AddUser(string Name, int Age)
    {
        using (AppContext appContext = new AppContext())
        {
            await appContext.Users.AddAsync(new User(Name, Age));
            await appContext.SaveChangesAsync();
        }
    }

    public async Task RemoveID(Guid Id)
    {
        using(AppContext appContext = new AppContext())
        {
            var preson = appContext.Users.FirstOrDefault(x => x.ID == Id);

            if (preson != null)
            {
                appContext.Users.Remove(preson);
                await appContext.SaveChangesAsync();
            }
        }
    }

    public async Task RemoveUser(Guid Id, string Name, int Age)
    {
        using (AppContext appContext = new AppContext())
        {
            var preson = appContext.Users.FirstOrDefault(x => x.ID == Id);

            preson.Name = Name;
            preson.Age = Age;

            appContext.Update(preson);
            await appContext.SaveChangesAsync();
        }
    }

    public User FindUser(Guid Id)
    {
        using (AppContext appContext = new AppContext())
        {
            var preson = appContext.Users.FirstOrDefault(x => x.ID == Id);

            return preson;
        }
    }
}
