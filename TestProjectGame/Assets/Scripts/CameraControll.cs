using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControll : MonoBehaviour
{
    [SerializeField] private Transform _playertransform;
    [SerializeField] private float _movespeed;
    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = new Vector3()
        {
            y = this._playertransform.position.y,
            x = this._playertransform.position.x,
            z = this._playertransform.position.z - 10
        };
    }

    // Update is called once per frame
    void Update()
    {
        if(this._playertransform)
        {
            Vector3 target = new Vector3()
            {
                y = this._playertransform.position.y,
                x = this._playertransform.position.x,
                z = this._playertransform.position.z - 10
            };

            Vector3 pos = Vector3.Lerp(this.transform.position, target, _movespeed * Time.deltaTime);

            this.transform.position = pos;

        }
    }
}
