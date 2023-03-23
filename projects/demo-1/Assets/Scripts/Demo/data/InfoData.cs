using UnityEngine;

namespace Demo.data
{
    /// <summary>
    /// Model
    /// </summary>
    public class InfoData : MonoBehaviour
    {
        public string text = "";

        public void SetString(string s)
        {
            text = s;
        }
    }
}