using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scene3 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] PlayerMovement play;
    [SerializeField] Camera cam;
    [SerializeField] NezukoNav nav;

    bool hasEnded;
    void Start()
    {
        hasEnded = false;
        nav.disableMovement();
        //cam.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasEnded)
        {
            StartCoroutine(waitTime());
        }
        else
        {
            play.startGame();
        }
    }

    IEnumerator waitTime()
    {
        yield return new WaitForSeconds(3);
        hasEnded = true;
        
        cam.gameObject.SetActive(true);
        gameObject.SetActive(false);
        play.startGame();
        nav.enableMovement();
        MazeManager.GameIndex = 0;
    }
}
