using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    public GameObject lightController;

    private void Start()
    {
        if(lightController == null)
            Debug.Log("LightController is null");
        lightController.SetActive(false);
        StartCoroutine(Light());
    }

    private IEnumerator Light()
    {
        Debug.Log("Coroutine started");
        yield return new WaitForSeconds(3f);
        lightController.SetActive(true);
        Debug.Log("Light on");
    }
}

