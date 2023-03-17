using System;
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
        [SerializeField] private TextMeshProUGUI info;

        private UIVisibleState _uiVisibleState = UIVisibleState.Invisible;
        private UIState _uiState = UIState.Default;

        private void Start()
        {
            DontDestroyOnLoad(gameObject);
            info.text = "test";
        }

        private void FixedUpdate()
        {
            // gameObject.SetActive(_uiVisibleState == UIVisibleState.Visible);
        }
    }
}