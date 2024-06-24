using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CustomGUIInput : CustomGUIControlBase
{
    public event UnityAction<string> textChange;

    private string oldText = "";

    protected override void DrawOffStyle()
    {
        content.text = GUI.TextField(pos.Pos,content.text);

        if(oldText != content.text)
        {
            textChange?.Invoke(content.text);
            oldText = content.text;
        }
    }

    protected override void DrawOnStyle()
    {
        content.text = GUI.TextField(pos.Pos,content.text,style);

        if (oldText != content.text)
        {
            textChange?.Invoke(content.text);
            oldText = content.text;
        }
    }

}
