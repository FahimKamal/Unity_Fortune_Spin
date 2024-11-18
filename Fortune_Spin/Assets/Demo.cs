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
            pickerWheel.OnSpinStart(OnSpinStartEvent);
            pickerWheel.OnSpinEnd(OnSpinEndEvent);
            
            uiSpinButton.interactable = false;
            uiSpinButtonText.text = "Spinning";
            pickerWheel.Spin();
        });
    }

    private void OnSpinEndEvent(WheelPiece wheelPiece)
    {
        Debug.Log("Spin ended: " + wheelPiece.Label + ", Amount: " + wheelPiece.Amount);
        uiSpinButton.interactable = true;
        uiSpinButtonText.text = "Spin";
    }

    private void OnSpinStartEvent()
    {
        Debug.Log("Spin started ...");
    }
}
