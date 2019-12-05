using System.Collections;
using UnityEngine;

namespace FixMyProject.Tools
{
    public class FPSCounter : MonoBehaviour
    {
        public TMPro.TMP_Text text;
        private void Start()
        {
            StartCoroutine(Count());
        }

        IEnumerator Count()
        {
            while (true)
            {
                yield return new WaitForSeconds(0.25f);
                text.text = "FPS:" + ((int)((1f / Time.deltaTime) * 10)) / 10f;
            }
        }
    }
}

