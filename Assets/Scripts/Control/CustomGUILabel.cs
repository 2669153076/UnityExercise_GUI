using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomGUILabel : CustomGUIControlBase
{
    protected override void DrawOffStyle()
    {
        GUI.Label(pos.Pos, content);
    }

    protected override void DrawOnStyle()
    {
        GUI.Label(pos.Pos, content, style);
    }
}
