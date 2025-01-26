// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Abstracts;

namespace GameEngine.Mechanics.Inventories;

internal class Inventory
{
    private readonly Dictionary<int, InventorySlot> _slots;

    private int _maxSlots;

    public int MaxSlots => _maxSlots;

    public Inventory(int maxSlots)
    {
        _maxSlots = maxSlots;
        _slots = [];

        for (var i = 0; i < maxSlots; i++)
        {
            _slots.Add(i, new InventorySlot());
        }
    }

    public bool AddItem(int slot, Item item)
    {
        if (!IsInRange(slot) || IsInventoryFull())
        {
            return false;
        }

        return _slots[slot].AddItem(item);
    }

    public bool AddItem(Item item)
    {
        if (IsInventoryFull())
        {
            return false;
        }

        var firstOpenSlot = _slots.FirstOrDefault(x => !x.Value.HasItem).Key;

        return _slots[firstOpenSlot].AddItem(item);
    }

    public void DecreaseMaxSlots(int amount)
    {
        _maxSlots -= amount;

        if (_maxSlots < 0)
        {
            _maxSlots = 0;
        }

        for (var i = 0; i < amount; i++)
        {
            _slots.Remove(_maxSlots + i);
        }
    }

    public void DecreaseQuantity(int slot, int amount)
    {
        if (!IsInRange(slot))
        {
            return;
        }

        _slots[slot].DecreaseQuantity(amount);
    }

    public Dictionary<int, InventorySlot> GetInventory() => _slots;

    public void IncreaseMaxSlots(int amount)
    {
        _maxSlots += amount;

        for (var i = 0; i < amount; i++)
        {
            _slots.Add(_maxSlots + i, new InventorySlot());
        }
    }

    public bool IncreaseQuantity(int slot, int amount)
    {
        if (!IsInRange(slot))
        {
            return false;
        }

        return _slots[slot].IncreaseQuantity(amount);
    }

    public bool IsInventoryFull()
    {
        foreach (var slot in _slots)
        {
            if (!slot.Value.HasItem)
            {
                return false;
            }
        }

        return true;
    }

    public bool MoveItem(int source, int target)
    {
        if (!IsInRange(target) || !IsInRange(source) || !_slots[source].HasItem)
        {
            return false;
        }

        (_slots[source], _slots[target]) = (_slots[target], _slots[source]);

        return true;
    }

    public bool RemoveItem(int slot)
    {
        if (!IsInRange(slot))
        {
            return false;
        }

        _slots[slot].RemoveItem();

        return true;
    }

    private bool IsInRange(int slot) => slot >= 0 && slot < _maxSlots;
}