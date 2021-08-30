using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCamera : MonoBehaviour
{
    [SerializeField] private float speed = 15f;
    //public float minDistance;
    [SerializeField] private GameObject target;
    [SerializeField] private Vector3 offset;

    private Vector3 targetPos;
    
    void Start () {
        targetPos = transform.position;
    }
    
    void FixedUpdate () 
    {
        if (target)
        {
            Vector3 posNoZ = transform.position + offset;
            Vector3 targetDirection = (target.transform.position - posNoZ);
            float interpVelocity = targetDirection.magnitude * speed;
            targetPos = (transform.position) + (targetDirection.normalized * interpVelocity * Time.deltaTime); 
            transform.position = Vector3.Lerp( transform.position, targetPos, 0.25f);

        }
    }
}
