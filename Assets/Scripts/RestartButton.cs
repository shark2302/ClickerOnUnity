using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartButton : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnDisable()
    {
        gameObject.SetActive(true);
    }
}
