using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    public Image equipImage;
    public Outline outline;
    public bool isequiped;
    public UIInventory uiInventory;
    
    [SerializeField] private Image icon;
    [SerializeField] private Item currentItem;

    
    public bool SetItem(Item item)
    {
        if (currentItem != null)
        {
            return false;
        }
        currentItem = item;
        RefreshUI();
        return true;
    }

    private void RefreshUI()
    {
        icon.sprite = currentItem.icon;
    }

    public void SelectItem()
    {
        if (uiInventory.selectedSlot != null)
        {
            uiInventory.selectedSlot.outline.enabled = false;
        }
        outline.enabled = true;
        uiInventory.selectedSlot = this;
        if (uiInventory.selectedSlot.isequiped)
        {
            uiInventory.equipBt.gameObject.SetActive(false);
            uiInventory.unEquipBt.gameObject.SetActive(true);
        }
        else
        {
            uiInventory.equipBt.gameObject.SetActive(true);
            uiInventory.unEquipBt.gameObject.SetActive(false);
        }
    }
}
