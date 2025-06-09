using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public string Name { get; private set; }
    public float Atk { get; private set; }
    public float Def { get; private set; }
    public float Health { get; private set; }
    public float Critical { get; private set; }

    public List<ItemData> Inventory = new List<ItemData>();
    public ItemData EqupItem { get; private set; }

    public Character(string name, float atk, float def, float health, float critical)
    {
        Name = name;
        Atk = atk;
        Def = def;
        Health = health;
        Critical = critical;
    }

    public void Equip(ItemData item)
    {
        if (EqupItem != null)
            UnEquip();

        EqupItem = item;
        Atk += item.Atk;
        Def += item.Def;
        Health += item.Health;
    }

    public void UnEquip()
    {
        if (EqupItem == null) return;

        Atk -= EqupItem.Atk;
        Def -= EqupItem.Def;
        Health -= EqupItem.Health;
        EqupItem = null;
    }

}
