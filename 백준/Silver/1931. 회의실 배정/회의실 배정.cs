public class Solution
{
    public static void Main(string[] args)
    {
        var reader = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        var writer = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int n = int.Parse(reader.ReadLine());

        int time = 0;
        int count = 0;

        int[][] arr = new int[n][];

        for (int i = 0; i < n; i++)
        {
            string[] temp = reader.ReadLine().Split();

            int t1 = int.Parse(temp[0]);
            int t2 = int.Parse(temp[1]);

            arr[i] = new int[] { t1, t2 };
            
        }
        
        IOrderedEnumerable<int[]> sortedBySecond = arr.OrderBy(y => y[1]).ThenBy(y => y[0]);
        int[][] sortedArr = sortedBySecond.ToArray();

        for (int i = 0; i < n; i++)
        {
            int t1 = sortedArr[i][0];
            int t2 = sortedArr[i][1];
            
            if (time == 0)
            {
                time = t2;
                count++;
            }
            else if (t1 >= time)
            {
                count++;
                time = t2;
            }
        }

        writer.Write(count);
        writer.Flush();
        
        writer.Close();
        reader.Close();
    }
}