﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPoup : MonoBehaviour
{
    public void Open()
    {
        gameObject.SetActive(true);
    }

    public void Close()
    {
        gameObject.SetActive(false);
    }
}
