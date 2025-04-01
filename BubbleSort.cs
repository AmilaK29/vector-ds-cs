using Vector;


public class BubbleSort : ISorter
{
    public void Sort<K>(K[] array, int index, int num, IComparer<K> comparer) where K : IComparable<K>
    {
        if (array == null) throw new ArgumentNullException(nameof(array));
        if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
        if (num < 0) throw new ArgumentOutOfRangeException(nameof(num));
        if (index + num > array.Length) throw new ArgumentException("Invalid range");

        comparer = comparer ?? Comparer<K>.Default;

        for (int i = 0; i < num - 1; i++)
        {
            for (int j = index; j < index + num - i - 1; j++)
            {
                if (comparer.Compare(array[j], array[j + 1]) > 0)
                {
                    K temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }
}
