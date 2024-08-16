using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraController : MonoBehaviour
{
    public CinemachineFreeLook LT;
    public CinemachineFreeLook RT;
    public CinemachineVirtualCamera stageDollyVCam;
    public CinemachineVirtualCamera dollyCam;
    public CinemachineVirtualCamera backStageVcam;
    
    int higherPriority = 11;
    int lowerPriority = 9;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            LT.Priority = higherPriority;
            RT.Priority = lowerPriority;
            stageDollyVCam.Priority = lowerPriority;
            dollyCam.Priority = lowerPriority;
            backStageVcam.Priority = lowerPriority;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            LT.Priority = lowerPriority;
            RT.Priority = higherPriority;
            stageDollyVCam.Priority = lowerPriority;
            dollyCam.Priority = lowerPriority;
            backStageVcam.Priority = lowerPriority;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            LT.Priority = lowerPriority;
            RT.Priority = lowerPriority;
            stageDollyVCam.Priority = higherPriority;
            dollyCam.Priority = lowerPriority;
            backStageVcam.Priority = lowerPriority;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            LT.Priority = lowerPriority;
            RT.Priority = lowerPriority;
            stageDollyVCam.Priority = lowerPriority;
            dollyCam.Priority = higherPriority;
            backStageVcam.Priority = lowerPriority;
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            LT.Priority = lowerPriority;
            RT.Priority = lowerPriority;
            stageDollyVCam.Priority = lowerPriority;
            dollyCam.Priority = lowerPriority;
            backStageVcam.Priority = higherPriority;
        }
    }
}
