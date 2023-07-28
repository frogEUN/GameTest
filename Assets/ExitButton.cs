using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButton : MonoBehaviour
{
    public Inventory inventory;
    public void GameExit()
    {
        // �κ��丮 ������ �� 0���� �ʱ�ȭ
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
