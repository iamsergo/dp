# Описание шаблона проектирования

## Суть шаблона
Позволяет динамически добавлять объектам новую функциональность, оборачивая их в полезные «обёртки».

## Сущности
В данном шаблоне можно выделить следующие сущности :
    
* **Компонент**  
Общий интерфейс для всех компонентов.

* **Конкретный компонент**  
Базовый компонент. Содержит базовое поведение.

* **Базовый декоратор**  
Общая обертка для компонентов. Дополняет конкретный компонент.

* **Конкретный декоратор**  
Дополняет компоненты конкретными действиями.

* **Приложение**  
Работает через компонент.

## Реализация
* Определение общего интерфейса компонентов
* Определение конкретного компонента с базовым поведением
* Определение базового декоратора
* Определение конкретного декоратора