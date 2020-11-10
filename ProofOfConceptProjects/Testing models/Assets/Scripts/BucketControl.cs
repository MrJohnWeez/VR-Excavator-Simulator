﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BucketControl : MonoBehaviour
{

    public HingeJoint topHinge;
    public HingeJoint bottomHinge;

    // needs to decrease to extend
    float topHingeMin = -0.45f;
    float topHingeMax = -0.58f;

    // needs to increase to extend
    float bottomHingeMin = 0.45f;
    float bottomHingeMax = 0.58f;

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
        if (Input.GetKey(KeyCode.Keypad7) && currentTop > topHingeMax && currentBottom < bottomHingeMax)
        {
            IncreaseNumber();
        }
        else if (Input.GetKey(KeyCode.Keypad8) && currentTop < topHingeMin && currentBottom > bottomHingeMin)
        {
            DecreaseNumber();
        }

        topHinge.anchor = new Vector3(currentTop,0,0);
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
