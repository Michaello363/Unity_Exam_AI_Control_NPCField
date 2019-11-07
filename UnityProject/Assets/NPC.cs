using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour {

    [Header("對話")]
    public string say = "hello";
    public float sayspeed = 1.5f;
    [Header("任務")]
    public bool Compiete = false;
    public int bateryfinish = 5;
    public int batery = 0;

}
