using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CheckPointManager : MonoBehaviour
{
    int currIndex;
    [SerializeField] CanvaControl control;

    [SerializeField] Text text1;
    [SerializeField] Text text2;
    [SerializeField] Text hint;

    [SerializeField] NezukoNav nav;

    [SerializeField] RawImage no_pie;
    [SerializeField] RawImage win_pie;

    private void Start()
    {
        no_pie.gameObject.SetActive(false);
        win_pie.gameObject.SetActive(false);
    }
    private void Update()
    {
        string txt = control.targetPI;
        if(txt == "PI = 3.1 4 1 5 9")
        {
            StartCoroutine(waitTime2());
            winPI();
        }
        else
        textUpdate();
    }
    public void checkPoint1()
    {
        currIndex = MazeManager.GameIndex;
       /* if (currIndex == 1 || currIndex == 3)
        {
            MazeManager.nextCheckPoint = true;
            control.setTextCanva(currIndex);
            MazeManager.GameIndex += 1;
        }*/

        nav.resetCanva();
    }

    public void winPI()
    {
        StartCoroutine(waitTime()); //load scene
    }

    public void lostPoint()
    {
        print("YOU LOOSE");
        StartCoroutine(waitTime3());
        nav.resetCanva();
        StartCoroutine(waitTime());
    }

    void textUpdate()
    {
        if (MazeManager.GameIndex == 0)
        {
            text1.text = "1";
            text2.text = "3";
            hint.text = "Hint: I am the start of it all, standing alone, \nyet I’m often the winner in a race. What am I?";
        }

        if (MazeManager.GameIndex == 1)
        {
            text1.text = "4";
            text2.text = "5";
            hint.text = "Hint: I have four corners, but no edges to bend. \nI’m the foundation, and I help things extend. What am I?";
        }

        if (MazeManager.GameIndex == 2)
        {
            text1.text = "1";
            text2.text = "7";
            hint.text = "In every list, I lead the way. \nWhat number am I?";
        }

        if (MazeManager.GameIndex == 3)
        {
            text1.text = "5";
            text2.text = "9";
            hint.text = "Five fingers you have, as you know. \nWhat number am I?";
        }

        if (MazeManager.GameIndex == 4)
        {
            text1.text = "9";
            text2.text = "6";
            hint.text = "If you flip me over, I look like a 6 in the sky. \nWhat number am I?";
        }
    }


    //Wait Time(s)
    IEnumerator waitTime()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(0);
    }

    IEnumerator waitTime2()
    {
        win_pie.gameObject.SetActive(true);
        yield return new WaitForSeconds(3);
    }

    IEnumerator waitTime3()
    {
        no_pie.gameObject.SetActive(true);
        yield return new WaitForSeconds(3);
        
    }
}
