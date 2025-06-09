using UnityEngine;

public class GameManager : SingleTon<GameManager>
{
    private Character _player;
    public Character Player { get => _player; private set => _player = value; }
    [SerializeField] private CharacterParam playerParam;
    

    public override void Awake()
    {
        base.Awake();
        Player = new Character(playerParam);
    }

}
