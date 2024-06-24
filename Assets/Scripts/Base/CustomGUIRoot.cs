using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class CustomGUIRoot : MonoBehaviour
{
    private CustomGUIControlBase[] allControls;

    // Start is called before the first frame update
    void Start()
    {
        allControls = GetComponentsInChildren<CustomGUIControlBase>();
    }


    private void OnGUI()
    {
        //编辑状态下才会执行
        //if(!Application.isPlaying)
            allControls = GetComponentsInChildren<CustomGUIControlBase>();

        for (int i = 0; i < allControls.Length; i++)
        {
            allControls[i].DrawGUI();
        }
    }
}
