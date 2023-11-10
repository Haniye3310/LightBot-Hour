using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] private Material _blueMaterial;
    [SerializeField] private GameObject _innerCube;
    public void Target() 
    {
        _innerCube.GetComponentInChildren<MeshRenderer>().material = _blueMaterial;
    }
}
