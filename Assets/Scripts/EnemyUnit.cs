using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyUnit {

    private EnemyUnitBase unitBase;
    private int currentHp;
    private int maxHp;

    public EnemyUnitBase Base => unitBase;
    public int MaxHp => maxHp;
    public int CurrentHp => currentHp;

    public EnemyUnit(EnemyUnitBase unitBase) {
        this.unitBase = unitBase;
        maxHp = unitBase.Hp;
        currentHp = maxHp;
    }
}
