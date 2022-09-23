using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DOTWEENDELAY : MonoBehaviour
{
  
    // Start is called before the first frame update
    void Start()
    {
        var path = new[] { new Vector3(1.68099f, -0.01825005f, 0.5383548f), new Vector3(1.335226f, 0.04409439f, -1.029598f), new Vector3(1.624687f, -0.8665899f, -1.179232f) };
        Sequence s = DOTween.Sequence();
        s.SetDelay(1f);
        s.Append(transform.DOPath(path, 1f, PathType.CatmullRom).SetEase(Ease.InQuart));
        s.AppendInterval(1f);
        s.SetLoops(-1, LoopType.Restart);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
