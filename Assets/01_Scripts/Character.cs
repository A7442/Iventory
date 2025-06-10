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

    public Character(string name, string job, string explain, int level,  float exp, float atk, float def, float hp, float crt, List<Item> inventory)
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
    }

    public void AddItem(Item item)
    {
        Inventory.Add(item);
    }

    public void Equip(Item item)
    {
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
