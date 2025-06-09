using UnityEngine;

public class UIManager : SingleTon<UIManager>
{
    [SerializeField] private UIMainMenu mainMenu;
    [SerializeField] private UIInventory uiInventory;
    [SerializeField] private UIStatus uiStatus;
    
    public UIMainMenu MainMenu => mainMenu;
    public UIInventory UIInventory => uiInventory;
    public UIStatus UIStatus => uiStatus;
    

}
