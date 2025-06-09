using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    [field: SerializeField] public TextMeshProUGUI NameText { get; private set; }
    [field: SerializeField] public Button MainMenuBtn { get; private set; }
    [field: SerializeField] public Button StatusBtn { get; private set; }
    [field: SerializeField] public Button InventoryBtn { get; private set; }

    private void Awake()
    {
        MainMenuBtn.onClick.AddListener(OpenMainMenu);
        StatusBtn.onClick.AddListener(OpenStatus);
        InventoryBtn.onClick.AddListener(OpenInventory);
    }

    private void Start()
    {
        SetMainMenuUI();
    }

    public void OpenMainMenu()
    {
        UIManager.Instance.MainMenu.gameObject.SetActive(true);
        UIManager.Instance.Status.gameObject.SetActive(false);
        UIManager.Instance.Inventory.gameObject.SetActive(false);
    }

    public void OpenStatus()
    {
        UIManager.Instance.Status.SetStatus();
        UIManager.Instance.Status.gameObject.SetActive(true);
        UIManager.Instance.MainMenu.gameObject.SetActive(false);
    }

    public void OpenInventory()
    {
        UIManager.Instance.Inventory.RefreshInventory();
        UIManager.Instance.Inventory.gameObject.SetActive(true);
        UIManager.Instance.MainMenu.gameObject.SetActive(false);
    }

    public void SetMainMenuUI()
    {
        NameText.text = GameManager.Instance.player.Name;
    }
}
