using System.Collections;
using System.Collections.Generic;
using Daedalus.Core;
using UnityEngine;

public class WorldController : MonoBehaviour
{
    public RoomMapping Map;



    [ContextMenu("Reset Map")]
    void ResetMap()
    {
        Map.Reset();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.P))
        {
            Debug.Break();
        }
    }
}
