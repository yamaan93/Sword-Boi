using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Unity.Mathematics;
using Vector3 = UnityEngine.Vector3;

public class swordSwing : MonoBehaviour
{
    Vector3 swordPos1 = new Vector3(-0.146f, -0.463f, 0f);
    Vector3 swordRot1 = new Vector3(0f, 0f, 25);
    Vector3 swordPos2 = new Vector3(0.24f, -0.463f, 0f);
    Vector3 swordRot2 = new Vector3(0f, 0f, -25);

    Vector3 swordAttackPos = new Vector3(0f, 0f, 0);
    private bool isAttacking = false;
    public GameObject player;
    float t = 0.00f;
    void Start()
    {
        
    }

    
    void FixedUpdate()
    {
        //sword position
        if (player.GetComponent<playerMovement>().isFlipped == false && isAttacking == false)
        {
            transform.localPosition = swordPos1;
            transform.localEulerAngles = swordRot1;
        }

        if (player.GetComponent<playerMovement>().isFlipped == true && isAttacking == false) 
        {
            transform.localPosition = swordPos2;
            transform.localEulerAngles = swordRot2;
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            isAttacking = true;
            defaultAttack();
        }

        if (isAttacking == false)
        {
            t = 0;
        }

        
    }

    void defaultAttack()
    {
        transform.localPosition = swordAttackPos;
        t += 0.01f;
        
        if (player.GetComponent<playerMovement>().isFlipped == false)
        {
            float yPos = Mathf.Lerp(0.3162f, -0.3162f, t);
            float xPos = 2 * math.pow(yPos, 2) - 0.2f;
            
            Vector3 swordAttackPos = new Vector3( xPos, yPos, 0);
            swordAttackPos = swordPos1 + swordAttackPos;
            if (yPos > 0.316f)
            {
                isAttacking = false;
            }
            {
                
            }
        }
        
        
    }
}
