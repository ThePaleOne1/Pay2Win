using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigerable : MonoBehaviour
{
    //universal script to give any object a "IsTriggered" bool
    //this means whenever i need to trigger something from a switch, or a lever
    //instead of doing if(GameObject == Door) if(GameObject == Elevator)
    public bool IsTriggered = false;
}
