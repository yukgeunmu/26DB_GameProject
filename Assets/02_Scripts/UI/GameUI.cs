using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameUI : BaseUI
{

    [SerializeField] private Slider hpSlider;

    public override void Init(UIManager uIManager)
    {
        base.Init(uIManager);
    }

    private void Start()
    {
        UpdateHPSlider(1);
    }

    public void UpdateHPSlider(float percentage)
    {
        hpSlider.value = percentage;
    }



    protected override UIState GetUIstate()
    {
        return UIState.Game;
    }

}
