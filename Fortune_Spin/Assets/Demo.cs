using System;
using System.Collections;
using System.Collections.Generic;
using EasyUI.PickerWheelUI;
using UnityEngine;
using UnityEngine.UI;

public class Demo : MonoBehaviour
{
    [SerializeField] private Button uiSpinButton;
    [SerializeField] private Text uiSpinButtonText;
    
    [SerializeField] private PickerWheel pickerWheel;


    private void Start()
    {
        uiSpinButton.onClick.AddListener(() =>
        {
            uiSpinButtonText.text = "Spinning";
            pickerWheel.Spin();
        });
    }
}
