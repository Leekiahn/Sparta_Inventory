using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI equipText; // "E" ǥ�ÿ�
    [SerializeField] private Button button;

    private ItemData item;

    public void Init(ItemData data)
    {
        item = data;
        RefreshUI();

        button.onClick.RemoveAllListeners();
        button.onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        var player = GameManager.Instance.player;

        if (player.EqupItem == item)
        {
            player.UnEquip();
        }
        else
        {
            player.Equip(item);
        }

        // ����â UI ������Ʈ
        UIManager.Instance.Status.SetStatus();

        // �κ��丮 ��ü �������� (��� ������ "E" ����)
        UIManager.Instance.Inventory.RefreshInventory();
    }

    public void RefreshUI()
    {
        var equippedItem = GameManager.Instance.player.EqupItem;
        equipText.text = (equippedItem == item) ? "E" : "";
    }
}
