using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class MazeManager : MonoBehaviour
{
    public static bool isAtCheckPoint;
    public static bool nextCheckPoint;

    public static int GameIndex;
    //bool alreadyIndexed;
    void Start()
    {
        isAtCheckPoint = false;
        //alreadyIndexed = false;
        nextCheckPoint = false;
        GameIndex = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
