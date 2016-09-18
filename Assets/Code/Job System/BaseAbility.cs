using UnityEngine;
using System.Collections;

public interface BaseAbility {
    string name { get; set; }
    int unlockLevel { get; set; }
    bool isUnlocked { get; set; }
    int damage { get; set; }
}
