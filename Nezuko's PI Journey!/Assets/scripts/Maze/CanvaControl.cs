using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvaControl : MonoBehaviour
{
    [SerializeField] public Text PI;
    public string targetPI;
    public List<int> digits;
    int index;
    void Start()
    {
        PI.text = "PI = 3._ _ _ _ _";
        digits = new List<int>();
        initializseDigits();
    }

    // Update is called once per frame
    void Update()
    {
        index = MazeManager.GameIndex;   
        setTextCanva(index);
    }

    void initializseDigits()
    {
        digits.Add(1);
        digits.Add(4);
        digits.Add(1);
        digits.Add(5);
        digits.Add(9);
    }

    public void setTextCanva(int GameIndex)
    {
        if (GameIndex == 0)
        {
            PI.text = "PI = 3._ _ _ _ _";
        }
        if (GameIndex==1)
        {
            PI.text = "PI = 3.1 _ _ _ _";
        }
        if (GameIndex == 2)
        {
            PI.text = "PI = 3.1 4 _ _ _";
        }
        if (GameIndex == 3)
        {
            PI.text = "PI = 3.1 4 1 _ _";
        }
        if (GameIndex == 4)
        {
            PI.text = "PI = 3.1 4 1 5 _";
        }
        if (GameIndex == 5)
        {
            PI.text = "PI = 3.1 4 1 5 9";
            targetPI = "PI = 3.1 4 1 5 9";
        }

    }
}
