using System.Collections.Generic;
using UnityEngine;

public class CharacterParam : MonoBehaviour
{
    public string Name;
    public string Description;
    public int Level;
    public float Experience;
    public float Gold;
    public float AttackPower;
    public float DefencePower;
    public float Health;
    public float Critical;
    public List<Item> Inventory;

    public CharacterParam(string name = "defalut", string description = "변방의 기사", int level = 1, float health = 100, float critical = 10, float gold = 1000,
        float attackPower = 8, float defencePower = 8,float experience = 0, List<Item> items = null)
    {
        Name = name;
        Description = description;
        Level = level;
        Experience = experience;
        Gold = gold;
        AttackPower = attackPower;
        DefencePower = defencePower;
        Health = health;
        Critical = critical;
        Inventory = items;
    }
}
