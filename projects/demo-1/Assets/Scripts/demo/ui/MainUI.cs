using TMPro;
using UnityEngine;

namespace demo.ui
{
    internal enum UIVisibleState
    {
        Visible,
        Invisible
    }

    internal enum UIState
    {
        Default,
        Error
    }

    public class MainUI : MonoBehaviour
    {

        private UIVisibleState _uiVisibleState = UIVisibleState.Invisible;
        private UIState _uiState = UIState.Default;

        private void Start()
        {
            DontDestroyOnLoad(gameObject);
        }

        private void FixedUpdate()
        {
        }
    }
}