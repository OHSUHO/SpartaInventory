using System;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    public Image itemIcon;
    public Image equipCheckImage;
    private Item item;
    public Item Item { get=> item; private set=>item = value; }

    public void EquipButton()
    {
        if (item != null && item.itemType == ItemType.Equipment)
        {
            equipCheckImage.enabled = GameManager.Instance.Player.EquipItem((EquipItem)item);
        }
    }
    public void SetItem(Item newItem)
    {
        item = newItem;
        RefreshUI();
    }

    public bool BlankSlot()
    {
        if (item == null) return true;
        return false;
    }

    private void RefreshUI()
    {
        itemIcon.sprite = item.itemIcon;
    }
}
