using Demo.player;
using Demo.player.input;
using UnityEngine;

namespace Demo.player
{
    public enum InputState
    {
        MainUI1,
        MainUI2,
    }
}

/// <summary>
/// プレイヤーからの物理ボタン入力を管理する
/// </summary>
public class PlayerInputManager : MonoBehaviour
{
    [SerializeField] private InputOnMainUI inputOnMainUI;

    public InputState InputState { get; set; }

    private bool _changed;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
        InputState = InputState.MainUI1;
    }

    private void Update()
    {
        if (InputState == InputState.MainUI1)
        {
            inputOnMainUI.OnMainUI1();
            return;
        }

        if (InputState == InputState.MainUI2)
        {
            inputOnMainUI.OnMainUI2();
            return;
        }
    }
}