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

    public List<Item> Inventory { get; private set; }
    
    public Dictionary<ItemType, Item> equippedItems { get; private set; }

    public Character(string name, string job, string explain, int level,  float exp, float atk, float def, float hp, float crt, List<Item> inventory, Dictionary<ItemType, Item> equippeditems)
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
        Inventory = inventory;
        equippedItems = equippeditems;
    }

    public bool Equip(Item item)
    {
        if (equippedItems.ContainsKey(item.type))
        {
            Debug.Log("이미 이 타입의 아이템이 장착되어 있습니다.");
            return false;
        }

        // 착용
        equippedItems[item.type] = item;
        Debug.Log(item.itemName + " 착용 완료!");
        return true;
        Atk += item.plusAtk;
        Def += item.plusDef;
        Hp += item.plusHp;
        Crt += item.plusCrt;
    }

    public void UnEquip(Item item)
    {
        Atk -= item.plusAtk;
        Def -= item.plusDef;
        Hp -= item.plusHp;
        Crt -= item.plusCrt;
    }
}
