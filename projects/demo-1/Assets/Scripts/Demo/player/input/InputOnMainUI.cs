using UnityEngine;

namespace Demo.player.input
{
    public class InputOnMainUI : MonoBehaviour
    {
        [SerializeField] data.InfoData infoData;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
            {
                infoData.SetString("w");
            }

            if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
            {
                infoData.SetString("a");
            }

            if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
            {
                infoData.SetString("s");
            }

            if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
            {
                infoData.SetString("d");
            }

            if (Input.GetKeyDown(KeyCode.Return))
            {
                infoData.SetString("return");
            }

            if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Backspace))
            {
                infoData.SetString("esc");
            }
        }
    }
}