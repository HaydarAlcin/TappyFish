using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Medal : MonoBehaviour
{
    public Sprite bronzeMedal, goldMedal, silverMedal,metalMedal;

    Image img;
    void Start()
    {
        img = GetComponent<Image>();

        int gameScore = GameManager.gameScore;

        if (gameScore>0&& gameScore<=1)
        {
            img.sprite = metalMedal;
        }

        else if (gameScore > 1 && gameScore <= 5)
        {
            img.sprite = bronzeMedal;
        }

        else if (gameScore > 5 && gameScore <= 10)
        {
            img.sprite = silverMedal;
        }

        else if (gameScore > 10 && gameScore <= 15)
        {
            img.sprite = goldMedal;
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
