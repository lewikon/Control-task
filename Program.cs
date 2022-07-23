string[] input = { "еда", "стагетти", "соус", "поле", "лес" };
string output = FindShortWords(input);
string FindShortWords(string[] input)
{
    string output = string.Empty;
    for (int i = 0; i < input.Length; i++)
    {
        string temp = string.Empty;
        temp = input[i];
        if (temp.Length <= 3)
        {
            output = output + temp + " ";
        }

    }
    return output;
}
Console.WriteLine(output);