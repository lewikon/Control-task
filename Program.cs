string[] input =
{ "90", "еда", "стагетти", "соус", "поле", "лес", "папарацци"};
Console.WriteLine(PrintArray(WordCount(input)));

string[] WordCount(string[] input)
{
    int count = 0;
    for (int i = 0; i < input.Length; i++)
    {
        string temporary = string.Empty;
        temporary = input[i];
        if (temporary.Length <= 3)
        {
            count++;
        }
    }
    string[] output = new string[count];
    int index = 0;
    for (int i = 0; i < input.Length; i++)
    {
        string temp = string.Empty;
        temp = input[i];
        if (temp.Length <= 3)
        {
            output[index] = temp;
            index++;
        }
    }
    return output;

}
string PrintArray(string[] array)
{
    string output = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        output = output + array[i] + " ";
    }
    return output;
}