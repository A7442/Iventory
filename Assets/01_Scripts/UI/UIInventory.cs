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
    [SerializeField] private UIStatus uiStatus;
    
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
            slot.isEquiped = false;
        }
        
        equipBt.gameObject.SetActive(true);
        unEquipBt.gameObject.SetActive(false);
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
        if (selectedSlot.currentItem == null)
        {
            return;
        }

        if (GameManager.Instance.Player.equippedItems.ContainsKey(selectedSlot.currentItem.type))
        {
            foreach (var slot in slots)
            {
                if (slot.currentItem == null)
                {
                    continue;
                }

                if (slot.currentItem.type == selectedSlot.currentItem.type && slot.isEquiped)
                {
                    slot.isEquiped = false;
                    GameManager.Instance.Player.UnEquip(slot);
                    slot.CheckEquip();
                }
            }
        }
        selectedSlot.isEquiped = true;
        GameManager.Instance.Player.Equip(selectedSlot);
        selectedSlot.CheckEquip();
        uiStatus.SetCharacterInfo(GameManager.Instance.Player);
    }
    
    public void UnEquip()
    {
        selectedSlot.isEquiped = false;
        GameManager.Instance.Player.UnEquip(selectedSlot);
        selectedSlot.CheckEquip();
        uiStatus.SetCharacterInfo(GameManager.Instance.Player);
    }
}