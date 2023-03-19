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
            ControllerInputAction += new PlayerInputs().UpdateControllerAction;
        }
    }
}

public interface IPlayerInputs
{
    void UpdateControllerAction();
}

public class PlayerInputs : IPlayerInputs
{
    public void UpdateControllerAction()
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
        }

        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
        }

        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
        }

        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
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