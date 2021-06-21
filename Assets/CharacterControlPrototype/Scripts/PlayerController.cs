using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CamComponent _cameraController;
    private CharacterController _characterController;

    public bool MovementLock;

    private void Awake ( )
    {
        _cameraController = transform.GetComponentInChildren<CamComponent> ( );
        _characterController = transform.GetComponentInChildren<CharacterController> ( );
    }

    private void Start ( )
    {
        
    }
}
