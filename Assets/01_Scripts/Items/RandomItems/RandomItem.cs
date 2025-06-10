using System.Collections.Generic;
using System.Net.NetworkInformation;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using Random = System.Random;

public class RandomItem : MonoBehaviour
{
    [SerializeField] private List<Item> randomItems;
    [SerializeField] private Button drawRandomBt;
    [SerializeField] private UIInventory uiInventory;
    [SerializeField] private UIMainMenu uiMainMenu;

    private void Start()
    {
        drawRandomBt.onClick.AddListener(DrawRandomItem);
    }

    private void DrawRandomItem()
    {
        GameManager.Instance.Player.UseGold(100);
        Random random = new Random();
        int index = random.Next(randomItems.Count);
        var randomItem = randomItems[index];
        uiInventory.SetSlot(randomItem);
        uiMainMenu.SetCharacterInfo();
    }
}
