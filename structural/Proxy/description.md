# Описание шаблона проектирования

## Суть шаблона
Позволяет подставлять вместо реальных объектов специальные объекты-заменители. Эти объекты перехватывают вызовы к оригинальному объекту, позволяя сделать что-то до или после передачи вызова оригиналу.

## Сущности
В данном шаблоне можно выделить следующие сущности :
    
* **Сервис**  
Общий интерфейс для всех сервисов.

* **Реальный сервис**  
Сервис, который выполняет действия напрямую.

* **Заместитель**  
Сервис, выполняющий дополнительные действия, перенаправляющий работу реальному, если потребуется.

* **Приложение**  
Работает с сервисом. Работает с реальным сервисом как напрямую, так и через заместитель.

## Реализация
* Определение общего интерфейса сервисов
* Определение реального сервиса
* Определение заместителя