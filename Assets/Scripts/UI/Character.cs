using UnityEngine;

/* 2025.06.04 오수호 작성
 
 기능 : 캐릭터에 필요한 변수 선언 및 저장 
 
 이름, 설명, 레벨, 경험치, 골드 
 
 
 
 
 
 */

public class CharacterParam
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

    public CharacterParam(string name = "defalut", string description = "변방의 기사", int level = 1, float health = 100, float critical = 10, float gold = 1000,
        float attackPower = 8, float defencePower = 8,float experience = 0)
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
    }
}
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
    }
    
}
