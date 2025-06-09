using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    [SerializeField] private Image icon;
    private Item currentItem;

    public void SetItem(Item item)
    {
        currentItem = item;
        RefreshUI();
    }

    private void RefreshUI()
    {
        icon.sprite = currentItem.icon;
    }
}
