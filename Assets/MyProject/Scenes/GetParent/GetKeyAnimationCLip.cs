using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


public class GetKeyAnimationCLip : MonoBehaviour
{
    public AnimationClip animationClip;
    // Start is called before the first frame update
    void Start()
    {

        Animation anim = GetComponent<Animation>();
        if (anim == null)
        {

            gameObject.AddComponent<Animation>(); 
            anim = GetComponent<Animation>();
        }    
        AnimationCurve curve;

        // create a new AnimationClip
        AnimationClip clip = new AnimationClip();
        //AssetDatabase.CreateAsset(clip, "Assets/MyProject/hihi.aim");
        clip.legacy = true;

        // create a curve to move the GameObject and assign to the clip
        Keyframe[] keys;
        keys = new Keyframe[3];
        keys[0] = new Keyframe(0.0f, 0.0f);
        keys[1] = new Keyframe(1.0f, 4f);
        keys[2] = new Keyframe(2.0f, 0.0f);
        curve = new AnimationCurve(keys);
        clip.SetCurve("", typeof(Transform), "localPosition.x", curve);

        // update the clip to a change the red color
        curve = AnimationCurve.Linear(0.0f, 1.0f, 2.0f, 0.0f);
        clip.SetCurve("", typeof(Material), "_Color.r", curve);
        //AssetDatabase.SaveAssets();
        // now animate the GameObject
        anim.AddClip(clip, clip.name);
        anim.Play(clip.name); 

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
