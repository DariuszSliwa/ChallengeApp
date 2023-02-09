int number = 4566;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();

int[] results = new int[10];

foreach (var letter in letters)
{
    for (int i = 0; i<=results.Length; i++)
    {
        int a = letter - '0';
        if(a == i)
        {
            results[i]++;
        }
    }
}
for (int j = 0; j < results.Length; j++)
{
    Console.WriteLine(j + " => " + results[j]);
}