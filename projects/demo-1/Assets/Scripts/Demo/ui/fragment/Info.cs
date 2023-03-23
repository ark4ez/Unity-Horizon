using TMPro;
using UnityEngine;

namespace Demo.ui.fragment
{
    /// <summary>
    /// View
    /// </summary>
    public class Info : MonoBehaviour
    {
        public TextMeshProUGUI info;

        public void SetText(string text)
        {
            info.text = text;
        }
    }
}