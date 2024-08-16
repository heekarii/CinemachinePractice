using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSystem : MonoBehaviour
{
    public ParticleSystem RfireSystem;
    public ParticleSystem LfireSystem;
    [SerializeField] private bool isFire = false;

    private void Start()
    {
        StartCoroutine(FireRoutine());
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && !isFire)
        {
            if (RfireSystem != null)
            {
                RfireSystem.Play();
            }
            if (LfireSystem != null)
            {
                LfireSystem.Play();
            }
            isFire = true;
        }
        else if (Input.GetKeyDown(KeyCode.F) && isFire)
        {
            if (RfireSystem != null)
            {
                RfireSystem.Stop();
            }
            if (LfireSystem != null)
            {
                LfireSystem.Stop();
            }
            isFire = false;
        }
    }

    IEnumerator FireRoutine()
    {
        yield return new WaitForSeconds(3f);
        RfireSystem.Play();
        LfireSystem.Play();
        yield return new WaitForSeconds(2f);
        RfireSystem.Stop();
        LfireSystem.Stop();
    }
}
