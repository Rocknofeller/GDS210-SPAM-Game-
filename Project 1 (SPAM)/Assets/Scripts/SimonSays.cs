using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimonSays : MonoBehaviour
{

    public GameObject progressBar;
    public GameObject canvasLink;
    bool correctPress;
    bool wrongPress;
    public GameObject[] simonSays;
    private GameObject simon;
    public GameObject simonHolder;
    int lastNum = 4;
    int tempNum = 4;
    

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {

       if (canvasLink.GetComponent<CountDownStart>().countdownTime == 0)
        {
            ButtonDelete();
            ButtonRandom();
        }
        CorrectPress();
    }


    //make buttons appear
    //check button press
    //check if button press is correct
    //if correct progress bar by 5
    //if not correct, minus bar by 1 for each wrong button

    void ButtonRandom()
    {
        ButtonDelete();
        int newNum = Random.Range(0, 4);
        while (newNum == lastNum)
        {
            newNum = Random.Range(0, 4);
        }
        //Debug.Log(newNum);
        lastNum = newNum;
        simon = Instantiate(simonSays[newNum]);
        simon.transform.SetParent(simonHolder.transform, false);
        tempNum = newNum;
       // Debug.Log(tempNum);
    }

    void ButtonDelete()
    {
        Destroy(simon);
    }

    void CorrectPress()
    {
        if (Input.GetKeyDown(KeyCode.A) && (tempNum == 2))
        {
           // Debug.Log("Left Correct");
            ButtonDelete();
            ButtonRandom();
            

        }
        if (Input.GetKeyDown(KeyCode.D) && (tempNum == 3))
        {
           // Debug.Log("Right Correct");
            ButtonDelete();
            ButtonRandom();
            

        }
        if (Input.GetKeyDown(KeyCode.W) && (tempNum == 0))
        {
           // Debug.Log("Up Correct");
            ButtonDelete();
            ButtonRandom();
            
        }
        if (Input.GetKeyDown(KeyCode.S) && (tempNum == 1))
        {
           // Debug.Log("Down Correct");
            ButtonDelete();
            ButtonRandom();
            

        }
        else
        {
            Debug.Log("Wrong Button");
        }
    }
}
