using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI atkText;
    [SerializeField] private TextMeshProUGUI defText;
    [SerializeField] private TextMeshProUGUI hpText;
    [SerializeField] private TextMeshProUGUI crtText;


    public void SetCharacterInfo(Character player)
    {
        atkText.text = $"{player.Atk}";
        defText.text = $"{player.Def}";
        hpText.text = $"{player.Hp}";
        crtText.text = $"{player.Crt}";
    }
}