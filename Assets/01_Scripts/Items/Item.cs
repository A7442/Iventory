using UnityEngine;

public enum ItemType { Weapon, Shield, Accessory}

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
    public string itemName;
    public Sprite icon;
    public ItemType type;
    public float plusAtk;
    public float plusDef;
    public float plusHp;
    public float plusCrt;
}