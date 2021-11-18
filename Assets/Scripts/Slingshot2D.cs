using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slingshot2D : MonoBehaviour
{
    //The force that will be applied to the force when we release our mouse
    public float SlingshotForce;

    public Rigidbody2D reggiebody;
    //The start position of the dragging motion
    Vector3 startMousePos;
    bool draggingBallZ = false;
    Vector3 mouseVector;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            mouseVector = Input.mousePosition - startMousePos;
            reggiebody.AddForce(-)
        }
    }

    private void OnMouseDown()
    {
        startMousePos = Input.mousePosition;
    }
}
