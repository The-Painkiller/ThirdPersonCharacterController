using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CameraController _cameraController;
    private CharacterController _characterController;

    public bool MovementLock;

    private void Awake ( )
    {
        _cameraController = transform.GetComponentInChildren<CameraController> ( );
        _characterController = transform.GetComponentInChildren<CharacterController> ( );
    }

    private void Start ( )
    {
        
    }
}
