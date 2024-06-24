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
                        //�հ� togglr����һ�������������ı���
                        //�ı���������������
                        if (customGUIToggles[j] != toggle)
                        {
                            customGUIToggles[j].isSel = false;
                        }
                    }
                    frontTrueToggle = toggle;
                }
                else if(frontTrueToggle == toggle)
                {
                    //�жϵ�ǰ���false��toggle �ǲ�����һ�α��true��
                    //����� ��Ӧ�ñ�Ϊfalse
                    //ǿ��ת��Ϊtrue
                        toggle.isSel = true;
                }
            };
        }
    }
}
