using System;
using Noran.Extension.TextMeshPro;
using TMPro;
using UniRx;
using UniRx.Triggers;
using UnityEngine;
using UnityEngine.UI;

namespace Noran.Extension.Samples
{
    public class TextMeshProSample : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI displayText;
        [SerializeField] private Button changeColorButton;

        private IObservable<Unit> enterButtonObservable => changeColorButton.OnPointerEnterAsObservable().AsUnitObservable();
        private IObservable<Unit> exitButtonObservable => changeColorButton.OnPointerExitAsObservable().AsUnitObservable();
        private IObservable<Unit> clickButtonObservable => changeColorButton.OnClickAsObservable();

        private void Start()
        {
            var tmp = new NoranTextMeshPro(displayText);

            enterButtonObservable.Merge(
                exitButtonObservable,
                clickButtonObservable.AsUnitObservable()).Subscribe(_ =>
            {
                tmp.ChangeTextColor(NoranExtension.GetRandomColorByRGB());
            }).AddTo(this);
        }
    }
}