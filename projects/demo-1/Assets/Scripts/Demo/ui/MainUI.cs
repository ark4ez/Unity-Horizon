using Demo.data.ui;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
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

        [SerializeField] private EventSystem _eventSystem;

        /// <summary>
        /// visual elements of ui.
        /// </summary>
        public fragment.Info infoView;

        public Button Button0;
        public Button Button1;
        public Button Button2;
        public Button Button3;

        public TextMeshProUGUI t_Button0;
        public TextMeshProUGUI t_Button1;
        public TextMeshProUGUI t_Button2;
        public TextMeshProUGUI t_Button3;

        public InfoData infoData;
        public SelectingButton SelectingButton;

        private void Start()
        {
            DontDestroyOnLoad(gameObject);
        }

        private void FixedUpdate()
        {
            infoView.SetText(infoData.text);
            // _eventSystem.

            t_Button0.text = "hello0";
            t_Button1.text = "hello1";
            t_Button2.text = "hello2";
            t_Button3.text = "hello3";
        }
    }
}