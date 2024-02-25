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

//2. Определение кол-ва элементов массива, соответствующих заданному условию

int GetNumberOfElements(string[] array)
{
    int count = 0;//счетчик элементов массива, соответствующих условию(<= 3)
    for (int j = 0; j < array.Length; j++)
    {        
        int d = GetNumberOfChar(array[j]);
        if (d <= 3) count++;       
    }      
    return count;
    
}
int b = GetNumberOfElements(array);
//Console.Write(b);