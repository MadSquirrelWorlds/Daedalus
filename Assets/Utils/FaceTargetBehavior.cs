using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceTargetBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction_to_model = target.transform.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(direction_to_model, Vector3.up);
        transform.rotation = rotation;
    }
}
