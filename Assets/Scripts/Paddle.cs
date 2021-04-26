using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    [SerializeField] float screenWidthInUnits = 16f;
    public float min;
    public float max;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //finding mouse position
        float mousePosInUnits = Input.mousePosition.x / Screen.width * screenWidthInUnits;

        Vector2 paddlePosition = new Vector2(transform.position.x, transform.position.y);

        paddlePosition.x = Mathf.Clamp(mousePosInUnits, min, max);
        transform.position = paddlePosition;
    }
}
