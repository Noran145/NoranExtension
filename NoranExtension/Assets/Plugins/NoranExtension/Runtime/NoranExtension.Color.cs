using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Noran.Extension
{
    public partial struct NoranExtension
    {
        /// <summary>
        /// Randomの色を返す
        /// </summary>
        /// <returns></returns>
        public static Color GetRandomColorByRGB()
        {
            var c = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
            return c;
        }

        /// <summary>
        /// Text(TextMeshPro)の色を変更する
        /// </summary>
        /// <param name="tmpText"></param>
        /// <param name="color"></param>
        public static void ChangeTextColor(TMP_Text tmpText, Color color)
        {
            tmpText.color = color;
        }

        /// <summary>
        /// Imageの色を変更する
        /// </summary>
        /// <param name="image"></param>
        /// <param name="color"></param>
        public static void ChangeImageColor(Image image, Color color)
        {
            image.color = color;
        }

        /// <summary>
        /// RawImageの色を変更する
        /// </summary>
        /// <param name="rawImage"></param>
        /// <param name="color"></param>
        public static void ChangeRawImageColor(RawImage rawImage, Color color)
        {
            rawImage.color = color;
        }

        /// <summary>
        /// マテリアルの色を変更する
        /// </summary>
        /// <param name="targetMat"></param>
        /// <param name="color"></param>
        public static void ChangeMaterialColor(Material targetMat, Color color)
        {
            targetMat.color = color;
        }
    }
}
