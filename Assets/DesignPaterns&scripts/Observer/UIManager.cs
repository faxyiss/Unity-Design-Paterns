using System;
using UnityEngine;



namespace Observer
{
    public class UIManager : MonoBehaviour
    {
        public static event Action OpenLight;
        public static event Action CloseLight;
        public static event Action PlaySound;

        public void button1Clicked()
        {
            OpenLight?.Invoke();
        }
        public void button2Clicked()
        {
            CloseLight?.Invoke();
        }
        public void button3Clicked()
        {
            PlaySound?.Invoke();
        }
    }
}

