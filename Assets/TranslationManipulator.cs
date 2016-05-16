using UnityEngine;
using System.Collections;


[RequireComponent(typeof(VirtualHandSelectable))]
public class TranslationManipulator : Manipulator
{
	// Update is called once per frame
	void Update () {
	    if (m_Marker != null)
	    {
	        transform.position = m_Marker.transform.position;
	    }
	}
}
