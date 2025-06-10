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
    [SerializeField] private TextMeshProUGUI expInfo;
    [SerializeField] private TextMeshProUGUI gold;
    [SerializeField] private TextMeshProUGUI jobInfo;
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
        SetCharacterInfo();
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
    

    public void SetCharacterInfo()
    {
        playerName.text = GameManager.Instance.Player.PlayerName;
        job.text = GameManager.Instance.Player.Job;
        level.text = $"{GameManager.Instance.Player.Level}";
        expBar.fillAmount = GameManager.Instance.Player.Exp / 12;
        expInfo.text = $"{GameManager.Instance.Player.Exp} / {12}";
        gold.text = GoldComma();
        jobInfo.text = GameManager.Instance.Player.JobExplain;
    }

    public string GoldComma()
    {
        float gold = GameManager.Instance.Player.Gold;
        string formatted = gold.ToString("N0");
        return formatted;
    }
}