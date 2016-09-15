using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class Job : MonoBehaviour {

    private string _name;
    private Sprite _icon;
    private List<LightAbility> _lightAbil;
    private List<HeavyAbility> _heavyAbil;

    public Job()
    {
        _name = string.Empty;
        _icon = new Sprite();
        _lightAbil = new List<LightAbility>();
        _heavyAbil = new List<HeavyAbility>();
    }
}
