using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public new Rigidbody rigidbody;
    public float playerSpeed = 8f;
    public float minX;
    public float maxX;
    public float playerFwdSpeed = 1000f;
    public float boostSpeed = 10f;


    void Update()
    {
        Vector3 playerpos = transform.position;
        playerpos.x = Mathf.Clamp(playerpos.x, minX, maxX);
        transform.position = playerpos;

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey (KeyCode.D))
        {
            transform.position = transform.position + new Vector3(playerSpeed * Time.deltaTime, 0, 0);

        }

        if(Input.GetKey(KeyCode.LeftArrow)||Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position - new Vector3(playerSpeed * Time.deltaTime, 0, 0);
        }
       
       

    }
    
    void FixedUpdate()
    {
        rigidbody.AddForce(0, 0, playerFwdSpeed * Time.deltaTime);
        
    }
   


}
