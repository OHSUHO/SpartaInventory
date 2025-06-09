public class GameManager : SingleTon<GameManager>
{
    private Character _player;
    public Character Player { get => _player; private set => _player = value; }

    public override void Awake()
    {
        base.Awake();
        Player = new Character(new CharacterParam(
            name : "Suho",
            description: "매 주 게임을 개발하는 개발자이다.",
            level : 1,
            health : 100,
            critical : 10,
            experience : 0,
            gold : 1000,
            attackPower: 8,
            defencePower: 8));
    }

}
