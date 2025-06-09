using System.Collections.Generic;
using System.Linq;
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

    private void Start()
    {
        inventoryButton.onClick.AddListener(UIManager.Instance.MainMenu.OpenInventory);
        Debug.Log(scrollRect.normalizedPosition);
        InitInventoryUI();
    }

    private void InitInventoryUI()
    {
        for (int i = 0; i < maxSlotCount; i++)
        {
            _slots.Add(Instantiate(slotPrefab, content).GetComponent<UISlot>());
        }
    }
 
}
