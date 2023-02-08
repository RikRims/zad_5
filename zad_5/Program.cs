//нам нужно 2 или больше повторяющихся чисел в массиве. вот
List<int> DoubleArray(List<int> a)
{
    List<int> data = new List<int> { };
    int count = 0;
    int temp = 0;

    foreach (var item in a)
    {
        temp = item;
        if (data.Contains(temp))
            continue;
        foreach (var i in a)
        {
            if (temp == i) count++;
            if (count == 2)
            {
                data.Add(temp);
                count++;
            }
        }
        count = 0;
    }

    return data;
}

//берем числа которые находяться в 2х массивах
List<int> TwoArray(List<int> a, List<int> b)
{
    List<int> data = new (){ };
    List<int> data2 = new () { };
    int count = 0;

    data = DoubleArray(a); 
    data2 = DoubleArray(b);

    for (int i = data.Count - 1; i >= 0; i--)
    {
        for (int j = data2.Count -1; j >= 0; j--)
        {
            if (data[i] == data2[j]) count++; 
            if ((count == 0) & (j == 0)) data.RemoveAt(i);
        }
    }

    return data;
}

//исходные данные
List<int> Array1 = new() { 7, 17, 1, 9, 1, 17, 56, 56, 23};
List<int> Array2 = new() { 56, 17, 17, 1, 23, 34, 23, 1, 8, 1};

//вывод ответа
List<int> data = (TwoArray(Array1,Array2));
foreach (var item in data)
{
    Console.Write($"[{item}] ");
}
