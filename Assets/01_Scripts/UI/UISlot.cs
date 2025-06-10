using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    public Image equipImage;
    
    [SerializeField] private Image icon;
    private Item _currentItem;

    public bool SetItem(Item item)
    {
        if (_currentItem != null)
        {
            return false;
        }
        _currentItem = item;
        RefreshUI();
        return true;
    }

    private void RefreshUI()
    {
        icon.sprite = _currentItem.icon;
    }
}
