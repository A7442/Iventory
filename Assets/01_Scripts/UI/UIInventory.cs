using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    public UISlot selectedSlot;
    public Button equipBt; 
    public Button unEquipBt;
    
    [SerializeField] private GameObject slotPrefab;
    [SerializeField] private Transform slotParent;
    [SerializeField] private List<UISlot> slots = new ();
    
    private void Start()
    {
        InitInventoryUI();
        equipBt.onClick.AddListener(Equip);
        unEquipBt.onClick.AddListener(UnEquip);
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
            slot.outline.enabled = false;
            slot.uiInventory = this;
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

    public void Equip()
    {
        selectedSlot.isequiped = true;
        GameManager.Instance.Player.Equip(selectedSlot.currentItem);
    }
    
    public void UnEquip()
    {
        selectedSlot.isequiped = false;
        GameManager.Instance.Player.UnEquip(selectedSlot.currentItem);
    }
}