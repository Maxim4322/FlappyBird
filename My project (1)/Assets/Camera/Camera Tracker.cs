using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CameraTracker : MonoBehaviour
{
    [SerializeField] Transform _birdTransform;

    private void Awake()
    {
        if (_birdTransform == null)
        {
            gameObject.SetActive(false);
        } 
        
    }
}


