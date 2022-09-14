using UnityEngine;
using UnityEngine.UIElements;

namespace Extensions
{
    public static class StyleBackgroundExtensions
    {
        public static void Release(this StyleBackground background)
        {
            if (Application.isPlaying)
            {
                Object.Destroy(background.value.texture);
            }
            else
            {
                Object.DestroyImmediate(background.value.texture);
            }
        }
    }
}