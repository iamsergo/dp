using System.Collections.Generic;

namespace Iterator
{
    // Итератор по навыкам - конкретный итератор
    class SkillsIterator : IDeveloperIterator
    {
        private List<string> skills;
        private int id;
        public SkillsIterator(List<string> skills)
        {
            this.skills = skills;
        }
        
        public object Next()
        {
            return this.skills[this.id++];
        }
        public bool CanMove()
        {
            return this.id < this.skills.Count;
        }
    }
}