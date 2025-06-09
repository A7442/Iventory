using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    [Header("플레이어 정보")]
    [SerializeField] private TextMeshProUGUI playerName;
    [SerializeField] private TextMeshProUGUI job;
    [SerializeField] private TextMeshProUGUI level;
    [SerializeField] private Image expBar;
    [SerializeField] private TextMeshProUGUI gold;
    [Header("버튼")]
    [SerializeField] private Button statusButton;
    [SerializeField] private Button inventoryButton;
    [SerializeField] private Button backButton;
    [SerializeField] private GameObject bt;
    [Header("UI")] 
    [SerializeField] private Canvas uiStatus;
    [SerializeField] private Canvas uiInventory;
    
    
    private void Start()
    {
        statusButton.onClick.AddListener(OpenStatus);
        inventoryButton.onClick.AddListener(OpenInventory);
        backButton.onClick.AddListener(OpenMainMenu);
    }

    private void OpenMainMenu()
    {
        backButton.gameObject.SetActive(false);
        bt.SetActive(true);
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