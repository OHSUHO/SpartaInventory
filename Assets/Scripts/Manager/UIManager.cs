using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : SingleTon<UIManager>
{
    [SerializeField] UIMainMenu mainMenu;
    [SerializeField] UIInventory uiInventory;
    [SerializeField] UIStatus status;

}
