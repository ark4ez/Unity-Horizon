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

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
        mainUI.enabled = true;
        ControllerState = ControllerState.MainUI;
    }

}