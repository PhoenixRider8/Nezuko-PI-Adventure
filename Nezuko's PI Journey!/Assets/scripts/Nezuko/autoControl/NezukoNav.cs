using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class NezukoNav : MonoBehaviour
{
    GameObject target;
    [SerializeField] List<GameObject> targets;
    [SerializeField] GameObject Options;
    [SerializeField] Text PIVal;

    [SerializeField] PlayerMovement nezukoMove;
    [SerializeField] PlayerLook nezukoLook;
    
    void Start()
    {
        Options.SetActive(false);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name=="C1")
        {
            print("Checkpoint 1");
            Options.SetActive(true);
            PIVal.gameObject.SetActive(false);

            disableMovement();
        }

        if (other.gameObject.name == "C2")
        {
            print("Checkpoint 2");
            Options.SetActive(true);
            PIVal.gameObject.SetActive(false);

            disableMovement();
        }

        if (other.gameObject.name == "C3")
        {
            print("Checkpoint 3");
            Options.SetActive(true);
            PIVal.gameObject.SetActive(false);

            disableMovement();
        }

        if (other.gameObject.name == "C4")
        {
            print("Checkpoint 4");
            Options.SetActive(true);
            PIVal.gameObject.SetActive(false);

            disableMovement();
        }

        if (other.gameObject.name == "C5")
        {
            print("Checkpoint 5");
            Options.SetActive(true);
            PIVal.gameObject.SetActive(false);

            disableMovement();
        }
    }

    public void resetCanva()
    {
        Options.SetActive(false);
        PIVal.gameObject.SetActive(true);
        MazeManager.nextCheckPoint = true;
        enableMovement();

        targets[MazeManager.GameIndex].gameObject.SetActive(false); //set inactive
        MazeManager.GameIndex += 1; //increment gameindex
    }


    public void disableMovement()
    {
        nezukoMove.speed = 0;
        nezukoLook.ySen = 0;
        nezukoLook.xSen = 0;
    }

    public void enableMovement()
    {
        nezukoMove.speed = 5;
        nezukoLook.ySen = 30;
        nezukoLook.xSen = 30;

        
        
    }
}
