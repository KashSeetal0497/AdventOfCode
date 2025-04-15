class Program
{
    static void Main()
    {
        var list1 = new List<int>();
        var list2 = new List<int>();
        string input = "start";
        input = Console.ReadLine();
        while (!string.IsNullOrWhiteSpace(input))
        {
            var temp = input.Split("  ");
            list1.Add(int.Parse(temp[0]));
            list2.Add(int.Parse(temp[1]));
            input = Console.ReadLine();
        }

        list1 = list1.OrderBy(x => x).ToList();
        list2 = list2.OrderBy(x => x).ToList();

        int diff = 0;
        int similarity = 0;
        for (int i = 0; i < list1.Count; i++)
        {
            if (list1[i] > list2[i])
            {
                diff += list1[i] - list2[i];
            }
            else
            {
                diff += list2[i] - list1[i];
            }
        }

        for (int i = 0; i < list1.Count; i++)
        {
            similarity += list2.Where(x => x == list1[i]).Count() * list1[i];
        }

        Console.WriteLine(diff);
        Console.WriteLine(similarity);
    }
}