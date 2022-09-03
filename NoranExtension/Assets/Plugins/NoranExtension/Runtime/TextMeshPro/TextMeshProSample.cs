using System;
using TMPro;
using UniRx;
using UniRx.Triggers;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

namespace Noran.Extension.TextMeshPro
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
                tmp.ChangeTextColor(RandomColor());
            }).AddTo(this);
        }

        /// <summary>
        /// Randomの色を返す
        /// </summary>
        /// <returns></returns>
        private static Color RandomColor()
        {
            var c = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
            return c;
        }
    }
}