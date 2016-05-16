using UnityEngine;
using System.Collections;

[RequireComponent(typeof(VirtualHandSelectable))]
public abstract class Manipulator : MonoBehaviour {

    protected Transform m_Marker = null;

    // Use this for initialization
    void Start()
    {
        GetComponent<VirtualHandSelectable>().m_Selected.AddListener((Transform marker) => { Attach(marker); });
    }

    public void Attach(Transform marker)
    {
        print("attached marker with coordinates " + marker.position.ToString());
        m_Marker = marker;
    }

    public void Detach()
    {
        m_Marker = null;
    }
}
