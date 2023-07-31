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
        
        color.a += 0.001f * minus;
        image.color = color;
        ondo.rectTransform.sizeDelta = new Vector2(36.258f, 130f - color.a * 100);
        // 변하는 알파값을 이용하여 온도 이미지 크기 줄이기

        if(color.a <= 0)
        {
            minus *= -1;
        }
        if (color.a >= 0.8f)
        {
            minus *= -1;
            day += 1;
            viewTimeText.text = "Day - " + day;

        }

    }
}
