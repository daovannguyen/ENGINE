using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MoveToPosition : MonoBehaviour
{
    public void AddAnimationClip(GameObject gameObjectControl, Vector3 target)
    {
        if (target.x == 0)
        {
            target.x = 0.0001f;
        }
        if (target.y == 0)
        {
            target.y = 0.0001f;
        }
        if (target.z == 0)
        {
            target.z = 0.0001f;
        }
        float x, y, z;
        x = gameObjectControl.transform.localPosition.x;
        y = gameObjectControl.transform.localPosition.y;
        z = gameObjectControl.transform.localPosition.z;
        Animation anim = gameObjectControl.GetComponent<Animation>();
        if (anim == null)
        {
            gameObjectControl.AddComponent<Animation>();
            anim = gameObjectControl.GetComponent<Animation>();
        }
        // create a new AnimationClip
        AnimationClip clip = new AnimationClip();
        clip.legacy = true;

        // create a curve to move the GameObject and assign to the clip
        SetCurve(ref clip, new List<float> { 0, 1, 2}, new List<float> {x, x + target.x, 100000}, "localPosition.x");
        SetCurve(ref clip, new List<float> { 0, 1, 2}, new List<float> {y, y + target.y, 100000}, "localPosition.y");
        SetCurve(ref clip, new List<float> { 0, 1, 2}, new List<float> {y, z + target.z, 100000}, "localPosition.z");



        // update the clip to a change the red color
        //curve = AnimationCurve.Linear(0.0f, 1.0f, 2.0f, 0.0f);
        //clip.SetCurve("", typeof(Material), "_Color.r", curve);

        // now animate the GameObject
        anim.AddClip(clip, clip.name);
        anim.Play(clip.name);
    }

    void SetCurve(ref AnimationClip animationClip, List<float> times, List<float> values, string propertyCurve)
    {
        AnimationCurve curve;
        Keyframe[] keys;
        int keyframeCount = times.Count;
        keys = new Keyframe[keyframeCount];
        for (int i=0; i< keyframeCount; i++)
        {
            keys[i] = new Keyframe(times[i], values[i]);
        }    
        curve = new AnimationCurve(keys);
        animationClip.SetCurve("", typeof(Transform), propertyCurve, curve);
    }
}
