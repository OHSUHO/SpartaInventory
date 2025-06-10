using System;
using System.Collections.Generic;
using UnityEngine;

/* 2025.06.04 오수호 작성
 
 기능 : 캐릭터에 필요한 변수 선언 및 저장 
 
 이름, 설명, 레벨, 경험치, 골드 
 
 */


public class Character
{
    private string _characterName;
    private string _description;
    private int _level;
    private float _currentExp;
    private float _maxExp;
    private float _gold;
    private float _attackPower;
    private float _defencePower;
    private float _health;
    private float _critical;

    public string CharacterName { get => _characterName;
        private set => _characterName = value;
    }
    public string Description { get => _description;
        private set => _description = value;
    }
    public int Level { get => _level; private set => _level = value; }
    public float CurrentExp { get => _currentExp; private set => _currentExp = value; }
    public float MaxExp { get => _maxExp;
        private set => _maxExp = value;
    }
    public float Gold { get => _gold; private set => _gold = value; }
    public float AttackPower { get => _attackPower;
        private set => _attackPower = value;
    }
    public float DefencePower { get => _defencePower; private set => _defencePower = value; }
    public float Health { get => _health; private set => _health = value; }
    public float Critical { get => _critical; private set => _critical = value; }
    
    public List<Item> Inventory { get; private set;} = new List<Item>();
    public List<EquipItem> EquippedItems { get; private set; } = new List<EquipItem>();

    public Action EquipedAction;

    public Character(CharacterParam param)
    {
        _characterName = param.Name;
        _description = param.Description;
        _level = param.Level;
        _currentExp = param.Experience;
        _gold = param.Gold;
        _maxExp = param.Level * 5;
        _attackPower = param.AttackPower;
        _defencePower = param.DefencePower;
        _health = param.Health;
        _critical = param.Critical;
        foreach (Item item in param.Inventory)
        {
            AddItem(item);
        }
    }

    public void AddItem(Item item)
    {
        Inventory.Add(item);
    }

    public bool EquipItem(EquipItem item)
    {
        if (!EquippedItems.Contains(item))
        {
            EquippedItems.Add(item);
            foreach (var stat in item.stats)
            {
                switch (stat.statType)
                {   
                    case EquipItemStatType.Attack : _attackPower += stat.statValue;
                        break;
                    case EquipItemStatType.Defence : _defencePower += stat.statValue;
                        break;
                    case EquipItemStatType.Health : _health += stat.statValue;
                        break;
                    case EquipItemStatType.Critical : _critical += stat.statValue;
                        break;
                }
            EquipedAction?.Invoke();
            }

            return true;
        }
        else
        {
            UnequipItem(item);
            return false;
        }
    }

    public void UnequipItem(EquipItem item)
    {
        if (EquippedItems.Contains(item))
        {
        EquippedItems.Remove(item);
        foreach (var stat in item.stats)
        {
            switch (stat.statType)
            {
                case EquipItemStatType.Attack:
                    _attackPower -= stat.statValue;
                    break;
                case EquipItemStatType.Defence:
                    _defencePower -= stat.statValue;
                    break;
                case EquipItemStatType.Health:
                    _health -= stat.statValue;
                    break;
                case EquipItemStatType.Critical:
                    _critical -= stat.statValue;
                    break;
            }
        }
        EquipedAction?.Invoke();
            
        }
        
    }

}
