using UnityEngine;
using System.Collections;

public class Enemy{
    #region 
    private string _name;
    private Sprite _creature;
    private int _health;
    private int _damage;
    private int _armour;
    private int _exp;
    private int _gold;
    #endregion
    #region Setters and Getters
    public string name
    {
        set { _name = value; }
        get { return _name; }
    }
    public int health
    {
        get{ return _health; }
        set{ _health = value; }
    }
    public int damage
    {
        set { _damage = value; }
        get { return _damage; }
    }
    public int armour
    {
        set { _armour = value; }
        get { return _armour; }
    }
    public int exp
    {
        set { _exp = value; }
        get { return _exp; }
    }
    public int gold
    {
        set { _gold = value; }
        get { return _gold; }
    }
    #endregion
    #region
    public Enemy()
    {
        _name = "Psychotic Hampster";
        _health = 100;
        _damage = 10;
        _armour = 1;
        _exp = 5;
        _gold = 10;
    }
    #endregion
    #region Functions
    #endregion
}
