using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public string PlayerName { get; private set; }
    public string Job { get; private set; }
    public string JobExplain { get; private set; }
    public int Level { get; private set; }
    
    public float Exp { get; private set; }
    public float Atk { get; private set; }
    public float Def { get; private set; }
    public float Hp { get; private set; }
    public float Crt { get; private set; }
    
    public float Gold { get; private set; }

    public List<Item> Inventory { get; private set; }
    
    public Dictionary<ItemType, UISlot> equippedItems { get; private set; }

    public Character(string name, string job, string explain, int level,  float exp, float atk, float def, float hp, float crt, float gold,List<Item> inventory, Dictionary<ItemType, UISlot> equippeditems)
    {
        PlayerName = name;
        Job = job;
        JobExplain = explain;
        Level = level;
        Exp = exp;
        Atk = atk;
        Def = def;
        Hp = hp;
        Crt = crt;
        Gold = gold;
        Inventory = inventory;
        equippedItems = equippeditems;
    }

    public void Equip(UISlot uiSlot)
    {
        equippedItems[uiSlot.currentItem.type] = uiSlot;
        Atk += uiSlot.currentItem.plusAtk;
        Def += uiSlot.currentItem.plusDef;
        Hp += uiSlot.currentItem.plusHp;
        Crt += uiSlot.currentItem.plusCrt;
    }

    public void UnEquip(UISlot uiSlot)
    {
        Atk -= uiSlot.currentItem.plusAtk;
        Def -= uiSlot.currentItem.plusDef;
        Hp -= uiSlot.currentItem.plusHp;
        Crt -= uiSlot.currentItem.plusCrt;
        if (equippedItems.ContainsKey(uiSlot.currentItem.type))
        {
            equippedItems.Remove(uiSlot.currentItem.type);
        }
    }

    public void UseGold(float gold)//골드 소모
    {
        if (Gold >= gold)
        {
            Gold -= gold;
        }
    }

    public void PlusExp(float exp)//레벨업 기능, 기능만 넣어봄
    {
        Exp += exp;
        while (Exp < 12.0f)
        {
            if (Exp >= 12.0f)
            {
                Level++;
                Exp =- 12.0f;
            }
        }
    }
}
