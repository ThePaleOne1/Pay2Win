using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevator : MonoBehaviour
{
    [SerializeField] float growHieght;
    float maxHieght = 5;
    [SerializeField] float speed;

    Trigerable trig;
    public bool isTriggured;

    [SerializeField] bool Inverted;

    Vector2 goal;
    Vector2 start;
    // Start is called before the first frame update
    void Start()
    {
        
        trig = GetComponent<Trigerable>();
        goal = new Vector2(transform.position.x, transform.position.y + Mathf.Clamp(growHieght,0,maxHieght));
        start = transform.position;
        isTriggured = trig.IsTriggered;
    }

    // Update is called once per frame
    void Update()
    {
        if (!Inverted)
        {
            isTriggured = trig.IsTriggered;
        }
        else if(Inverted)
        {
            isTriggured = !trig.IsTriggered;
        }

        if (isTriggured && transform.position.y < goal.y)
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
        else if (!isTriggured && transform.position.y > start.y)
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }


    }
}
