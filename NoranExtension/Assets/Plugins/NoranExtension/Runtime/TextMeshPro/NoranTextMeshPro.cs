using TMPro;
using UnityEngine;

namespace Noran.Extension.TextMeshPro
{
    public struct NoranTextMeshPro
    {
        public TMP_Text TMPText { get; }
        
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="text"></param>
        public NoranTextMeshPro(TMP_Text text)
        {
            TMPText = text;
        }

        /// <summary>
        /// 任意のタイミングでフォントの色を変える
        /// </summary>
        /// <param name="color"></param>
        public void ChangeTextColor(Color color)
        {
            TMPText.color = color;
        }
    }
}
