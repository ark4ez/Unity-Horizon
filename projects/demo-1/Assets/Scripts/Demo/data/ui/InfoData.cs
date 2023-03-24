using UnityEngine;

namespace Demo.data.ui
{
    /// <summary>
    /// Model
    /// </summary>
    public class InfoData : MonoBehaviour
    {
        public string text = "";

        public void SetData(string s)
        {
            text = s;
        }
    }
}