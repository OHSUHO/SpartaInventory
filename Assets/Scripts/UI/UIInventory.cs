using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private GameObject inventoryPanel;
    [SerializeField] private Button inventoryButton;
    [SerializeField] private Transform content;
    [SerializeField] private GameObject slotPrefab;
    [SerializeField] private ScrollRect scrollRect;
    [SerializeField] private TextMeshProUGUI inventoryText;
    private int maxSlotCount = 120;
    private List<UISlot> _slots = new List<UISlot>();
    
    public GameObject InventoryPanel => inventoryPanel;
    public Button InventoryButton => inventoryButton;

    private void Awake()
    {
        InitInventoryUI();
    }
    private void Start()
    {
        inventoryButton.onClick.AddListener(UIManager.Instance.MainMenu.OpenInventory);
    }

    private void InitInventoryUI()
    {
        for (int i = 0; i < maxSlotCount; i++)
        {
            _slots.Add(Instantiate(slotPrefab, content).GetComponent<UISlot>());
        }

        foreach (var item in GameManager.Instance.Player.Inventory)
        {
            FindBlankSlot().SetItem(item);
        }
        inventoryText.SetText($"Inventory: {GameManager.Instance.Player.Inventory.Count} / {maxSlotCount}");
    }

    public UISlot FindBlankSlot()
    {
        foreach (var slot in _slots)
        {
            if (slot.BlankSlot())
            {
                return slot;
            }
        }

        return null;
    }
    
    
    
 
}
