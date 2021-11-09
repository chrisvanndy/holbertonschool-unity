using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformZUI : MonoBehaviour
{

    public LeanTweenType type;
    public float time;
    public float moveZ;

    // Start is called before the first frame update
    void Start()
    {
        TransformZ();
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    public void TransformZ()
    {
         LeanTween.moveZ(gameObject, moveZ, time).setEase(type);
    }
}
