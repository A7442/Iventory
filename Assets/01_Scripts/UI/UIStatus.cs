using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{
    [SerializeField] private TextMeshPro atkText;
    [SerializeField] private TextMeshPro defText;
    [SerializeField] private TextMeshPro hpText;
    [SerializeField] private TextMeshPro crtText;


    public void SetCharacterInfo(Character player)
    {
        atkText.text = $"{player.Atk}";
        defText.text = $"{player.Def}";
        hpText.text = $"{player.Hp}";
        crtText.text = $"{player.Crt}";
    }
}