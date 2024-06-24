using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomGUITexture : CustomGUIControlBase
{
    public ScaleMode scaleMode = ScaleMode.StretchToFill;

    protected override void DrawOffStyle()
    {
        GUI.DrawTexture(pos.Pos, content.image, scaleMode);
    }

    protected override void DrawOnStyle()
    {
        GUI.DrawTexture(pos.Pos, content.image, scaleMode);
    }

}
