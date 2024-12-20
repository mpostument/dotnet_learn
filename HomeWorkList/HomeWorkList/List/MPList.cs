﻿namespace HomeWorkList;

public class MPList
{
    private MPListItem first;
    
    public int GetItem(int index)
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
        MPListItem prev = null;
        
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

    public void AddItem(int value)
    {
        var newItem = new MPListItem(value);
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

    public void UpdateItem(int index, int value)
    {
        var item = GetItemByIndex(index);
        item.value = value;
    }

    private MPListItem FindLastItem()
    {
        var last = first;
        while (last?.next != null)
        {
            last = last.next;
        }
        return last;
    }

    private MPListItem GetItemByIndex(int index)
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

public class MPListItem
{
    public int value;
    public MPListItem next;

    public MPListItem(int value, MPListItem next): this(value)
    {
        this.next = next;
    }

    public MPListItem(int value)
    {
        this.value = value;
    }
}