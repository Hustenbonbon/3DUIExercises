using System;
using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using UnityEngine.Assertions.Must;

public class VirtualHandSelectable : MonoBehaviour
{
    [SerializeField]
    public TransformEvent m_Selected;

    [Serializable]
    public class TransformEvent : UnityEvent<Transform>{}

    void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider.transform.tag.Equals("Marker"))
        {
            if (m_Selected.GetPersistentEventCount() >= 0)
            {
                m_Selected.Invoke(otherCollider.transform);
            }
            else
            {
                print("Collided with virtual hand, no attached script for handling");
            }
        }
    }
}
