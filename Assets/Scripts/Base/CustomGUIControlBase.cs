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
    //λ����Ϣ
    public CustomGUIPos pos;
    //��ʾ����
    public GUIContent content;
    //��ʽ
    public GUIStyle style;
    //�Զ�����ʽ�Ƿ�����
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
