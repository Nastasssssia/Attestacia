Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
1) Для ввода строк исходного массива с клавиатуры создан методы Input и InputArray. С помощью данных методово пользователь задает 1,2,3,4,5-й элемента массива с индексами 0,1,2,3,4.
2) метод Filter.
   Для определения размера нового массива внутри метода устанавливается счетчик count равным 0. Этот счетчик будет использоваться для подсчета количества строк во входном массиве, длина которых меньше или равна 3 символам.
   Затем выполняется цикл for,внутри цикла проверяется длина каждой строки. Если длина строки меньше или равна 3 символам, то увеличивается значение счетчика count.
   Далее создается новый массив строк newArray с размером, равным значению count. То есть это массив, который будет содержать отфильтрованные строки.
   Создается индекс newIndex, который будет использоваться для заполнения массива newArray в следующем цикле.
   Начинается второй цикл for, который снова перебирает элементы массива. Внутри этого цикла снова проверяется длина текущей строки. Если длина соответствует условию (меньше или равна 3 символам), то выполняется следующий блок кода:
   текущая строка копируется в новый массив newArray по индексу newIndex. newIndex увеличивается на 1 для следующей строки.
   После завершения второго цикла for, массив newArray будет содержать только те строки, длина которых меньше или равна 3 символам.
3) Для вывода массива на печать создан метод PrintArray.Данный метод с помощью цикла for выводит каждый элемент нужного массива на экран. 