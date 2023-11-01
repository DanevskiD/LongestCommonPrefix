namespace LongestCommonPrefix;
public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        string prefix = strs[0];

        for (int i = 1; i < strs.Length; i++)
        {
            string currentPrefix = string.Empty;

            for (int j = 0; j < strs[i].Length; j++)
            {
                if (j >= prefix.Length)
                    break;
                if (strs[i][j] == prefix[j])
                {
                    currentPrefix += strs[i][j];
                }
                else
                {
                    break;
                }
            }
            prefix = currentPrefix;
        }
        return prefix;
    }
}