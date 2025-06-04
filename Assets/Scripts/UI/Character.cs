using UnityEngine;

/* 2025.06.04 오수호 작성
 
 기능 : 캐릭터에 필요한 변수 선언 및 저장 
 
 이름, 설명, 레벨, 경험치, 골드 
 
 
 
 
 
 */
public class Character : MonoBehaviour
{
    public string characterName;
    public string description;
    public int level;
    public float exp;
    public float gold;

    public Character(string name, string description, int level, float exp, float gold)
    {
        characterName = name;
        this.description = description;
        this.level = level;
        this.exp = exp;
        this.gold = gold;
    }
    
    
    
}
