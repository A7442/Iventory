using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private UIMainMenu mainMenuUI;
    [SerializeField] private UIStatus statusUI;
    [SerializeField] private UIInventory inventoryUI;
    
    private void Awake()
    {
        mainMenuUI = FindAnyObjectByType<UIMainMenu>();
        statusUI = FindAnyObjectByType<UIStatus>();
        inventoryUI = FindAnyObjectByType<UIInventory>();
    }

    public void OpenUI(GameObject canvas)
    {
        canvas.SetActive(true);
    }
    
    public void CloseUI(GameObject canvas)
    {
        canvas.SetActive(false);
    }
}