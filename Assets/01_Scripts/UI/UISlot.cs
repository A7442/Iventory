using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    public Image equipImage;
    public Outline outline;
    public UIInventory uiInventory;
    public Item currentItem;
    public bool isEquiped;
    
    [SerializeField] private Image icon;
    
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
        CheckEquip();
    }

    public void CheckEquip()
    {
        if (uiInventory.selectedSlot.currentItem == null)
        {
            return;
        }
        if (uiInventory.selectedSlot.isEquiped)
        {
            equipImage.gameObject.SetActive(true);
            uiInventory.equipBt.gameObject.SetActive(false);
            uiInventory.unEquipBt.gameObject.SetActive(true);
        }
        else
        {
            equipImage.gameObject.SetActive(false);
            uiInventory.equipBt.gameObject.SetActive(true);
            uiInventory.unEquipBt.gameObject.SetActive(false);
        }
    }
}
