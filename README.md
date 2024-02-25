# Задача
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.

## Этапы решения
* Для формирования нового массива необходимо определить его размер. Он будет равен
  количеству элементов из заданного массива, соответствующих условию : < или = 3 символам.  
* Определяем количество символов в каждом элементе заданного массива строкового типа.
* Определяем количество элеиентов массива, соответствующих заданному условию.
* Создаем новый массив: выделяем для него память в соответствии с его уже определенным      
  размером, тип данных - как в заданном массиве.
* Перебираем еще раз исходный массив и при нахождении элементов, соответствующих заданному 
  условию, их значения присваиваем элементам нового массива, поочередно. Так формируем 
  новый массив.

 *Taк как при решении задачи дважды перебираются элементы исходного массива, и при этом определяется их размер, то эти действия выделены в отдельный метод.*

 Блок-схема алгоритма
 
   ![Блок-схема>](Блок-схема.jpg)
