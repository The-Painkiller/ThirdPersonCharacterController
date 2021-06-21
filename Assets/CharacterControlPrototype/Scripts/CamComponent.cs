using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamComponent : MonoBehaviour
{
    [SerializeField]
    private Transform _xAxisGimbal;

    private Transform _targetToFollow = null;
    private Camera _mainCamera;
    private Vector3 _cameraRotation = Vector3.zero;

    public CharacterController _characterController { get; private set; }
    private void Awake()
    {
        _mainCamera = transform.GetComponentInChildren<Camera>();
    }

    public void AssignPlayerController(CharacterController playerControl)
    {
        _characterController = playerControl;
    }

    public void AssignTargetToFollow(Transform target)
    {
        _targetToFollow = target;
    }

    public void SetCamerOrientation(float x, float y)
    {
        _cameraRotation.y += x;
        _cameraRotation.z = 0;

        _cameraRotation.x += y;
        _cameraRotation.x = Mathf.Clamp(_cameraRotation.x, -50, 50);
    }

    private void FixedUpdate()
    {
        if (!_targetToFollow || !_mainCamera || !_characterController)
            return;

        //if (_characterController.IsMoving)
        //{
        //    _xAxisGimbal.localEulerAngles = new Vector3(_cameraRotation.x, 0, 0);
        //    //SetMousePosition ( 0, 0 );
        //    //transform.localRotation = Quaternion.Euler ( 0, 0, 0 );
        //    //_xAxisGimbal.localRotation = Quaternion.Euler ( 0, 0, 0 );
        //    return;
        //}
        else
        {
            transform.eulerAngles = new Vector3(0, _cameraRotation.y, 0);
            _xAxisGimbal.localEulerAngles = new Vector3(_cameraRotation.x, 0, 0);
        }
    }
}
