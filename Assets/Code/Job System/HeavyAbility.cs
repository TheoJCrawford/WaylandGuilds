using UnityEngine;
using System.Collections;
using System;

public class HeavyAbility : BaseAbility
{
    private string _name;
    private int _damage;
    private float _chargeTime;
    private int _unlockLevel;
    private bool _isUnlocked;
    #region S&G
    public int damage
    {
        get{ return _damage;}
        set{_damage = value;}
    }

    public string name
    {
        get{return _name;}
        set{_name = value;}
    }

    public float chargeTime
    {
        get { return _chargeTime; }
        set { _chargeTime = value; }
    }

    public int unlockLevel
    {
        get{return _unlockLevel;}
        set{_unlockLevel = value;}
    }

    public bool isUnlocked
    {
        get{return _isUnlocked;}
        set{_isUnlocked = value;}
    }
    #endregion
    public HeavyAbility()
    {
        _name = "Full Burst";
        _damage = 60;
        _chargeTime = 2.0f;
        _unlockLevel = 10;
        _isUnlocked = false;

    }
}
