using UnityEngine;
using Unity.VisualScripting;
public enum EquipItemStatType
{
    Health,
    Critical,
    Attack,
    Defence,
}

public enum EquipItemType
{
    Armor,
    Weapon,
    Accessory,
}

public enum ItemType
{
    Consumable,
    Equipment,
}

[CreateAssetMenu (menuName = "Items/Item")]
public class Item : ScriptableObject
{
    public Sprite itemIcon;
    public string itemName;
    public string itemDescription;
    public ItemType itemType;

    private void Awake()
    {
        if (itemIcon == null)
        {
            Resources.Load<Sprite>($"{itemName}_Icon");
        }
    }
    
}
