using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public CustomGUIButton startBtn;
    public CustomGUIButton exitBtn;
    // Start is called before the first frame update
    void Start()
    {
        startBtn.clickEvent += () =>
        {
            print("��ʼ��ť");
        };
        exitBtn.clickEvent += () =>
        {
            print("�˳���ť");
        };
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
