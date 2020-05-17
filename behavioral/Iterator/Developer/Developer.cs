using System.Collections.Generic;

namespace Iterator
{
    // Разработчик - конкретный итерируемый объект
    class Developer : IDeveloper
    {
        public string Name { get; set; }
        public List<string> Skills { get; set; }
        public Developer(string name, List<string> skills)
        {
            this.Name = name;
            this.Skills = skills;
        }
        public IDeveloperIterator CreateSkillsIterator()
        {
            return new SkillsIterator(this.Skills);
        }
    }
}