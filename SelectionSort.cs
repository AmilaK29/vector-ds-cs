using Vector;

public class SelectionSort : ISorter
{
    public void Sort<K>(K[] array, int index, int num, IComparer<K> comparer) where K : IComparable<K>
    {
        if (array == null) throw new ArgumentNullException(nameof(array));
        if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
        if (num < 0) throw new ArgumentOutOfRangeException(nameof(num));
        if (index + num > array.Length) throw new ArgumentException("Invalid range");

        comparer = comparer ?? Comparer<K>.Default;

        for (int i = index; i < index + num - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < index + num; j++)
            {
                if (comparer.Compare(array[j], array[minIndex]) < 0)
                {
                    minIndex = j;
                }
            }
            if (minIndex != i)
            {
                K temp = array[i];
                array[i] = array[minIndex];
                array[minIndex] = temp;
            }
        }
    }
}
