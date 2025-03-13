using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenAnimation : MonoBehaviour
{
    public CanvasGroup canvasGroup;


    public void StartFade()
    {
        StartCoroutine(FadeInOutRoutine());
    }


    private IEnumerator FadeInOutRoutine()
    {
        float duration = 0.5f;
        float time = 0 ;

        yield return new WaitForSeconds(0.25f);

        //Fade in
        while (time < duration)
        {
            time = time + Time.deltaTime;
            float distance = time / duration;
            canvasGroup.alpha = distance;
            yield return new WaitForEndOfFrame();
        }

        yield return new WaitForSeconds(1);

        //Fade out 
        while (time > 0)
        {
            time = time - Time.deltaTime;
            float distance = time / duration;
            canvasGroup.alpha = distance;
            yield return new WaitForEndOfFrame();
        }

        yield return new WaitForSeconds(0.5f);

        //Reset
        SceneManager.LoadScene("SampleScene");

    }


}
