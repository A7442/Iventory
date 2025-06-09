using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    [Header("플레이어 정보")]
    [SerializeField] private TextMeshPro playerName;
    [SerializeField] private TextMeshPro job;
    [SerializeField] private TextMeshPro level;
    [Header("버튼")]
    [SerializeField] private Button statusButton;
    [SerializeField] private Button inventoryButton;
    [SerializeField] private GameObject bt;

    private void Start()
    {
        statusButton.onClick.AddListener(OpenStatus);
        inventoryButton.onClick.AddListener(OpenInventory);
    }

    private void OpenMainMenu()
    {
        
    }

    private void OpenStatus()
    {
        
    }

    private void OpenInventory()
    {
        
    }
    

    public void SetCharacterInfo(Character player)
    {
        
    }
}