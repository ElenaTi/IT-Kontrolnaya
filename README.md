# Алгоритм решения задачи.
1. Объявляются:
    - переменная **numberOfElements** (которая задается пользователем);
    - Массив **arrayGiven**;
    - Массив **arrayOfThreeSymbols** с нулeвым количеством индексов;
    - переменная **length** = 4;
    - переменная **i** = 0;
2. следующим шагом запускается цикл:  
    *пока i < numberOfElements* пользователь вводит значения массива *arrayGiven*;
3. как только все значения исходного массива введены:
    -  запускается цикл перебора всех элементов массива arrayGiven;
    - следующий шаг в цикле - условие, если значение элемента массива меньше 4 (length), то это в массиве *arrayOfThreeSymbols* добавляется новый элемент c соответствующим значением элементов массива arrayGiven;
4. как только все элементы массива arrayGiven перебраны, *выводится массив arrayOfThreeSymbols*.
