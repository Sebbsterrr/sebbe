using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class playerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      
    }

    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
            {
            transform.position += transform.right * -4 * Time.deltaTime;
            }

        if(Input.GetKey(KeyCode.D))
            {
            transform.position += transform.right * 4 * Time.deltaTime;
            }

        if(Input.GetKey(KeyCode.W))
            {
                transform.position += transform.forward * 5 * Time.deltaTime;

            }

        if(Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift))
            {
                transform.position += transform.forward * 8 * Time.deltaTime;
            }

        if(Input.GetKey(KeyCode.S))
            {
                transform.position += transform.forward * -5 * Time.deltaTime;
            }

        if(Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.LeftShift))
            {
                 transform.position += transform.forward * -6 * Time.deltaTime;
            
            }

        if (Input.GetKey(KeyCode.L))
        {
            
        }
        
    }




}

