using UnityEngine;

public class UIManager : MonoBehaviour
{
    private static UIManager instance;
    public static UIManager Instance => instance;

    [field: SerializeField] public UIMainMenu MainMenu { get; private set; }
    [field: SerializeField] public UIStatus Status { get; private set; }
    [field: SerializeField] public UIInventory Inventory { get; private set; }

    private void Awake()
    {
        instance = this;
    }
}
