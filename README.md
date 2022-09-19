# Задача

## Программа, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3. Первоначальный массив вводится с клавиатуры.
___

## Решение
Заполняем исходный массив с клавиатуры. Окончание запонения - клавиша *Enter*. Создаем метод, в котором объявляем массив того же размера. С помощью счётчиков перебираем элементы исходного массива и те, длина которых меньше 3 символов, записываем в очередную ячейку нового массива. Выводим итоговый массив на экран.


## Методы, используемые в решении

1. **PrintArray**  - выводит массив на печать
2. **CreateArray** - заполняет массив с клавиатуры. 
3. **ThreeSymbols** - итоговый массив с элементами из первого массива, длиной не более 3 символов.