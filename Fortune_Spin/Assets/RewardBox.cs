using System;
using EasyUI.PickerWheelUI;
using UnityEngine;
using UnityEngine.UI;

public class RewardBox : MonoBehaviour
{
    [SerializeField] private GameObject placeHolder;
    [SerializeField] private Text placeHolderText;
    [SerializeField] private Text rewardTitleText;
    [SerializeField] private Text rewardAmountText;
    [SerializeField] private Image rewardIcon;

    [SerializeField] private Button spinButton;
    [SerializeField] private Text spinButtonText;
    [SerializeField] private PickerWheel pickerWheel;

    private void Start()
    {
        placeHolder.SetActive(true);
    }

    public void SpinButtonClicked()
    {
        pickerWheel.OnSpinStart(SpinStart);
        pickerWheel.OnSpinEnd(SpinEndEvent);
        
        pickerWheel.Spin();
    }

    private void SpinEndEvent(WheelPiece wheelPiece)
    {
        spinButton.interactable = true;
        spinButtonText.text = "Spin";
        placeHolder.SetActive(false);
        placeHolderText.text = "Click Spin";
        
        rewardTitleText.text = wheelPiece.Label;
        rewardIcon.sprite = wheelPiece.Icon;
        rewardAmountText.text = wheelPiece.Amount.ToString();
    }

    private void SpinStart()
    {
        spinButtonText.text = "Spinning...";
        spinButton.interactable = false;
        
        placeHolder.SetActive(true);
        placeHolderText.text = "Picking a reward...";
    }
}
