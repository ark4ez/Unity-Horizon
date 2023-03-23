using Demo.data;
using Demo.ui.fragment;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

namespace Demo.ui
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

    /// <summary>
    /// Like Presenter
    /// </summary>
    public class MainUI : MonoBehaviour
    {
        private UIVisibleState _uiVisibleState = UIVisibleState.Invisible;
        private UIState _uiState = UIState.Default;

        public fragment.Info infoView;
        public InfoData infoData; 

        private void Start()
        {
            DontDestroyOnLoad(gameObject);
        }

        private void FixedUpdate()
        {
            infoView.SetText(infoData.text);
        }
    }
}