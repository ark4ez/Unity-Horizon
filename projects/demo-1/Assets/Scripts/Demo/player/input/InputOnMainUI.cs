using Demo.data.ui;
using UnityEngine;

namespace Demo.player.input
{
    public class InputOnMainUI : MonoBehaviour
    {
        [SerializeField] InfoData infoData;
        [SerializeField] PlayerInputManager playerInputManager;

        public void OnMainUI1()
        {
            if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
            {
                infoData.SetData("w");
                playerInputManager.InputState = InputState.MainUI2;
                return;
            }

            if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
            {
                infoData.SetData("a");
                playerInputManager.InputState = InputState.MainUI2;
                return;
            }

            if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
            {
                infoData.SetData("s");
                playerInputManager.InputState = InputState.MainUI2;
                return;
            }

            if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
            {
                infoData.SetData("d");
                playerInputManager.InputState = InputState.MainUI2;
                return;
            }

            if (Input.GetKeyDown(KeyCode.Return))
            {
                infoData.SetData("return");
                playerInputManager.InputState = InputState.MainUI2;
                return;
            }

            if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Backspace))
            {
                infoData.SetData("esc");
                return;
            }

            infoData.SetData("メニューを選択");
        }

        public void OnMainUI2()
        {
            if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Backspace))
            {
                infoData.SetData("esc");
                playerInputManager.InputState = InputState.MainUI1;
                return;
            }
            infoData.SetData("OnMainUI2");
        }
    }
}