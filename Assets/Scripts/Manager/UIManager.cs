using System;
using UnityEngine;

public class UIManager : SingleTon<UIManager>
{
    [SerializeField] private UIMainMenu mainMenu;
    [SerializeField] private UIInventory uiInven;
    [SerializeField] private UIStatus uiStat;
    
    public UIMainMenu MainMenu => mainMenu;
    public UIInventory UIInven => uiInven;
    public UIStatus UIStat => uiStat;

 
}
