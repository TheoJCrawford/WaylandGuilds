using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class Floor : MonoBehaviour {

    private int _foor;
    private int _difficulty;
    private List<Enemy> _enemies;

    public int floor
    {
        set { _foor = value; }
        get { return _foor; }
    }
    public int difficulty
    {
        set { _difficulty = value; }
        get { return _difficulty; }
    }
    public List<Enemy> enemies
    {
        set { _enemies = value; }
        get { return _enemies; }
    }
    public Floor()
    {
        _foor = 0;
        _difficulty = 1;
        _enemies = new List<Enemy>();
    }
}
