﻿using UnityEngine;

namespace Demo.data.ui
{
    public enum SelectButton
    {
        ToMainUI2,
        Back,
        HideMenu,
        ApplicationQuit,
    }
    
    public class Select : MonoBehaviour
    {
        public SelectButton currentSelectButton;

        private void Awake()
        {
            currentSelectButton = SelectButton.ToMainUI2;
        }
    }
}