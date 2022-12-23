using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

[RequireComponent(typeof(CinemachineTargetGroup))]
public class CinemachineTarget : MonoBehaviour
{
    private CinemachineTargetGroup cinemachineTargetGroup;

    #region
    [Tooltip("Populate with the CursorTarget gameObject")]
    #endregion
    [SerializeField] private Transform cursorTarget;

    private void Awake()
    {
        cinemachineTargetGroup = GetComponent<CinemachineTargetGroup>();
    }

    void Start()
    {
        SetCinemachineTargetGroup();
    }

    private void SetCinemachineTargetGroup()
    {
        CinemachineTargetGroup.Target cinemachineTargetGroup_player = new CinemachineTargetGroup.Target { weight = 1f, radius = 2.5f, target = GameManager.Instance.GetPlayer().transform };
        CinemachineTargetGroup.Target cinemachineTargetGroup_cursor = new CinemachineTargetGroup.Target { weight = 1f, radius = 1f, target = cursorTarget };
        CinemachineTargetGroup.Target[] cinemachineTargetArray = new CinemachineTargetGroup.Target[] { cinemachineTargetGroup_player, cinemachineTargetGroup_cursor };
        cinemachineTargetGroup.m_Targets = cinemachineTargetArray;
    }

    private void Update()
    {
        cursorTarget.position = HelperUtilities.GetMouseWorldPosition();
    }
}
