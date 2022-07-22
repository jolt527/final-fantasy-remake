using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewPlayerUnit", menuName = "Final Fantasy/New Player Unit")]
public class PlayerUnitBase : ScriptableObject {

    [SerializeField] int hp;
    [SerializeField] int strength;
    [SerializeField] int agility;
    [SerializeField] int intelligence;
    [SerializeField] int vitality;
    [SerializeField] int luck;
    [SerializeField] int hitPercent;
    [SerializeField] int magicDefense;

    [SerializeField] Sprite battleSpriteStanding;
    [SerializeField] Sprite unitActionQueueSprite;

    [SerializeField] List<BattleMenuCommand> battleMenuCommands;

    public int Hp => hp;

    public Sprite BattleSpriteStanding => battleSpriteStanding;
    public Sprite UnitActionQueueSprite => unitActionQueueSprite;

    public List<BattleMenuCommand> BattleMenuCommands => battleMenuCommands;
}
