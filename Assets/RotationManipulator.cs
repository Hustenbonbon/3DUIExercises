using UnityEngine;
using System.Collections;

[RequireComponent(typeof(VirtualHandSelectable))]
public class RotationManipulator : Manipulator {

    // Update is called once per frame
    void Update()
    {
        if (m_Marker != null)
        {
            
            transform.rotation = Quaternion.FromToRotation(transform.position,  m_Marker.position);
            transform.rotation = Quaternion.AngleAxis(180f,Vector3.up) * transform.rotation;
        }
    }
}
