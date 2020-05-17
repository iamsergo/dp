namespace Iterator
{
    // Общий интерфейс для итерируемого объекта
    interface IDeveloper
    {
        IDeveloperIterator CreateSkillsIterator();
    }
}