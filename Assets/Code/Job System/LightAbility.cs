using UnityEngine;
using System.Collections;
using System;

public class LightAbility : BaseAbility
{
    private int _damage;
    private string _name;
    private int _unlockLevel;
    public int damage
    {
        get{return _damage;}
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

    public LightAbility()
    {
        _damage = 5;
        _name = "Attack";
        _unlockLevel = 1;
    }
}
