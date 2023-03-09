using UnityEngine;
using Cinemachine;

public class ChangeCamera : MonoBehaviour
{
    public bool isOrbitalCamActive { get; private set; } = false;

    private int activeCameraPriorityModifier = 31337;

    private CinemachineVirtualCamera activeCamera;

    [SerializeField] private Transform targetCamera;
    private Vector3 initialTargetCamPosition = Vector3.zero;

    [SerializeField] private Camera mainCamera;
    [SerializeField] private CinemachineVirtualCamera cam1stPerson;
    [SerializeField] private CinemachineVirtualCamera cam3rdPerson;
    [SerializeField] private CinemachineVirtualCamera camOrbital;


    [SerializeField]
    private PlayerInput _input;

    private void Start()
    {
        activeCamera = cam3rdPerson;
        initialTargetCamPosition += targetCamera.transform.position;
    }

    private void OnEnable()
    {
        _input.changeCameraWasPressed += changeCamera;
    }

    private void OnDisable()
    {
        _input.changeCameraWasPressed -= changeCamera;
    }

    private void changeCamera(bool changeCameraWasPressed) {

        if (cam3rdPerson == activeCamera)
        {
            setCameraPriorities(cam3rdPerson, cam1stPerson);
            isOrbitalCamActive = false;
        }
        else if (cam1stPerson == activeCamera)
        {
            setCameraPriorities(cam1stPerson, camOrbital);
            isOrbitalCamActive = true;
        }
        else if (camOrbital == activeCamera)
        {
            setCameraPriorities(camOrbital, cam3rdPerson);
            isOrbitalCamActive = false;
        }
        else {
            cam3rdPerson.Priority += activeCameraPriorityModifier;
            activeCamera = cam3rdPerson;

            isOrbitalCamActive = false;
        }

    }

    private void setCameraPriorities(CinemachineVirtualCamera currentCam, CinemachineVirtualCamera newCam) {
        currentCam.Priority -= activeCameraPriorityModifier;
        newCam.Priority += activeCameraPriorityModifier;

        if (newCam == cam1stPerson)
        {
            var parentPosition = targetCamera.parent.gameObject.transform.position;
            targetCamera.transform.position = new Vector3(parentPosition.x, parentPosition.y, parentPosition.z);

            mainCamera.cullingMask &= ~(1 << LayerMask.NameToLayer("Player (self)"));
        }
        else {
            targetCamera.position = initialTargetCamPosition;
            mainCamera.cullingMask |= ~(1 << LayerMask.NameToLayer("Player (self)"));

        }

        activeCamera = newCam;
    }
}
