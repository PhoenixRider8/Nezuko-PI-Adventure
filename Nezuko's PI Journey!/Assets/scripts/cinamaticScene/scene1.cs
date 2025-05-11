using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scene1 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] PlayerMovement play;
    [SerializeField] Camera cam;
    [SerializeField] GameObject cam2;
    [SerializeField] GameObject cam3;

    [SerializeField] NezukoNav nav;

    bool hasEnded;
    void Start()
    {
        hasEnded = false;
        cam.gameObject.SetActive(false);
        cam2.SetActive(false);
        cam3.SetActive(false);
        nav.disableMovement();
    }

    // Update is called once per frame
    void Update()
    {
        if(!hasEnded)
        {
            StartCoroutine(waitTime());
        }
        else
        {
            
        }
    }

    IEnumerator waitTime()
    {
        yield return new WaitForSeconds(3);
        hasEnded = true;
        gameObject.SetActive(false);

        cam2.SetActive(true);
        MazeManager.GameIndex = 0;
    }


}
