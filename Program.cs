namespace MergeAndQuickSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student[] students = new student[]
            {
                    new student(1032, "Alice Johson", "Computer Science", "1st Year"),
                    new student(1078, "Bob Smith", "Electrical Engineering", "2nd Year"),
                    new student(1021, "Charlie Brown", "Mechanical Engineering", "3rd Year"),
                    new student(1095, "David Wilson", "Mathematics", "4th Year"),
                    new student(1056, "Emma Davis", "Computer Science", "2nd Year"),
                    new student(1083, "Frank Thomas", "Physics", "3rd Year"),
                    new student(1017, "Grace Lee", "Business Administration", "1st Year"),
                    new student(1044, "Henry White", "Civil Engineering", "4th Year"),
                    new student(1068, "Ivy Martin", "Biology", "2nd Year"),
                    new student(1039, "Jack Anderson", "Computer Science", "3rd Year"),
                    new student(1027, "Katie Harris", "Economics", "4th Year"),
                    new student(1089, "Liam Carter", "Software Engineering", "1st Year"),
                    new student(1051, "Mia Roberts", "Information Systems", "2nd Year"),
                    new student(1005, "Noah Walker", "Mechanical Engineering", "3rd Year"),
                    new student(1013, "Olivia Adams", "Electrical Engineering", "4th Year")
            };

            Console.WriteLine("Merge Sort");
            Console.WriteLine("------------");
            int[] studentIds = students.Select(s => s.StudentID).ToArray();
            MergeSort(studentIds);
            foreach (var id in studentIds)
            {
                student found = students.First(s => s.StudentID == id);
                found.DisplayStudent();
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Quick Sort");
            Console.WriteLine("------------");
            studentIds = students.Select(s => s.StudentID).ToArray();
            QuickSort(studentIds, 0, studentIds.Length - 1);
            foreach (var id in studentIds)
            {
                student found = students.First(s => s.StudentID == id);
                found.DisplayStudent();
            }
        }

        public static void MergeSort(int[] arr)
        {
            int n = arr.Length;
            if (n < 2)
            {
                return;
            }
            int mid = n / 2;
            int[] left = new int[mid];
            int[] right = new int[n - mid];
            for (int i = 0; i < mid; i++)
            {
                left[i] = arr[i];
            }
            for (int i = mid; i < n; i++)
            {
                right[i - mid] = arr[i];
            }
            MergeSort(left);
            MergeSort(right);
            Merge(left, right, arr);
        }

        public static void Merge(int[] left, int[] right, int[] arr)
        {
            int nL = left.Length;
            int nR = right.Length;
            int i = 0, j = 0, k = 0;
            while (i < nL && j < nR)
            {
                if (left[i] <= right[j])
                {
                    arr[k] = left[i];
                    i++;
                }
                else
                {
                    arr[k] = right[j];
                    j++;
                }
                k++;
            }
            while (i < nL)
            {
                arr[k] = left[i];
                i++;
                k++;
            }
            while (j < nR)
            {
                arr[k] = right[j];
                j++;
                k++;
            }
        }

        public static void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);
                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            }
        }

        public static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;
            return i + 1;
        }
    }
}
