using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameManager Instance => instance;

    public Character player;

    public ItemData ironArmor { get; private set; }
    public ItemData goldArmor { get; private set; }
    public ItemData silverSword { get; private set; }
    public ItemData goldSword { get; private set; }

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        SetData();
    }

    public void SetData()
    {
        player = new Character("Kiahn", 35, 40, 100, 20);

        ironArmor = new ItemData("Iron Armor", 0, 20, 0);
        goldArmor = new ItemData("Gold Armor", 0, 10, 0);
        silverSword = new ItemData("Silver Sword", 20, 0, 0);
        goldSword = new ItemData("Gold Sword", 10, 0, 0);

        player.Inventory.Add(ironArmor);
        player.Inventory.Add(goldArmor);
        player.Inventory.Add(silverSword);
        player.Inventory.Add(goldSword);
    }
}
