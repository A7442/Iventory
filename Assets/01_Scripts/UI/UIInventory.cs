using System.Collections.Generic;
using UnityEngine;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private GameObject slotPrefab;
    [SerializeField] private Transform slotParent;

    private List<UISlot> slots = new();

    public void InitInventoryUI(List<Item> items)
    {
        foreach (Transform child in slotParent)
            Destroy(child.gameObject);
        
        slots.Clear();

        foreach (var item in items)
        {
            var obj = Instantiate(slotPrefab, slotParent);
            var slot = obj.GetComponent<UISlot>();
            slot.SetItem(item);
            slots.Add(slot);
        }
    }
}