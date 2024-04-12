using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] TMP_Text myText;
    [SerializeField] GameObject squarePrefab;
    // Start is called before the first frame update
    int points;

    public int Points
    {
        get { myText.text = points.ToString(); return points; }
        set { points = value; myText.text = points.ToString(); }
    }

    // Start is called before the first frame update


    void Update()
    {
        //myText = FindObjectOfType<TMP_Text>();
        /*GameObject square = Instantiate(squarePrefab, transform);
        float x = Random.Range(0, GetComponent<RectTransform>().rect.width);
        float y = Random.Range(0, GetComponent<RectTransform>().rect.height);

        square.transform.position = new Vector2(x, y);*/
    }
}       








