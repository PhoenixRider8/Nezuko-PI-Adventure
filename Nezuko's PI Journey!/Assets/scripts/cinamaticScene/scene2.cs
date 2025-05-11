using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scene2 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] PlayerMovement play;
    [SerializeField] Camera cam;
    [SerializeField] GameObject cam2;

    [SerializeField] NezukoNav nav;

    bool hasEnded;
    void Start()
    {
        hasEnded = false;
        cam.gameObject.SetActive(false);
        nav.disableMovement();
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
            //play.startGame();
        }
    }

    IEnumerator waitTime()
    {
        yield return new WaitForSeconds(3);
        hasEnded = true;
        gameObject.SetActive(false);
        cam2.SetActive(true);
        //play.startGame();
    }
}
