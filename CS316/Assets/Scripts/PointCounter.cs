﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointCounter : MonoBehaviour
{
    public Text pointScoreCounter;

    public int score = 0;

    // Update is called once per frame
    void Update()
    {
        pointScoreCounter.text = "Score: " + score;
    }
}
