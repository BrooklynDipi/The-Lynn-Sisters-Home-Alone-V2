using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuAnimation : MonoBehaviour
{
    public void Start()
    {
        StartCoroutine(fadeOut());


    }

    IEnumerator fadeOut()
    {
        CanvasGroup canvasGroup = GetComponent<CanvasGroup>();
        while (canvasGroup.alpha>0)
        {
            canvasGroup.alpha -= Time.deltaTime / 2;
            yield return null;
        }

        canvasGroup.interactable = false;
        yield return null;
    }
    
}