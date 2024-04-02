using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameEvents
{
    public static UnityEvent PlayerDead = new UnityEvent();
    public static UnityEvent<int> HealPlayer = new UnityEvent<int>();
}
