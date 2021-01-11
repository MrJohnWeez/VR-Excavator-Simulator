﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeArmControl : MonoBehaviour
{

    public HingeJoint topHinge;
    public HingeJoint bottomHinge;

    // needs to decrease to extend
    float topHingeMin = -0.3f;
    float topHingeMax = -0.53f;

    // needs to increase to extend
    float bottomHingeMin = 0.3f;
    float bottomHingeMax = 0.53f;

    public float currentTop;
    public float currentBottom;

    public float speed = .5f;

    // Start is called before the first frame update
    void Start()
    {
        currentTop = topHinge.anchor.x;
        currentBottom = bottomHinge.anchor.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Keypad4) && currentTop > topHingeMax && currentBottom < bottomHingeMax)
        {
            IncreaseNumber();
        }
        else if (Input.GetKey(KeyCode.Keypad5) && currentTop < topHingeMin && currentBottom > bottomHingeMin)
        {
            DecreaseNumber();
        }

        topHinge.anchor = new Vector3(currentTop, 0, 0);
        bottomHinge.anchor = new Vector3(currentBottom, 0, 0);

    }

    void IncreaseNumber()
    {
        currentTop -= Time.deltaTime * speed;
        currentBottom += Time.deltaTime * speed;
    }

    void DecreaseNumber()
    {
        currentTop += Time.deltaTime * speed;
        currentBottom -= Time.deltaTime * speed;
    }
}