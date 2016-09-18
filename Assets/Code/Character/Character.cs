using UnityEngine;
using System.Collections;

public class Character{
    #region Variables
    private string _name;
    private bool _gender;
    private int _level;
    private int _expToLevel;
    private Job _job;
    private int _curLight;
    private int _curHeavy;
    #endregion
    #region Setters and Getters
    public string name
    {
        get { return _name; }
        set { _name = value; }
    }
    public bool gender
    {
        get { return _gender; }
        set { _gender = value; }
    }
    public int lvl
    {
        get { return _level; }
        set { _level = value; }
    }
    public int expToLvl
    {
        get { return _expToLevel; }
        set { _expToLevel = value; }
    }
    public Job job{
        get { return _job; }
        set { _job = value; }
    }
    public int curLightMove
    {
        get { return _curLight; }
        set { _curLight = value; }
    }
    #endregion
    #region Constructors
    public Character()
    {
        _name = "Regis";
        _gender = true;
        _level = 1;
        _expToLevel = 100;
        _job = new Job();
        _curLight = 0;
        _curHeavy = 0;

    }
    #endregion
    #region Functions
    public void AddExp(int Exp)
    {
        _expToLevel -= Exp;
        if(_expToLevel < 0)
        {
            LevelUp();
        }
    }
    public void LevelUp()
    {
        _level++;
        _expToLevel = _level * 100;
    }
    #endregion
}

