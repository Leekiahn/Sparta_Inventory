using System.Collections.Generic;
using UnityEngine;

public class UIInventory : MonoBehaviour
{
    public GameObject slotPrefab;
    public Transform slotParents;
    public List<UISlot> slots = new List<UISlot>();

    public void RefreshInventory()
    {
        foreach (Transform child in slotParents)
            Destroy(child.gameObject);

        slots.Clear();

        foreach (var item in GameManager.Instance.player.Inventory)
        {
            GameObject go = Instantiate(slotPrefab, slotParents);
            UISlot slot = go.GetComponent<UISlot>();
            slot.Init(item);
            slots.Add(slot);
        }
    }
}

