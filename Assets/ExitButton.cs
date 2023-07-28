using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButton : MonoBehaviour
{
    public Inventory inventory;
    public void GameExit()
    {
        // 인벤토리 아이템 양 0으로 초기화
        foreach(var i in inventory.items)
        {
            i.amount = 0;
        }
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif

    }
}
