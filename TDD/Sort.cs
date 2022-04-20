
namespace TDD
{
    public class Sort
    {
        public static Worker[] BubbleWorkers(Worker[] workers)
        {
            Worker temp;
            var n = workers.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (workers[j].CompareTo(workers[j + 1]) < 1)
                        (workers[j], workers[j + 1]) = (workers[j + 1], workers[j]);

            return workers;
        }

        public static Worker[] QuickWorkers(Worker[] workers, int start, int end)
        {
            int i;
            if (start < end)
            {
                i = Partition(workers, start, end);

                QuickWorkers(workers, start, i - 1);
                QuickWorkers(workers, i + 1, end);
            }

            return workers;
        }

        private static int Partition(Worker[] arr, int start, int end)
        {
            Worker temp;
            var p = arr[end];
            int i = start - 1;

            for (int j = start; j <= end - 1; j++)
            {
                if (arr[j].CompareTo(p) >= 0)
                {
                    i++;
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            temp = arr[i + 1];
            arr[i + 1] = arr[end];
            arr[end] = temp;
            return i + 1;
        }
    }
}