using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomGUIToggleGroup : MonoBehaviour
{
    public CustomGUIToggle[] customGUIToggles;

    private CustomGUIToggle frontTrueToggle;

    private void Start()
    {
        if (customGUIToggles == null)
            return;

        for (int i = 0; i < customGUIToggles.Length; i++)
        {
            CustomGUIToggle toggle = customGUIToggles[i];
            toggle.changeValue += (value) =>
            {
                if (value)
                {
                    for (int j = 0; j < customGUIToggles.Length; j++)
                    {
                        //闭包 togglr是上一个函数中声明的变量
                        //改变了它的生命周期
                        if (customGUIToggles[j] != toggle)
                        {
                            customGUIToggles[j].isSel = false;
                        }
                    }
                    frontTrueToggle = toggle;
                }
                else if(frontTrueToggle == toggle)
                {
                    //判断当前变成false的toggle 是不是上一次变成true的
                    //如果是 则不应该变为false
                    //强制转换为true
                        toggle.isSel = true;
                }
            };
        }
    }
}
