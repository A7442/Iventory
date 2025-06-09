using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    private Canvas _curCanvas;
    
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
        
        bt.SetActive(true);
        uiStatus.gameObject.SetActive(false);
        uiInventory.gameObject.SetActive(false);
        SetCharacterInfo(GameManager.Instance.Player);
    }

    private void OpenMainMenu()
    {
        backButton.gameObject.SetActive(false);
        bt.SetActive(true);
        if (_curCanvas == null)
        {
            return;
        }
        _curCanvas.gameObject.SetActive(false);
    }

    private void OpenStatus()
    {
        backButton.gameObject.SetActive(true);
        bt.SetActive(false);
        _curCanvas = uiStatus;
        _curCanvas.gameObject.SetActive(true);
    }

    private void OpenInventory()
    {
        backButton.gameObject.SetActive(true);
        bt.SetActive(false);
        _curCanvas = uiInventory;
        _curCanvas.gameObject.SetActive(true);
    }
    

    public void SetCharacterInfo(Character player)//나중에
    {
        
    }
}