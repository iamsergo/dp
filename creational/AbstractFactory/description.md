# Описание шаблона проектирования

## Суть шаблона
Позволяет создавать семейства связанных объектов, не привязываясь к конкретным классам создаваемых объектов.  

## Сущности
В данном шаблоне можно выделить следующие сущности :    
* **Продукт**  
Описывает общий продукт.

* **Конкретный продукт**  
Описывает конкретный продукт определенного вида.

* **Фабрика**  
Производит все продукты ОБЩЕГО вида.

* **Конкретная фабрика**  
Производит все продукты конкретного вида.

* **Приложение**  
Работает с общей фабрикой.

## Реализация
* Определение общих интерфейсов для всех продуктов
* Определение всех продуктов всех видов
* Определение общей фабрики с методами, создающими каждый продукт
* Определение конкретных фабрик с методами, создающими каждый продукт своего вида
* Приложение, создающее продукты через общую фабрику.