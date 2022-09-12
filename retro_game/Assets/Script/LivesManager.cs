using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesManager : MonoBehaviour
{
    public int defaultLives;
    public int livesCounter;

    public Text livesText;

    private GameManager theGM;


    // Start is called before the first frame update
    void Start()
    {
        livesCounter = defaultLives;

        theGM = FindObjectOfType<GameManager>();


    }

    // Update is called once per frame
    void Update()
    {
        livesText.text = "x " + livesCounter;

        if (livesCounter < 1) {
            theGM.GameOver();
        }
    }

    public void TakeLife() {
        livesCounter--;
    }

    public void AddLife() {
        livesCounter++;
    }
}
