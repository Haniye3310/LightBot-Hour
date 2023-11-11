using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] private Material _blueMaterial;
    [SerializeField] private Material _yellowMaterial;
    [SerializeField] private GameObject _innerCube;
    [SerializeField] private SOChanneVector3 _onLightClicked;
    private void Awake()
    {
        _onLightClicked.Event.AddListener(Light);
    }
    private void OnDisable()
    {
        _onLightClicked.Event.RemoveListener(Light);
    }
    public void Target() 
    {
        _innerCube.GetComponentInChildren<MeshRenderer>().material = _blueMaterial;
    }
    public void Light(Vector3 position) 
    {
        if(this.transform.position == position 
            &&_innerCube.GetComponentInChildren<MeshRenderer>().material.color == _blueMaterial.color
            )
            _innerCube.GetComponentInChildren<MeshRenderer>().material = _yellowMaterial;
    }
}
