int[] array1 = { 2, 2, 5, 20, 3, 22, 4 };
int[] array2 = { 4, 2, 2, 20, 4, 6, 5, 21, 20};

int[] result = GetIntersection(array1, array2);

Console.WriteLine("Intersection of given arrays: " + string.Join(", ", result));

static int[] GetIntersection(int[] arr1, int[] arr2)
{
    var set = new HashSet<int>(arr1);

    var intersection = new List<int>();
    foreach (var num in arr2)
    {
        if (set.Contains(num))
        {
            intersection.Add(num);
            set.Remove(num);
        }
    }
    return intersection.ToArray();
}