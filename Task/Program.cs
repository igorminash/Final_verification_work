//string [] array = new string [] {"hello", "2", "world", ":-)"} ;
string [] array = new string [] {"1234", "1567", "-2", "computer science"} ;
//string [] array = new string [] {"Russia", "Denmark", "Kazan"} ;
string [] mass = new string [array.Length];

GetMass(array,mass);
PrintMass(mass);

void GetMass (string [] array, string [] mass){
    int j = 0;
    for (int i = 0; i < array.Length; i++ ){
        if (array[i].Length <= 3){
            mass[j] = array[i];
            j++;
        }
    }
}

void PrintMass(string [] mass)
{
    for (int j = 0; j < mass.Length; j++)
    {
        Console.Write($"{mass[j]}");
    }
    Console.WriteLine();
}




