using System.Collections.Generic;
using System.Globalization;
using System.Text;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public enum UIState
{
   MainMenu,
   Status,
   Inventory
}
public class UIMainMenu : MonoBehaviour
{
   [SerializeField] private Button backButton;
   [SerializeField] private GameObject mainMenu;
   [SerializeField] private TextMeshProUGUI playerNameText;
   [SerializeField] private TextMeshProUGUI playerLevelText;
   [SerializeField] private TextMeshProUGUI playerExpText;
   [SerializeField] private TextMeshProUGUI playerGoldText;
   [SerializeField] private TextMeshProUGUI playerDescText;
   public Button BackButton => backButton;
   public Dictionary<UIState,GameObject> uiStates = new Dictionary<UIState,GameObject>();



   private void Start()
   {
      BackButton.onClick.AddListener(UIManager.Instance.MainMenu.OpenMainMenu);
      uiStates.Add(UIState.MainMenu,mainMenu);
      uiStates.Add(UIState.Inventory,UIManager.Instance.UIInventory.InventoryPanel);
      uiStates.Add(UIState.Status,UIManager.Instance.UIStatus.StatusPanel);
      SetMainUI();
   }

  

   private void SetMainUI()
   {
      playerNameText.SetText(GameManager.Instance.Player.CharacterName);
      playerLevelText.SetText($"Lv. {GameManager.Instance.Player.Level}");
      playerExpText.SetText($"{GameManager.Instance.Player.CurrentExp} / {GameManager.Instance.Player.MaxExp}");
      playerGoldText.SetText($"Gold : {GameManager.Instance.Player.Gold}");
      playerDescText.SetText(GameManager.Instance.Player.Description);
      
   }

   public void OpenMainMenu()
   {
      foreach (var kvp in uiStates)
      {
         kvp.Value.SetActive(kvp.Key == UIState.MainMenu);
      }
      backButton.gameObject.SetActive(false);
   }

   public void OpenStatus()
   {
      foreach (var kvp in uiStates)
      {
         kvp.Value.SetActive(kvp.Key == UIState.Status);
      }
      backButton.gameObject.SetActive(true);
      
   }

   public void OpenInventory()
   {
      foreach (var kvp in uiStates)
      {
         kvp.Value.SetActive(kvp.Key == UIState.Inventory);
      }
      backButton.gameObject.SetActive(true);
      
   }
   
      
   
}
