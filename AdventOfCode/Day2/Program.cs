class Program
{
    static void Main()
    {
        var list = new List<List<int>>();
        string input = "start";
        var count = 0;
        input = Console.ReadLine();
        while (!string.IsNullOrWhiteSpace(input))
        {
            var temp = input.Split(' ').ToList();
            var newList = new List<int>();
            temp.ForEach(x => { var tempInt = int.Parse(x); newList.Add(tempInt); });
            list.Add(newList);
            input = Console.ReadLine();
        }
        bool invalid = false;
        foreach (var item in list)
        {
            invalid = false;
            if (item[1] < item[2])
            {
                for (int i = 0; i < item.Count - 1; i++)
                {
                    if (item[i + 1] - item[i] > 3 || item[i + 1] < item[i] || item[i + 1] == item[i])
                    {
                        var skipIndex = 0;
                        while (skipIndex < item.Count)
                        {
                            var tempList = new List<int>();
                            item.ForEach(x => tempList.Add(x));
                            tempList.RemoveAt(skipIndex);
                            for (int j = 0; j < tempList.Count - 1; j++)
                            {
                                if (tempList[j + 1] - tempList[j] <= 3 && tempList[j + 1] > tempList[j] && tempList[j + 1] != tempList[j])
                                {
                                    invalid = false;
                                }
                                else
                                {
                                    invalid = true;
                                    break;
                                }
                            }
                            if (!invalid) break;
                            skipIndex++;

                        }
                    }
                    if (invalid) break;
                }

                if (!invalid)
                {
                    count++;
                }
            }
            else
            {
                for (int i = 0; i < item.Count - 1; i++)
                {
                    if (item[i] - item[i + 1] > 3 || item[i] < item[i + 1] || item[i + 1] == item[i])
                    {
                        var skipIndex = 0;
                        while (skipIndex < item.Count)
                        {
                            var tempList = new List<int>();
                            item.ForEach(x => tempList.Add(x));
                            tempList.RemoveAt(skipIndex);
                            for (int j = 0; j < tempList.Count - 1; j++)
                            {
                                if (tempList[j] - tempList[j + 1] <= 3 && tempList[j] > tempList[j + 1] && tempList[j + 1] != tempList[j])
                                {
                                    invalid = false;
                                }
                                else
                                {
                                    invalid = true;
                                    break;
                                }
                            }
                            if (!invalid) { break; }
                            else
                            {
                                skipIndex++;
                            }
                        }
                    }
                    if (invalid) break;
                }

                if (!invalid)
                {
                    count++;
                }
            }
        }

        Console.WriteLine(count);
    }
}

//DAY 1
//class Program
//{
//    static void Main()
//    {
//        var list1 = new List<int>();
//        var list2 = new List<int>();
//        string input = "start";
//        input = Console.ReadLine();
//        while (!string.IsNullOrWhiteSpace(input))
//        {
//            var temp = input.Split("  ");
//            list1.Add(int.Parse(temp[0]));
//            list2.Add(int.Parse(temp[1]));
//            input = Console.ReadLine();
//        }

//        list1 = list1.OrderBy(x => x).ToList();
//        list2 = list2.OrderBy(x => x).ToList();

//        int diff = 0;
//        int similarity = 0;
//        for (int i = 0; i < list1.Count; i++)
//        {
//            if (list1[i] > list2[i])
//            {
//                diff += list1[i] - list2[i];
//            }
//            else
//            {
//                diff += list2[i] - list1[i];
//            }
//        }

//        for (int i = 0; i < list1.Count; i++)
//        {
//            similarity += list2.Where(x => x == list1[i]).Count() * list1[i];
//        }

//        Console.WriteLine(diff);
//        Console.WriteLine(similarity);
//    }
//}

//DAY 2
//class Program
//{
//    static void Main()
//    {
//        var list = new List<List<int>>();
//        string input = "start";
//        var count = 0;
//        input = Console.ReadLine();
//        while (!string.IsNullOrWhiteSpace(input))
//        {
//            var temp = input.Split(' ').ToList();
//            var newList = new List<int>();
//            temp.ForEach(x => { var tempInt = int.Parse(x); newList.Add(tempInt); });
//            list.Add(newList);
//            input = Console.ReadLine();
//        }
//        bool invalid = false;
//        foreach (var item in list)
//        {
//            invalid = false;
//            if (item[0] < item[1])
//            {
//                for (int i = 0; i < item.Count - 1; i++)
//                {
//                    if (item[i + 1] - item[i] > 3 || item[i + 1] < item[i] || item[i + 1] == item[i])
//                    {
//                        invalid = true;
//                        break;
//                    }
//                }

//                if (!invalid)
//                {
//                    count++;
//                }
//            }
//            else
//            {
//                for (int i = 0; i < item.Count - 1; i++)
//                {
//                    if (item[i] - item[i + 1] > 3 || item[i] < item[i + 1] || item[i + 1] == item[i])
//                    {
//                        invalid = true;
//                        break;
//                    }
//                }

//                if (!invalid)
//                {
//                    count++;
//                }
//            }
//        }

//        Console.WriteLine(count);
//    }
//}