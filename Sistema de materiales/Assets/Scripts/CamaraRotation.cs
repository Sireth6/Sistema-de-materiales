﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraRotation : MonoBehaviour
{
    public float speed = 5;

    // Update is called once per frame
    void Update()
    {
      if(Input.GetMouseButton(0))
        {
            transform.eulerAngles += speed * new Vector3(-Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0);


        }
    }
}
