# Описание шаблона проектирования

## Суть шаблона
Гарантирует, что у класса есть только один экземпляр, и предоставляет к нему глобальную точку доступа. 

## Сущности
В данном шаблоне можно выделить следующие сущности :    
* **Одиночка**  
Предоставляет только один экземпляр самого себя.

## Реализация
* Определение класса с закрытым конструктором
* Добавление метода, предоставляющего к нему доступ