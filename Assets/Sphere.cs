using UnityEngine;
using System.Collections;

public class Sphere : MonoBehaviour {
    
    [SerializeField]
    private GameObject Marker;


    public void SetColor(Color color)
    {
        GetComponent<Renderer>().material.color = color;
    }
}
