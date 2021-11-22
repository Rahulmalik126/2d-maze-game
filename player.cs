using UnityEngine;
using System.Collections.Generic;
using System.Collections;


public class player : MonoBehaviour
{
    Vector2 difference = Vector2.zero;

    private void OnMouseDown()
    {
        difference = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - (Vector2)transform.position;
    }

    private void OnMouseDrag()
    {
        transform.position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - difference;
    }
    // Mouse Control Variabbles
    //public float mouseSensitivityX = 1;
    //public float mouseSensitivityY = 1;
    //public Rigidbody2D rb;


    // Use this for initialization
 
    // Update is called once per frame
    void Update()
    {

        //float moveLR = Input.GetAxis("Mouse X") * mouseSensitivityX * Time.deltaTime;
        //float moveUD = Input.GetAxis("Mouse Y") * mouseSensitivityY * Time.deltaTime;

        //Vector3 mouse = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        //transform.position = new Vector3(mouse.x, mouse.y, transform.position.z);

        //Camera.main.ScreenPointToRay(Input.mousePosition);
        //Vector3 mouse = Input.mousePosition;
        //mouse = mouse;
        //transform.position = Camera.main.ScreenToViewportPoint(mouse);

    }
}