using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private GameObject slotPrefab;
    [SerializeField] private Transform slotParent;

    [SerializeField] private List<UISlot> slots = new ();

    //임시
    private int _slotnum = 0;
    
    private void Start()
    {
        InitInventoryUI();
    }

    public void InitInventoryUI()
    {
        foreach (Transform child in slotParent)
        {
            Destroy(child.gameObject);
        }
        
        slots.Clear();

        for (int i = 0; i < 24; i++)
        {
            var obj = Instantiate(slotPrefab, slotParent);
            var slot = obj.GetComponent<UISlot>();
            slot.equipImage.gameObject.SetActive(false);
            slots.Add(slot);
        }
    }

    public void SetSlot(Item item)
    {
        foreach (var slot in slots)
        {
            if (slot.SetItem(item))
            {
                return;
            }
        }
    }
}