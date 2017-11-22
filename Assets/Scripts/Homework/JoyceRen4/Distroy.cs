using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distroy : MonoBehaviour
{

    // variables
    private Vector3 minScale;
    public Vector3 maxScale;
    public bool repeatable;
    public float speed = 2f;
    public float duration = 5f;




    void OnTriggerExit(Collider other)
    {
        // Destroy everything that leaves the trigger
        Destroy(other.gameObject);

        if (other.gameObject.tag == "AddLife")
            //物件。取得属性《渲染器》（）。材质。颜色。黄
            gameObject.GetComponent<Renderer>().material.color = Color.red;
            transform.localScale += new Vector3(0.2F, 0, 0);
    }




    // Use this for initialization
    IEnumerator Start()
    {
        minScale = transform.localScale;
        while (repeatable)
        {
            yield return RepeatLerp(minScale, maxScale, duration);
            yield return RepeatLerp(maxScale, minScale, duration);
        }
    }

    public IEnumerator RepeatLerp(Vector3 a, Vector3 b, float time)
    {
        float i = 0.0f;
        float rate = (1.0f / time) * speed;
        while (i < 1.0f)
        {
            i += Time.deltaTime * rate;
            transform.localScale = Vector3.Lerp(a, b, i);
            yield return null;
        }
    }




    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.S))
            this.transform.Translate(0, 0, -1 * 8 * Time.deltaTime);

        if (Input.GetKey(KeyCode.W))
            this.transform.Translate(0, 0, 1 * 8 * Time.deltaTime);

        if (Input.GetKey(KeyCode.A))
            this.transform.Translate(-1 * 8 * Time.deltaTime, 0, 0);

        if (Input.GetKey(KeyCode.D))
            this.transform.Translate(1 * 8 * Time.deltaTime, 0, 0);



    }
}
