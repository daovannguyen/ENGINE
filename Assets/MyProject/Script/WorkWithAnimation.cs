using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class WorkWithAnimation : MonoBehaviour
{
    [SerializeField]
    public AnimationClip animation;
    public AnimationClip animation2;
    // Start is called before the first frame update
    void Start()
    {
        //animation.SampleAnimation(transform, );
        animation2 = new AnimationClip();
        CreateAnim();
        Debug.Log(animation.name);
    }

    [UnityEditor.MenuItem("TestAnim/Create Test")]
    public static void CreateAnim()
    {
        /*
        AnimationClip clip = new AnimationClip();

        AnimationUtility.SetEditorCurve(clip, EditorCurveBinding.FloatCurve("", typeof(Transform), "m_LocalPosition.y"), AnimationCurve.EaseInOut(0, 0, 1.0f / 6, 2));
        AnimationUtility.SetEditorCurve(clip, EditorCurveBinding.FloatCurve("", typeof(Transform), "m_LocalPosition.y"), AnimationCurve.EaseInOut(1.0f / 6, 2, 2.0f / 6, 0));

        AssetDatabase.CreateAsset(clip, "Assets/Test.anim");*/
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
