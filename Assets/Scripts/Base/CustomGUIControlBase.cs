using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum E_Style_OnOff
{
    On,
    Off
}

public abstract class CustomGUIControlBase : MonoBehaviour
{
    //位置信息
    public CustomGUIPos pos;
    //显示内容
    public GUIContent content;
    //样式
    public GUIStyle style;
    //自定义样式是否启用
    public E_Style_OnOff styleOnOrOff = E_Style_OnOff.Off;

    public void DrawGUI()
    {
        switch (styleOnOrOff)
        {
            case E_Style_OnOff.On:
                DrawOnStyle();
                break;
            case E_Style_OnOff.Off:
                DrawOffStyle();
                break;
        }
    }

    protected abstract void DrawOffStyle();

    protected abstract void DrawOnStyle();

    
}
