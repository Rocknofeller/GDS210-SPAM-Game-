using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CountDownStart : MonoBehaviour
{
    public int countdownTime;
    public Text countdownDisplay;
    public Sprite SpamSprite;

    private void Start()
    {

        StartCoroutine(CountdownToStart());
        
    }

    IEnumerator CountdownToStart()
    {
        while (countdownTime >= 0) 
        {
            ButtonTests.spammable = false;

            countdownDisplay.text = countdownTime.ToString();

            yield return new WaitForSeconds(1f);

            countdownTime--;  

        }

        SpriteRenderer spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = SpamSprite;

        ButtonTests.spammable = true;

        yield return new WaitForSeconds(1f);

        countdownDisplay.gameObject.SetActive(false);

        spriteRenderer.gameObject.SetActive(false);

    }
}
