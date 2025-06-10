using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "Items/EquipItem")]
public class EquipItem : Item
{
    public EquipItemType equipType;

    [System.Serializable]
    public class StatChange
    {
        public EquipItemStatType statType;
        public int statValue;
    }
    public List<StatChange> stats = new List<StatChange>();
    
}
