using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 对齐方式枚举
/// </summary>
public enum E_AlignmentType
{
    Up,
    Down, 
    Left, 
    Right,
    Left_Up,
    Right_Up,
    Left_Down, 
    Right_Down,
    Center
}

[System.Serializable]
public class CustomGUIPos
{
    /// <summary>
    /// 计算控件中心点偏移
    /// </summary>
    private void CalcCenterPos()
    {
        switch (control_Center_Alignment_Type)
        {
            case E_AlignmentType.Up:
                centerPos.x = -width / 2;
                centerPos.y = 0;
                break;
            case E_AlignmentType.Down:
                centerPos.x = -width / 2;
                centerPos.y = -height;
                break;
            case E_AlignmentType.Left:
                centerPos.x = 0;
                centerPos.y = -height / 2;
                break;
            case E_AlignmentType.Right:
                centerPos.x = -width;
                centerPos.y = -height / 2;
                break;
            case E_AlignmentType.Left_Up:
                centerPos.x = 0;
                centerPos.y = 0;
                break;
            case E_AlignmentType.Right_Up:
                centerPos.x = -width;
                centerPos.y = 0;
                break;
            case E_AlignmentType.Left_Down:
                centerPos.x = 0;
                centerPos.y = -height;
                break;
            case E_AlignmentType.Right_Down:
                centerPos.x = -width;
                centerPos.y = -height;
                break;
            case E_AlignmentType.Center:
                centerPos.x = -width / 2;
                centerPos.y = -height / 2;
                break;
        }
    }
    /// <summary>
    /// 计算在屏幕中实际位置
    /// </summary>
    private void CalcRectPos()
    {
        switch (screen_Alignment_Type)
        {
            case E_AlignmentType.Up:
                rectPos.x = Screen.width / 2 + centerPos.x + offsetPos.x;
                rectPos.y = 0 + centerPos.y + offsetPos.y;
                break;
            case E_AlignmentType.Down:
                rectPos.x = Screen.width / 2 + centerPos.x + offsetPos.x;
                rectPos.y = Screen.height + centerPos.y - offsetPos.y;
                break;
            case E_AlignmentType.Left:
                rectPos.x = 0 + centerPos.x + offsetPos.x;
                rectPos.y = Screen.height / 2 + centerPos.y - offsetPos.y;
                break;
            case E_AlignmentType.Right:
                rectPos.x = Screen.width + centerPos.x - offsetPos.x;
                rectPos.y = Screen.height / 2 + centerPos.y - offsetPos.y;
                break;
            case E_AlignmentType.Left_Up:
                rectPos.x = 0 + centerPos.x + offsetPos.x;
                rectPos.y = 0 + centerPos.y + offsetPos.y;
                break;
            case E_AlignmentType.Right_Up:
                rectPos.x = Screen.width + centerPos.x - offsetPos.x;
                rectPos.y = 0 + centerPos.y + offsetPos.y;
                break;
            case E_AlignmentType.Left_Down:
                rectPos.x = 0 + centerPos.x + offsetPos.x;
                rectPos.y = Screen.height + centerPos.y - offsetPos.y;
                break;
            case E_AlignmentType.Right_Down:
                rectPos.x = Screen.width + centerPos.x - offsetPos.x;
                rectPos.y = Screen.height + centerPos.y - offsetPos.y;
                break;
            case E_AlignmentType.Center:
                rectPos.x = Screen.width / 2 + centerPos.x + offsetPos.x;
                rectPos.y = Screen.height / 2 + centerPos.y - offsetPos.y;
                break;
        }
    }

    public Rect Pos
    {
        get
        {
            //计算控件中心点偏移
            CalcCenterPos();
            //计算实际位置
            CalcRectPos();

            rectPos.width = width;
            rectPos.height = height;
            return rectPos;
        }
    }

    //实际位置信息
    private Rect rectPos = new Rect(0,0,100,100);

    //屏幕对齐方式
    public E_AlignmentType screen_Alignment_Type = E_AlignmentType.Center;
    //控件中心对齐方式
    public E_AlignmentType control_Center_Alignment_Type = E_AlignmentType.Center;
    //偏移位置
    public Vector2 offsetPos;
    //宽、高
    public float width = 100;
    public float height = 50;
    //用于计算的中心点成员变量
    private Vector2 centerPos;
}
