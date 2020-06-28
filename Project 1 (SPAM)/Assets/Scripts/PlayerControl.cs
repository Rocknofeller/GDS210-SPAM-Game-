using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{
    private SpriteRenderer SRender;

    [Header("Assign Sprite Button")]
    public Sprite defaultImage;
    public Sprite pressedImage;
    
    [Space(5)]

    public KeyCode keyToPress;

    // Start is called before the first frame update
    void Start()
    {
        SRender = GetComponent<SpriteRenderer>();
    }
    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(keyToPress))
        {
            SRender.sprite = pressedImage;
        }

        if (Input.GetKeyUp(keyToPress))
        {
            SRender.sprite = defaultImage;
        }
    
    }
}
