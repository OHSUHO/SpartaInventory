using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "Items/EquipItem")]
public class EquipItem : Item
{
    public EquipItemType equipType;
    public List<(EquipItemStatType,int)> stats = new List<(EquipItemStatType, int)>();
}
