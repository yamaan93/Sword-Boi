using System.Collections;
using System.Collections.Generic;
using System.Timers;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UIElements;

public class weaponMovement : MonoBehaviour
{

    public float t = 0.0f;//interpolation value 
    private float weaponX;
    private float weaponY;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        t+= 0.01f;
        weaponY = Mathf.Lerp(-0.04142f, 0.2414f, t);
        weaponX = math.sqrt(0.02f - math.pow(weaponY - 0.1f, 2)) / 1f;
        

        transform.localPosition = new Vector3(weaponX, weaponY);
      
    }

    void Update()
    {
        
    }
}
