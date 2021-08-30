using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortByPosition : MonoBehaviour
{
    [SerializeField] private int sortingOrderBase = 4000;
    [SerializeField] private int offset;
    private Renderer _renderer;
    [SerializeField] private bool IsHead;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
    }

    private void LateUpdate()
    {
        _renderer.sortingOrder = (int) (sortingOrderBase - transform.position.y - offset);
        if (IsHead)
        {
            _renderer.sortingOrder += 2;
        }
    }
}
