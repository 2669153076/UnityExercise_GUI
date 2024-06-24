using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public enum E_SliderType
{
    Horizontal,
    Vertical
}

public class CustomGUISlider : CustomGUIControlBase
{
    public float minValue=0;
    public float maxValue=1;
    public float nowValue=0;

    public E_SliderType sliderType = E_SliderType.Horizontal;

    public GUIStyle sliderStyle;

    public event UnityAction<float> changeValue;
    private float oldValue;

    protected override void DrawOffStyle()
    {
        switch (sliderType)
        {
            case E_SliderType.Horizontal:
                nowValue = GUI.HorizontalSlider(pos.Pos,nowValue,minValue,maxValue);
                break;
            case E_SliderType.Vertical:
                nowValue = GUI.VerticalSlider(pos.Pos, nowValue, minValue, maxValue);
                break;
        }
        if (oldValue != nowValue)
        {
            changeValue?.Invoke(nowValue);
            oldValue = nowValue;
        }
    }

    protected override void DrawOnStyle()
    {
        switch (sliderType)
        {
            case E_SliderType.Horizontal:
                nowValue = GUI.HorizontalSlider(pos.Pos, nowValue, minValue, maxValue,style,sliderStyle);
                break;
            case E_SliderType.Vertical:
                nowValue = GUI.VerticalSlider(pos.Pos, nowValue, minValue, maxValue,style,sliderStyle);
                break;
        }
        if (oldValue != nowValue)
        {
            changeValue?.Invoke(nowValue);
            oldValue = nowValue;
        }
    }

}
