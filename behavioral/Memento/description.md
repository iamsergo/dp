# Описание шаблона проектирования

## Суть шаблона
Позволяет сохранять и восстанавливать прошлые состояния объектов, не раскрывая подробностей их реализации.

## Сущности
В данном шаблоне можно выделить следующие сущности :
    
* **Создатель**  
Делает снимок своего состояния.

* **Снимок**  
Содержит состояние создателя.

* **Опекун**  
Делает снимок и может восстановить предыдущее состояние.

## Реализация
* Определение создателя
* Определение снимка
* Определение опекуна