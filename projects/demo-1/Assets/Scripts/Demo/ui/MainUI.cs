using Demo.data.ui;
using TMPro;
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

        public Button Button0;
        public Button Button1;
        public Button Button2;
        public Button Button3;

        public TextMeshProUGUI t_Button0;
        public TextMeshProUGUI t_Button1;
        public TextMeshProUGUI t_Button2;
        public TextMeshProUGUI t_Button3;

        public Image i_Button0;
        public Image i_Button1;
        public Image i_Button2;
        public Image i_Button3;

        public InfoData infoData;
        public SelectingButton SelectingButton;

        private void Start()
        {
            DontDestroyOnLoad(gameObject);
            ButtonW.transition = Selectable.Transition.None;
            ButtonA.transition = Selectable.Transition.None;
            ButtonS.transition = Selectable.Transition.None;
            ButtonD.transition = Selectable.Transition.None;
            ButtonEsc.transition = Selectable.Transition.None;
            Button0.transition = Selectable.Transition.None;
            Button1.transition = Selectable.Transition.None;
            Button2.transition = Selectable.Transition.None;
            Button3.transition = Selectable.Transition.None;
        }

        private void Update()
        {
            infoView.SetText(infoData.text);

            t_Button0.text = "hello0";
            t_Button1.text = "hello1";
            t_Button2.text = "hello2";
            t_Button3.text = "hello3";

            if (SelectingButton.currentSelectButton == SelectButton.ToMainUI2)
            {
                var hexNum = 0xffffff;
                var r = (hexNum >> 16) & 0xff;
                var g = (hexNum >> 8) & 0xff;
                var b = (hexNum) & 0xff;

                i_Button0.color = new Color(r, g, b);
                i_Button1.color = new Color(r, g, b);
                i_Button2.color = new Color(r, g, b);
                i_Button3.color = new Color(r, g, b);
            }
        }
    }
}