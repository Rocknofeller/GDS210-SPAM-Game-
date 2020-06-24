using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonTests : MonoBehaviour
{
    public float oneProgress = 0;
    public float twoProgress = 0;
    public GameObject progOne;
    public GameObject progTwo;
    

    // Start is called before the first frame update
    void Start()
    {
        progOne.GetComponent<Image>().fillAmount = 0;
        progTwo.GetComponent<Image>().fillAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.W))
        {
            oneProgress += 0.01f;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            twoProgress += 0.01f;
        }


        progOne.GetComponent<Image>().fillAmount = oneProgress;

        progTwo.GetComponent<Image>().fillAmount = twoProgress;

    }
}
