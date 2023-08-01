using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TimeFlow : MonoBehaviour
{
    private Image image;
    Color color;
    private float minus = 1;
    public TextMeshProUGUI viewTimeText;
    private int day = 1;
    public Image ondo;
    public float timeFlow = 0.001f;

    void Start()
    {
        color = Color.black;
        color.a = 0f;
        image = GetComponent<Image>();
        image.color = color;
        viewTimeText.text = "Day - " + day;
    }
    void FixedUpdate()
    {
        
        color.a += timeFlow * minus;
        image.color = color;

        ondo.rectTransform.sizeDelta = new Vector2(14f, 130f - color.a * 100);
        // 변하는 알파값을 이용하여 온도 이미지 크기 줄이기

        if(color.a <= 0)
        {
            minus *= -1;
        }
        if (color.a >= 0.6f)
        {
            minus *= -1;
            day += 1;
            viewTimeText.text = "Day - " + day;
        }
        if(color.a >= 0 || color.a <= 0.1f)
        {  // 낮 지속
            timeFlow = 0.002f;
        }
        else if(color.a <= 0.6f || color.a >= 0.5f)
        {  // 밤 지속
            timeFlow = 0.008f;
        }
        else
        {
            timeFlow = 0.001f;
        }


    }
}
