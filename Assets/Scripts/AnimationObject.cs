using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationObject : MonoBehaviour
{
    private Animation anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Gerak() {
        anim.Play("Tiger");
    }
}
