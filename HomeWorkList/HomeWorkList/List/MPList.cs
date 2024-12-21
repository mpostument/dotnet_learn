using System.Numerics;

namespace HomeWorkList;

public class MPList<T> where T : INumber<T>
{
    private MPListItem<T> first;

    public int Count
    {
        get
        {
            var counter = 0;
            var last = first;
            if (last is not null)
            {
                counter++;
            }

            while (last is not null)
            {
                last = last.next;
                counter++;
            }

            return counter;
        }
    }

    public T this[int index]
    {
        get { return GetItemByIndex(index).value; }
        set { GetItemByIndex(index).value = value; }
    }

    public T GetItem(int index)
    {
        return GetItemByIndex(index).value;
    }

    public void DeleteItem(int index)
    {
        if (index == 0)
        {
            first = first?.next;
            return;
        }

        var i = 0;
        var current = first;
        MPListItem<T> prev = null;

        while (current != null && i != index)
        {
            prev = current;
            current = current.next;
            i++;
        }

        if (current != null)
        {
            prev.next = current.next;
        }
    }

    public void AddItem(T value)
    {
        var newItem = new MPListItem<T>(value);
        var last = FindLastItem();
        if (last is null)
        {
            first = newItem;
        }
        else
        {
            last.next = newItem;
        }
    }

    public void UpdateItem(int index, T value)
    {
        var item = GetItemByIndex(index);
        item.value = value;
    }

    private MPListItem<T> FindLastItem()
    {
        var last = first;
        while (last?.next != null)
        {
            last = last.next;
        }

        return last;
    }

    private MPListItem<T> GetItemByIndex(int index)
    {
        var i = 0;
        var last = first;
        while (last?.next != null && i != index)
        {
            i++;
            last = last.next;
        }

        return last;
    }
}

public class MPListItem<T> where T : INumber<T>
{
    public MPListItem<T> next;
    public T value;

    public MPListItem(T value, MPListItem<T> next) : this(value)
    {
        this.next = next;
    }

    public MPListItem(T value)
    {
        this.value = value;
    }
}