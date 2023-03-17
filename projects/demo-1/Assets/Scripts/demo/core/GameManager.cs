using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * ゲームの中心となるパッケージ
 */
namespace demo.core
{
    /*
     * ゲームの進行関連
     */
    public class GameManager : MonoBehaviour
    {
        private string _debugName;

        void Start()
        {
            _debugName = "[" + GetType().FullName + "] : ";
            Debug.Log(_debugName + "start");
        }
    }
}