using System;
using demo.player;
using demo.PlayerInput;
using UnityEngine;

namespace demo.player
{
    public enum ControllerState
    {
        MainUI
    }
}

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private MainUI mainUI;

    private ControllerState ControllerState { get; set; }

    private bool _changed;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
        mainUI.enabled = true;
        ControllerState = ControllerState.MainUI;
    }

    private void FixedUpdate()
    {
        if (_changed == true)
        {
            if (ControllerState == ControllerState.MainUI) mainUI.enabled = true;

            _changed = false;
        }
    }
}