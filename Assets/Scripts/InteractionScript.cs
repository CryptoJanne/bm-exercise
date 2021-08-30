using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionScript : MonoBehaviour
{
    private GameObject closeObject;
    [SerializeField] private GameObject interactText;
    [SerializeField] private GameObject chatbubble;
    [SerializeField] private Vector3 offset;
    private void Update()
    {
        if (closeObject)
        {
            interactText.SetActive(true);
            if (Input.GetKeyDown(KeyCode.F))
            {
                Instantiate(chatbubble, closeObject.transform.position + offset, Quaternion.identity);
            }
        }
        else
        {
            interactText.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "NPC")
        {
            closeObject = other.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "NPC")
        {
            closeObject = null;
        }
    }
}
