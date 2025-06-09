using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI equipText; // "E" 표시용
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

        // 상태창 UI 업데이트
        UIManager.Instance.Status.SetStatus();

        // 인벤토리 전체 리프레시 (모든 슬롯의 "E" 갱신)
        UIManager.Instance.Inventory.RefreshInventory();
    }

    public void RefreshUI()
    {
        var equippedItem = GameManager.Instance.player.EqupItem;
        equipText.text = (equippedItem == item) ? "E" : "";
    }
}
