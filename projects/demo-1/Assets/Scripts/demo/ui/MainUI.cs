using System;
using UnityEngine;

namespace demo.ui
{
    public class MainUI : MonoBehaviour
    {
        private void Start()
        {
            DontDestroyOnLoad(gameObject);
        }

        private void Update()
        {
            
        }
    }
}