using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomeUI : BaseUI
{
    [SerializeField] private Button startButton;
    [SerializeField] private Button exitButton;

    public override void Init(UIManager uIManager)
    {
        base.Init(uIManager);

        startButton.onClick.AddListener(OnClickStartButton);
        exitButton.onClick.AddListener(OnClickExitButton);

    }

    public void OnClickStartButton()
    {

    }

    public void OnClickExitButton()
    {
        Application.Quit();
    }

    protected override UIState GetUIstate()
    {
        return UIState.Home;
    }

}
