using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonTests : MonoBehaviour
{
    private bool spammable = false;
    private float oneProgress = 0;
    private float twoProgress = 0;
    public GameObject progOne;
    public GameObject progTwo;
    public GameObject winnerText;
    private string defText;
    public GameObject p1Text;
    public GameObject p2Text;
    private int p1Point = 0;
    private int p2Point = 0;


    // Start is called before the first frame update
    void Start()
    {
        defText = winnerText.GetComponent<Text>().text;

        RoundStart();
    }

    // Update is called once per frame
    void Update()
    {
        if (spammable == true) ButtonInputs();
        
        //These two lines updates the bar
        progOne.GetComponent<Image>().fillAmount = oneProgress;
        progTwo.GetComponent<Image>().fillAmount = twoProgress;

        Winner();
    }

    void RoundStart()
    {
        //Resets it the progress bars to 0
        //set it seperate to start so it can be reused to reset
        //resets the mid text as well, will replace to SPAM!

        spammable = true;

        progOne.GetComponent<Image>().fillAmount = 0;
        progTwo.GetComponent<Image>().fillAmount = 0;
        oneProgress = 0;
        twoProgress = 0;
        winnerText.GetComponent<Text>().text = defText;
    }

    void ButtonInputs()
    {
        //Player 1 can use all of WASD
        //Probably need to find a more efficient way to write these down
        //inputs are determined in Edit>ProjectSettings>InputManager
        //this way the inputs aren't locked to WASD and/or arrow keys
        //Definitely need to find a more efficient way to write this down and change it on the fly

        if (Input.GetButtonDown("p1Up") | Input.GetButtonDown("p1Down") | Input.GetButtonDown("p1Left") | Input.GetButtonDown("p1Right"))
        {
            oneProgress += 0.01f;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            twoProgress += 0.01f;
        }

    }

    void Winner()
    {
        //victory conditions
        //Also stops the loser's progress bar
        //stops spamming entirely
        if (oneProgress >= 1 && spammable == true)
        {
            p1Point += 1;
            // print("Player 1 Wins");
            winnerText.GetComponent<Text>().text = "Player 1 Wins\n Press Space to Reset";
            StringChange();
            spammable = false;
        }
        else if (twoProgress >= 1 && spammable == true)
        {
            p2Point += 1;
            // print("Player 2 Wins");
            winnerText.GetComponent<Text>().text = "Player 2 Wins\n Press Space to Reset";
            StringChange();
            spammable = false;
        }

        //little code to reset the script and the round

        if (Input.GetKeyDown(KeyCode.Space) && spammable == false)
        {
            print("round reset");
            RoundStart();
        }

    }

    void StringChange()
    {
        string p1String = p1Point.ToString();
        string p2String = p1Point.ToString();
        p1Text.GetComponent<Text>().text = p1String;
        p1Text.GetComponent<Text>().text = p2String;
    }
}
