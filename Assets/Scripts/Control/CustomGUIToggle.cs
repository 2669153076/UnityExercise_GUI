using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CustomGUIToggle : CustomGUIControlBase
{
    public bool isSel;

    public event UnityAction<bool> changeValue;

    private bool isOldSel;

    protected override void DrawOffStyle()
    {
        isSel = GUI.Toggle(pos.Pos, isSel, content);

        //只有变化时，才告诉外部 执行函数
        if (isOldSel != isSel)
        {
            changeValue?.Invoke(isSel);
            isOldSel = isSel;
        }
    }

    protected override void DrawOnStyle()
    {
        isSel = GUI.Toggle(pos.Pos, isSel, content, style);
        
        if (isOldSel != isSel)
        {
            changeValue?.Invoke(isSel);
            isOldSel = isSel;
        }
    }

    
}
