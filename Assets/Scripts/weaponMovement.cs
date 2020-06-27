using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using UnityEngine.UIElements;

public class weaponMovement : MonoBehaviour
{
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

       transform.localPosition = new Vector3(0f, Mathf.Lerp(3f, 5f, 0.000005f));
      
    }

    void Update()
    {
        Debug.Log(Mathf.Lerp(3f, 5f, 0.00000005f* Time.deltaTime));
    }
}
