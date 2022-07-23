string[] input = { "еда", "стагетти", "соус", "поле", "лес" };int FindShortWords(string[] input)
{
    int  count = 0;
    for (int i = 0; i < input.Length; i++)
    {
        string temp = string.Empty;
        temp = input[i];
        if (temp.Length <= 3)
        {
            count++;
        }

    }
    return count;
}