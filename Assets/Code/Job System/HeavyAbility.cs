using UnityEngine;
using System.Collections;
using System;

public class HeavyAbility : BaseAbility
{
    private string _name;
    private int _damage;
    private int _unlockLevel;

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

    public int unlockLevel
    {
        get{return _unlockLevel;}
        set{_unlockLevel = value;}
    }

    public HeavyAbility()
    {

    }
}
