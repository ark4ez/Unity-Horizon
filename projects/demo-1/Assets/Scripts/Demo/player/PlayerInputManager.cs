using Demo.player;
using Demo.player.input;
using UnityEngine;

namespace Demo.player
{
    public enum ControllerState
    {
        MainUI
    }
}

public class PlayerInputManager : MonoBehaviour
{
    [SerializeField] private InputOnMainUI inputOnMainUI;

    private ControllerState ControllerState { get; set; }

    private bool _changed;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
        inputOnMainUI.enabled = true;
        ControllerState = ControllerState.MainUI;
    }

    private void Update()
    {
        if (_changed == false) return;
        
        if (ControllerState == ControllerState.MainUI) inputOnMainUI.enabled = true;

        _changed = false;
    }
}