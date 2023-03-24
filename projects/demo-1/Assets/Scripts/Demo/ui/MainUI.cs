using Demo.data.ui;
using UnityEngine;
using UnityEngine.UI;

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

        /// <summary>
        /// visual elements of ui.
        /// </summary>
        public fragment.Info infoView;
        public Button ButtonW;
        public Button ButtonA;
        public Button ButtonS;
        public Button ButtonD;        
        public Button ButtonEsc;
        
        public InfoData infoData;

        private void Start()
        {
            DontDestroyOnLoad(gameObject);
        }

        private void Update()
        {
            infoView.SetText(infoData.text);
            ButtonA.Select();
        }
    }
}