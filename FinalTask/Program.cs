string userString = ReadString("Введите строки через запятую: ");
int maxLength = 3;
int count = 0;

for (int j = 0; j < userString.Length; j++)
{
    if (userString[j] == ',')
        count++;
}

string[] userStringArray = new string[count + 1];

for (int i = 0; i < userString.Length; i++)
{
    if (userString[i] != ',')
    {
        userStringArray[userStringArray.Length - count - 1] += userString[i];
    }
    else
    {
        count--;
    }
}

int size = 0;
for (int i = 0; i < userStringArray.Length; i++)
{
    if (userStringArray[i].Length <= maxLength)
    {
        size++;
    }
}

string[] newArray = new string[size];

for (int i = 0; i < userStringArray.Length; i++)
{
    if (userStringArray[i].Length <= maxLength)
    {
        newArray[newArray.Length - size] = userStringArray[i];
        size--;
    }
}

WriteArray(newArray);

void WriteArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

string ReadString(string msg)
{
    Console.Write(msg);
    return Console.ReadLine();
}