string[] CreateString ()
{
    System.Console.WriteLine("Сколько слов будет в вашем массиве");
    int stringLength = Convert.ToInt32(Console.ReadLine());
    string [] word = new string[stringLength];
    for (int i = 0; i < word.Length; i++)
    {
        System.Console.WriteLine("Enter word");
        word[i] = Convert.ToString(Console.ReadLine());
    }
    return word;
}
void PrintString(string[] words)
{
    for (int i = 0; i < words.Length; i++)
    {
        int wordLen = words[i].Length;
        if(wordLen <=3 )
            System.Console.Write(words[i] + " ");
    }
}
PrintString(CreateString());