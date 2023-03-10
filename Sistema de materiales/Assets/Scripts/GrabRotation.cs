using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabRotation : MonoBehaviour
{
    float rotationSpeed = 3f;

    void OnMouseDrag()
    {
        float XaxisRotation = Input.GetAxis("Mouse X") * rotationSpeed;
        float YaxisRotation = Input.GetAxis("Mouse Y") * rotationSpeed;

        transform.Rotate(Vector3.down, XaxisRotation, Space.World);
        transform.Rotate(Vector3.right, YaxisRotation, Space.World);
    }

    private void OnMouseUp()
    {
        transform.rotation = Quaternion.identity;
    }
}
 