//1. Определение количества символов в элементе массива строкового типа
int GetNumberOfChar(string arr)
{ 
 string str = " ";
        int k = 0; //счетчик кол-ва символов в строке
        foreach (char e in arr)
        {
            str += e;
            k++;
        }
        return k;
}

//string arr = "Hellomfktio";
//int b = GetNumberOfChar(arr);
// Console.Write(b);