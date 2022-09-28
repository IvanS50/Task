using System;

public class Program
{
    public static string LongestCommonPrefix(string[] strs)
    {
        int len = strs.Length;
        if (len == 0) return "";

        string prefix = strs[0];
        for (int i = 1; i < len; i++)
        {
            while (strs[i].IndexOf(prefix) != 0)
            {
                prefix = prefix.Substring(0, prefix.Length - 1);
                if (prefix == "") return "";
            }
        }

        return prefix;
    }

    public static void Main()
    {
        Console.WriteLine(string.Format("Words = flower, flow, flight; Answer = {0}", LongestCommonPrefix(new string[] { "flower", "flow", "flight" }))); // "fl"
        Console.WriteLine(string.Format("Words = dog, racecar, car; Answer = {0}", LongestCommonPrefix(new string[] { "dog", "racecar", "car" }))); // ""
    }
}