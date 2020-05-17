using System.Collections.Generic;

namespace Iterator
{
    class DeveloperApplication
    {
        public void Run()
        {
            var skills = new List<string>(){ "html", "css", "js", "nodejs"};
            var d = new Developer("ivan", skills);

            var i = d.CreateSkillsIterator();

            System.Console.WriteLine($"[{d.Name}] :");
            while(i.CanMove())
            {
                System.Console.WriteLine(i.Next() + " ");
            }
        }
    }
}