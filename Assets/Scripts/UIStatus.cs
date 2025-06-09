using TMPro;
using UnityEngine;

public class UIStatus : MonoBehaviour
{
    [field: SerializeField] public TextMeshProUGUI AtkText { get; private set; }
    [field: SerializeField] public TextMeshProUGUI DefText { get; private set; }
    [field: SerializeField] public TextMeshProUGUI HealthText { get; private set; }
    [field: SerializeField] public TextMeshProUGUI CriticalText { get; private set; }

    public void SetStatus()
    {
        var player = GameManager.Instance.player;

        AtkText.text = $"{player.Atk}";
        DefText.text = $"{player.Def}";
        HealthText.text = $"{player.Health}";
        CriticalText.text = $"{player.Critical}";
    }
}
