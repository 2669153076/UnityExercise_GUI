using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CustomGUIButton : CustomGUIControlBase
{
    //提供给外部 用于响应按钮点击的函数
    public event UnityAction clickEvent;

    protected override void DrawOffStyle()
    {
        if (GUI.Button(pos.Pos, content))
            clickEvent?.Invoke();
    }

    protected override void DrawOnStyle()
    {
        if (GUI.Button(pos.Pos, content, style))
            clickEvent?.Invoke();
    }
}
