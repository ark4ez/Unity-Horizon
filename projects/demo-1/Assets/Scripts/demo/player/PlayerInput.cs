using System;
using demo.player;
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
    private ControllerState ControllerState { get; set; }

    private Action ControllerInputAction { get; set; }

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
        ControllerState = ControllerState.MainUI;
    }

    private void Update()
    {
        ControllerInputAction?.Invoke();
    }

    private void FixedUpdate()
    {
        ControllerInputAction = null;
        if (ControllerState == ControllerState.MainUI)
        {
            ControllerInputAction += PlayerInputs.OnMainUIInput;
        }
        else
        {
            ControllerInputAction -= PlayerInputs.OnMainUIInput;
        }
    }
}


public static class PlayerInputs
{
    public static void OnMainUIInput()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("W");
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
        }

        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Backspace))
        {
        }
    }
}