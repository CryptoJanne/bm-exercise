using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    [SerializeField]private float _time;
    private void Start()
    {
        StartCoroutine(DestructTimer(_time));
    }

    private IEnumerator DestructTimer(float time)
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }
}

