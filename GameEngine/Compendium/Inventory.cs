// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

namespace GameEngine.Compendium;

public class Inventory
{
    private readonly Dictionary<int, InventorySlot> _slots;

    private int _maxSlots;

    public int MaxSlots => _maxSlots;

    public Inventory(int maxSlots)
    {
        _maxSlots = maxSlots;
        _slots = [];

        foreach (var slot in _slots)
        {
            _slots[slot.Key] = new InventorySlot();
        }
    }

    public bool AddItem(int slot, ItemBase item, int quantity)
    {
        if (!IsInRange(slot))
        {
            return false;
        }

        return _slots[slot].AddItem(item, quantity);
    }

    public void DecreaseMaxSlots(int amount)
    {
        _maxSlots -= amount;

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
            _slots[_maxSlots + i] = new InventorySlot();
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

    public bool MoveItem(int sourceSlot, int targetSlot)
    {
        if (!IsInRange(targetSlot) || !_slots.TryGetValue(sourceSlot, out var item) || _slots.ContainsKey(targetSlot))
        {
            return false;
        }

        _slots[targetSlot] = item;

        _slots[sourceSlot].RemoveItem();

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